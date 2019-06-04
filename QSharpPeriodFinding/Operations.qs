namespace Quantum.QSharpPeriodFinding
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;
    
    operation QuantumPeriodFinding (num : Int, a : Int) : Unit {
        // Get least integer n1 such as : num^2 <= 2^n1
        let n1 = BitSizeI(num) * 2;
        let n2 = BitSizeI(num);
        mutable periodCandidate = 1;
        repeat {
            using ((x, y) = (Qubit[n1], Qubit[n2])) {
                Microsoft.Quantum.Canon.ApplyToEachCA(H, x);

                // |x⟩ |0 (=y)⟩ -> |x⟩ |a^x mod N⟩
                QuantumExponentForPeriodFinding(a, num, x, y);

                // measure y and reset
                mutable tmpResult = new Result[n2];
                for (idx in 0 .. n2 - 1) {
                    set tmpResult w/= idx <-MResetZ(y[idx]);
                }

                // QFT for x
                QFTImpl(x);

                // Measure x and reset
                mutable realResult = new Result[n1];
                for (idx in 0 .. n1 - 1) {
                    set realResult w/= idx <-MResetZ(x[idx]);
                }
                
                // get integer's result from measured array (ex : |011⟩ -> 3)
                let resultBool = [false] + Microsoft.Quantum.Convert.ResultArrayAsBoolArray(realResult); // for making unsigned positive integer, add first bit
                let resultBool_R = Microsoft.Quantum.Arrays.Reversed(resultBool); // because BoolArrayAsBigInt() is Little Endian order
                let resultIntL = Microsoft.Quantum.Convert.BoolArrayAsBigInt(resultBool_R);

                // get period candidate by continued fraction expansion (thanks to Euclid !)
                let gcdL = GreatestCommonDivisorL(resultIntL, 2L^n1);
                let calculatedNumerator = resultIntL / gcdL;
                let calculatedDenominator = 2L^n1 / gcdL;
                let numL = Microsoft.Quantum.Convert.IntAsBigInt(num);
                let approximatedFraction =
                    ContinuedFractionConvergentL(BigFraction(calculatedNumerator, calculatedDenominator), numL);
                let (approximatedNumerator, approximatedDenominator) = approximatedFraction!;
                mutable periodCandidateL = 0L;
                if(approximatedDenominator < 0L) {
                    set periodCandidateL = approximatedDenominator * -1L;
                }
                else {
                    set periodCandidateL = approximatedDenominator;             
                }
                set periodCandidate = ReduceBigIntToInt(periodCandidateL);

                // output for debugging
                Message($"Calculated Fraction : {calculatedNumerator} / {calculatedDenominator}");
                Message($"Approximated Fraction : {approximatedNumerator} / {approximatedDenominator}");
                Message($"Period Candidate : {periodCandidate}");
            }
        }
        until ((periodCandidate != 0) and (ExpModI(a, periodCandidate, num) == 1))
        fixup {
        }

        // output for debugging
        Message("Found period " + Microsoft.Quantum.Convert.IntAsString(periodCandidate));
        Message("");
    }

    // Implement : |x⟩ |0 (=y)⟩ -> |x⟩ |a^x mod N⟩ for some integer a
    // (where y should be |0⟩)
    // This is modified version of QuantumExponentByMudulus() in my post.
    // See https://tsmatz.wordpress.com/2019/05/22/quantum-computing-modulus-add-subtract-multiply-exponent/
    operation QuantumExponentForPeriodFinding (a : Int, N : Int, x : Qubit[], y : Qubit[]) : Unit {
        let n1 = Length(x);
        let n2 = Length(y);

        // set |y⟩ = |1⟩
        X(y[n2 - 1]);

        for(idx in 0 .. n1 - 1) {
            // a^(2^((n1-1) - idx)) is too big, then we reduce beforehand
            mutable a_mod = 1;
            for(power in 1 .. 2^((n1-1) - idx)) {
                set a_mod = (a_mod * a) % N;
            }
            // apply decomposition elements
            Controlled QuantumMultiplyByModulus([x[idx]], (N, a_mod, y));
        }
    }

    operation ReduceBigIntToInt(numL : BigInt) : Int {
        // Check if numL is not large
        Microsoft.Quantum.Diagnostics.Fact(BitSizeL(numL) <= 32, $"Cannot convert to Int. Input is too large");

        mutable resultInt = 0;
        let numArray = Microsoft.Quantum.Convert.BigIntAsBoolArray(numL);
        let numArray_R = Microsoft.Quantum.Arrays.Reversed(numArray); // because BigIntAsBoolArray() is Little Endian order
        let nSize = Length(numArray_R);
        for (idx in 0 .. nSize - 1) {
            if(numArray_R[idx] and ((nSize - 1) - idx <= 31)) {
                set resultInt = resultInt + (2 ^ ((nSize - 1) - idx));
            }
        }
        return resultInt;
    }

    //////////
    // Implement QFT (Quantum Fourier Transform)
    // see https://tsmatz.wordpress.com/2019/04/26/quantum-computing-qsharp-quantum-fourier-transform-and-phase-estimation/
    //////////
    operation QFTImpl (qs : Qubit[]) : Unit is Adj + Ctl
    {
        body (...)
        {
            let nQubits = Length(qs);
            
            for (i in 0 .. nQubits - 1)
            {
                H(qs[i]);
                for (j in i + 1 .. nQubits - 1)
                {
                    Controlled R1Frac([qs[j]], (1, j - i, qs[i]));
                }
            }
            
            Microsoft.Quantum.Canon.SwapReverseRegister(qs);
        }
    }

    //////////
    // Quantum Adder and Multiplier
    // see https://tsmatz.wordpress.com/2019/05/22/quantum-computing-modulus-add-subtract-multiply-exponent/
    //////////

    operation QuantumAdd (x : Qubit[], y : Qubit[]) : Unit is Adj + Ctl {
        let n = Length(x);
        QFTImpl(y);
        for (i in 0 .. n - 1) {
            for (j in 0 .. (n - 1) - i) {
                Controlled R1Frac([x[i + j]], (2, j + 1, (y)[(n - 1) - i]));
            }
        }
        Adjoint QFTImpl(y);
    }

    operation QuantumAddByNumber (x : Qubit[], b : Int) : Unit is Adj + Ctl {
        let n = Length(x);

        QFTImpl(x);
        for (i in 0 .. n - 1) {
            for (j in 0 .. (n - 1) - i) {
                if(not((b / 2^((n - 1) - (i + j))) % 2 == 0)) {
                    R1Frac(2, j + 1, (x)[(n - 1) - i]);
                }
            }
        }
        Adjoint QFTImpl(x);
    }

    operation QuantumAddByModulus (N : Int, x : Qubit[], y : Qubit[]) : Unit is Adj + Ctl {
        using((ancilla, cx, cy) = (Qubit(), Qubit(), Qubit())) {
            // add bit for preventing overflow
            let x_large = [cx] + x;
            let y_large = [cy] + y;
            // |x⟩ |y⟩ -> |x⟩ |x + y⟩
            QuantumAdd(x_large, y_large);
            // |y⟩ -> |y - N⟩
            Adjoint QuantumAddByNumber(y_large, N);
            // Turn on ancilla when first bit is |1⟩ (i.e, when x + y - N < 0)
            Controlled X([y_large[0]], ancilla);
            // Add N back when ancilla is |1⟩
            Controlled QuantumAddByNumber([ancilla], (y_large, N));
            // set ancilla to |0⟩
            Adjoint QuantumAdd(x_large, y_large);
            X(ancilla);
            Controlled X([y_large[0]], ancilla);
            QuantumAdd(x_large, y_large);
        }
    }

    operation QuantumMultiplyByModulus (N : Int, a : Int, y : Qubit[]) : Unit is Adj + Ctl {
        let n = Length(y);
        let a_mod = a % N;

        using (s = Qubit[n]) {
            // start |y⟩ |0⟩

            // apply adder by repeating "a" (integer) times
            for(r in 0 .. a_mod - 1) {
                QuantumAddByModulus(N, y, s);
            }
            // now |y⟩ |a y mod N⟩

            // swap first register and second one by tuple
            Microsoft.Quantum.Canon.ApplyToEachCA(SWAP, Microsoft.Quantum.Arrays.Zip(y, s));
            // now |a y mod N⟩ |y⟩

            // reset all s qubits !
            // but it's tricky because we cannot use "Reset()" since here is controlled operator.
            let a_inv = InverseModI(a_mod, N);
            for(r in 0 .. a_inv - 1) {
                Adjoint QuantumAddByModulus(N, y, s);
            }
        }
    }
}