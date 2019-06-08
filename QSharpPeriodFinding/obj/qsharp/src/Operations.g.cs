#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumPeriodFinding\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"num\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumPeriodFinding\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":6,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumExponentForPeriodFinding\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":63}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":75},\"Item2\":{\"Line\":1,\"Column\":76}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumExponentForPeriodFinding\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"ReduceBigIntToInt\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":93,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"numL\"]},\"Type\":{\"Case\":\"BigInt\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"BigInt\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"ReduceBigIntToInt\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":93,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":113,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":115,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":113,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpPeriodFinding.QFTImpl\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":113,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpPeriodFinding.QFTImpl\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":113,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpPeriodFinding.QFTImpl\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpPeriodFinding.QuantumAdd\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpPeriodFinding.QuantumAdd\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpPeriodFinding.QuantumAdd\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpPeriodFinding.QuantumAddByNumber\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpPeriodFinding.QuantumAddByNumber\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpPeriodFinding.QuantumAddByNumber\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":162,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":162,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":162,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":86}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpPeriodFinding.QuantumAddByModulus\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":162,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":86}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpPeriodFinding.QuantumAddByModulus\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":162,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":86}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpPeriodFinding.QuantumAddByModulus\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumMultiplyByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":183,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumMultiplyByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":183,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumMultiplyByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":183,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":87}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpPeriodFinding.QuantumMultiplyByModulus\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumMultiplyByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":183,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":87}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpPeriodFinding.QuantumMultiplyByModulus\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpPeriodFinding\",\"Name\":\"QuantumMultiplyByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Shor-Algorithm/QSharpPeriodFinding/Operations.qs\",\"Position\":{\"Item1\":183,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":87}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpPeriodFinding.QuantumMultiplyByModulus\"]}")]
#line hidden
namespace Quantum.QSharpPeriodFinding
{
    public partial class QuantumPeriodFinding : Operation<(Int64,Int64), QVoid>, ICallable
    {
        public QuantumPeriodFinding(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "QuantumPeriodFinding";
        String ICallable.FullName => "Quantum.QSharpPeriodFinding.QuantumPeriodFinding";
        protected ICallable MicrosoftQuantumArraysReversed
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable<IQArray<Boolean>, System.Numerics.BigInteger> MicrosoftQuantumConvertBoolArrayAsBigInt
        {
            get;
            set;
        }

        protected ICallable<Int64, System.Numerics.BigInteger> MicrosoftQuantumConvertIntAsBigInt
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumConvertIntAsString
        {
            get;
            set;
        }

        protected ICallable<IQArray<Result>, IQArray<Boolean>> MicrosoftQuantumConvertResultArrayAsBoolArray
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(System.Numerics.BigInteger,System.Numerics.BigInteger), Microsoft.Quantum.Math.BigFraction> MicrosoftQuantumMathBigFraction
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathBitSizeI
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Math.BigFraction,System.Numerics.BigInteger), Microsoft.Quantum.Math.BigFraction> MicrosoftQuantumMathContinuedFractionConvergentL
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64), Int64> MicrosoftQuantumMathExpModI
        {
            get;
            set;
        }

        protected ICallable<(System.Numerics.BigInteger,System.Numerics.BigInteger), System.Numerics.BigInteger> MicrosoftQuantumMathGreatestCommonDivisorL
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> QFTImpl
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid> QuantumExponentForPeriodFinding
        {
            get;
            set;
        }

        protected ICallable<System.Numerics.BigInteger, Int64> ReduceBigIntToInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QVoid> Body => (__in__) =>
        {
            var (num,a) = __in__;
#line 9 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var n1 = (MicrosoftQuantumMathBitSizeI.Apply(num) * 2L);
#line 10 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var n2 = MicrosoftQuantumMathBitSizeI.Apply(num);
#line 11 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var periodCandidate = 1L;
#line 12 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            while (true)
            {
#line hidden
                {
#line 13 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    var (x,y) = (Allocate.Apply(n1), Allocate.Apply(n2));
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 14 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicH, x));
#line 17 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        QuantumExponentForPeriodFinding.Apply((a, num, x, y));
#line 20 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var tmpResult = QArray<Result>.Create(n2);
#line 21 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        foreach (var idx in new Range(0L, (n2 - 1L)))
#line hidden
                        {
#line 22 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                            tmpResult.Modify(idx, MicrosoftQuantumMeasurementMResetZ.Apply(y[idx]));
                        }

#line 26 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        QFTImpl.Apply(x);
#line 29 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var realResult = QArray<Result>.Create(n1);
#line 30 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        foreach (var idx in new Range(0L, (n1 - 1L)))
#line hidden
                        {
#line 31 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                            realResult.Modify(idx, MicrosoftQuantumMeasurementMResetZ.Apply(x[idx]));
                        }

#line 35 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var resultBool = (IQArray<Boolean>)QArray<Boolean>.Add(new QArray<Boolean>(false), MicrosoftQuantumConvertResultArrayAsBoolArray.Apply(realResult?.Copy()));
#line 36 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var resultBool_R = (IQArray<Boolean>)MicrosoftQuantumArraysReversed.Apply<IQArray<Boolean>>(resultBool);
#line 37 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var resultIntL = MicrosoftQuantumConvertBoolArrayAsBigInt.Apply(resultBool_R);
#line 40 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var gcdL = MicrosoftQuantumMathGreatestCommonDivisorL.Apply((resultIntL, System.Numerics.BigInteger.Parse("2").Pow(n1)));
#line 41 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var calculatedNumerator = (resultIntL / gcdL);
#line 42 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var calculatedDenominator = (System.Numerics.BigInteger.Parse("2").Pow(n1) / gcdL);
#line 43 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var numL = MicrosoftQuantumConvertIntAsBigInt.Apply(num);
#line 44 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var approximatedFraction = MicrosoftQuantumMathContinuedFractionConvergentL.Apply((new Microsoft.Quantum.Math.BigFraction((calculatedNumerator, calculatedDenominator)), numL));
#line 46 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var (approximatedNumerator,approximatedDenominator) = approximatedFraction.Data;
#line 47 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        var periodCandidateL = System.Numerics.BigInteger.Parse("0");
#line 48 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        if ((approximatedDenominator < System.Numerics.BigInteger.Parse("0")))
                        {
#line 49 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                            periodCandidateL = (approximatedDenominator * -(System.Numerics.BigInteger.Parse("1")));
                        }
                        else
                        {
#line 52 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                            periodCandidateL = approximatedDenominator;
                        }

#line 54 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        periodCandidate = ReduceBigIntToInt.Apply(periodCandidateL);
#line 57 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        MicrosoftQuantumIntrinsicMessage.Apply(String.Format("Measured Fraction : {0} / {1}", resultIntL, System.Numerics.BigInteger.Parse("2").Pow(n1)));
#line 58 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        MicrosoftQuantumIntrinsicMessage.Apply(String.Format("Approximated Fraction : {0} / {1}", approximatedNumerator, approximatedDenominator));
#line 59 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        MicrosoftQuantumIntrinsicMessage.Apply(String.Format("Period Candidate : {0}", periodCandidate));
                    }
#line hidden
                    catch (Exception __arg2__)
                    {
                        __arg1__ = __arg2__;
                        throw __arg1__;
                    }
#line hidden
                    finally
                    {
                        if (__arg1__ != null)
                        {
                            throw __arg1__;
                        }

#line hidden
                        Release.Apply(x);
#line hidden
                        Release.Apply(y);
                    }
                }

                if (((periodCandidate != 0L) && (MicrosoftQuantumMathExpModI.Apply((a, periodCandidate, num)) == 1L)))
                {
                    break;
                }
                else
                {
                }
            }

#line 67 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            MicrosoftQuantumIntrinsicMessage.Apply(("Found period " + MicrosoftQuantumConvertIntAsString.Apply(periodCandidate)));
#line 68 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            MicrosoftQuantumIntrinsicMessage.Apply("");
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysReversed = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Reversed<>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumConvertBoolArrayAsBigInt = this.Factory.Get<ICallable<IQArray<Boolean>, System.Numerics.BigInteger>>(typeof(Microsoft.Quantum.Convert.BoolArrayAsBigInt));
            this.MicrosoftQuantumConvertIntAsBigInt = this.Factory.Get<ICallable<Int64, System.Numerics.BigInteger>>(typeof(Microsoft.Quantum.Convert.IntAsBigInt));
            this.MicrosoftQuantumConvertIntAsString = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Convert.IntAsString));
            this.MicrosoftQuantumConvertResultArrayAsBoolArray = this.Factory.Get<ICallable<IQArray<Result>, IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsBoolArray));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumMathBigFraction = this.Factory.Get<ICallable<(System.Numerics.BigInteger,System.Numerics.BigInteger), Microsoft.Quantum.Math.BigFraction>>(typeof(Microsoft.Quantum.Math.BigFraction));
            this.MicrosoftQuantumMathBitSizeI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.BitSizeI));
            this.MicrosoftQuantumMathContinuedFractionConvergentL = this.Factory.Get<ICallable<(Microsoft.Quantum.Math.BigFraction,System.Numerics.BigInteger), Microsoft.Quantum.Math.BigFraction>>(typeof(Microsoft.Quantum.Math.ContinuedFractionConvergentL));
            this.MicrosoftQuantumMathExpModI = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Math.ExpModI));
            this.MicrosoftQuantumMathGreatestCommonDivisorL = this.Factory.Get<ICallable<(System.Numerics.BigInteger,System.Numerics.BigInteger), System.Numerics.BigInteger>>(typeof(Microsoft.Quantum.Math.GreatestCommonDivisorL));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.QFTImpl = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(QFTImpl));
            this.QuantumExponentForPeriodFinding = this.Factory.Get<ICallable<(Int64,Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid>>(typeof(QuantumExponentForPeriodFinding));
            this.ReduceBigIntToInt = this.Factory.Get<ICallable<System.Numerics.BigInteger, Int64>>(typeof(ReduceBigIntToInt));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 num, Int64 a)
        {
            return __m__.Run<QuantumPeriodFinding, (Int64,Int64), QVoid>((num, a));
        }
    }

    public partial class QuantumExponentForPeriodFinding : Operation<(Int64,Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid>, ICallable
    {
        public QuantumExponentForPeriodFinding(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,Int64,IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "QuantumExponentForPeriodFinding";
        String ICallable.FullName => "Quantum.QSharpPeriodFinding.QuantumExponentForPeriodFinding";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,IQArray<Qubit>)> QuantumMultiplyByModulus
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (a,N,x,y) = __in__;
#line 76 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var n1 = x.Length;
#line 77 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var n2 = y.Length;
#line 80 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            MicrosoftQuantumIntrinsicX.Apply(y[(n2 - 1L)]);
#line 82 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            foreach (var idx in new Range(0L, (n1 - 1L)))
#line hidden
            {
#line 84 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                var a_mod = 1L;
#line 85 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                foreach (var power in new Range(1L, 2L.Pow(((n1 - 1L) - idx))))
#line hidden
                {
#line 86 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    a_mod = ((a_mod * a) % N);
                }

#line 89 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                QuantumMultiplyByModulus.Controlled.Apply((new QArray<Qubit>(x[idx]), (N, a_mod, y)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.QuantumMultiplyByModulus = this.Factory.Get<IUnitary<(Int64,Int64,IQArray<Qubit>)>>(typeof(QuantumMultiplyByModulus));
        }

        public override IApplyData __dataIn((Int64,Int64,IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 a, Int64 N, IQArray<Qubit> x, IQArray<Qubit> y)
        {
            return __m__.Run<QuantumExponentForPeriodFinding, (Int64,Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid>((a, N, x, y));
        }
    }

    public partial class ReduceBigIntToInt : Operation<System.Numerics.BigInteger, Int64>, ICallable
    {
        public ReduceBigIntToInt(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReduceBigIntToInt";
        String ICallable.FullName => "Quantum.QSharpPeriodFinding.ReduceBigIntToInt";
        protected ICallable MicrosoftQuantumArraysReversed
        {
            get;
            set;
        }

        protected ICallable<System.Numerics.BigInteger, IQArray<Boolean>> MicrosoftQuantumConvertBigIntAsBoolArray
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
        {
            get;
            set;
        }

        protected ICallable<System.Numerics.BigInteger, Int64> MicrosoftQuantumMathBitSizeL
        {
            get;
            set;
        }

        public override Func<System.Numerics.BigInteger, Int64> Body => (__in__) =>
        {
            var numL = __in__;
#line 96 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            MicrosoftQuantumDiagnosticsFact.Apply(((MicrosoftQuantumMathBitSizeL.Apply(numL) <= 32L), "Cannot convert to Int. Input is too large"));
#line 98 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var resultInt = 0L;
#line 99 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var numArray = (IQArray<Boolean>)MicrosoftQuantumConvertBigIntAsBoolArray.Apply(numL);
#line 100 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var numArray_R = (IQArray<Boolean>)MicrosoftQuantumArraysReversed.Apply<IQArray<Boolean>>(numArray);
#line 101 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var nSize = numArray_R.Length;
#line 102 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            foreach (var idx in new Range(0L, (nSize - 1L)))
#line hidden
            {
#line 103 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                if ((numArray_R[idx] && (((nSize - 1L) - idx) <= 31L)))
                {
#line 104 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    resultInt = (resultInt + 2L.Pow(((nSize - 1L) - idx)));
                }
            }

#line 107 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            return resultInt;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysReversed = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Reversed<>));
            this.MicrosoftQuantumConvertBigIntAsBoolArray = this.Factory.Get<ICallable<System.Numerics.BigInteger, IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.BigIntAsBoolArray));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.MicrosoftQuantumMathBitSizeL = this.Factory.Get<ICallable<System.Numerics.BigInteger, Int64>>(typeof(Microsoft.Quantum.Math.BitSizeL));
        }

        public override IApplyData __dataIn(System.Numerics.BigInteger data) => new QTuple<System.Numerics.BigInteger>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, System.Numerics.BigInteger numL)
        {
            return __m__.Run<ReduceBigIntToInt, System.Numerics.BigInteger, Int64>(numL);
        }
    }

    public partial class QFTImpl : Unitary<IQArray<Qubit>>, ICallable
    {
        public QFTImpl(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "QFTImpl";
        String ICallable.FullName => "Quantum.QSharpPeriodFinding.QFTImpl";
        protected IUnitary<IQArray<Qubit>> MicrosoftQuantumCanonSwapReverseRegister
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumIntrinsicR1Frac
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 118 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var nQubits = qs.Length;
#line 120 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            foreach (var i in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 122 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                MicrosoftQuantumIntrinsicH.Apply(qs[i]);
#line 123 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                foreach (var j in new Range((i + 1L), (nQubits - 1L)))
#line hidden
                {
#line 125 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Apply((new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i])));
                }
            }

#line 129 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            MicrosoftQuantumCanonSwapReverseRegister.Apply(qs);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(qs);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range((i + 1L), (nQubits - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Adjoint.Apply((new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i])));
                }

#line hidden
                MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            foreach (var i in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicH.Controlled.Apply((__controlQubits__, qs[i]));
#line hidden
                foreach (var j in new Range((i + 1L), (nQubits - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i]))));
                }
            }

#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__, qs));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range((i + 1L), (nQubits - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i]))));
                }

#line hidden
                MicrosoftQuantumIntrinsicH.Adjoint.Controlled.Apply((__controlQubits__, qs[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<QFTImpl, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class QuantumAdd : Unitary<(IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public QuantumAdd(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "QuantumAdd";
        String ICallable.FullName => "Quantum.QSharpPeriodFinding.QuantumAdd";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumIntrinsicR1Frac
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> QFTImpl
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 139 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var n = x.Length;
#line 140 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            QFTImpl.Apply(y);
#line 141 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line 142 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                foreach (var j in new Range(0L, ((n - 1L) - i)))
#line hidden
                {
#line 143 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Apply((new QArray<Qubit>(x[(i + j)]), (2L, (j + 1L), y[((n - 1L) - i)])));
                }
            }

#line 146 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            QFTImpl.Adjoint.Apply(y);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Apply(y);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (n - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, ((n - 1L) - i))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Adjoint.Apply((new QArray<Qubit>(x[(i + j)]), (2L, (j + 1L), y[((n - 1L) - i)])));
                }
            }

#line hidden
            QFTImpl.Adjoint.Apply(y);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(x,y)) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Controlled.Apply((__controlQubits__, y));
#line hidden
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line hidden
                foreach (var j in new Range(0L, ((n - 1L) - i)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(x[(i + j)]), (2L, (j + 1L), y[((n - 1L) - i)]))));
                }
            }

#line hidden
            QFTImpl.Adjoint.Controlled.Apply((__controlQubits__, y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(x,y)) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, y));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (n - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, ((n - 1L) - i))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(x[(i + j)]), (2L, (j + 1L), y[((n - 1L) - i)]))));
                }
            }

#line hidden
            QFTImpl.Adjoint.Controlled.Apply((__controlQubits__, y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
            this.QFTImpl = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(QFTImpl));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, IQArray<Qubit> y)
        {
            return __m__.Run<QuantumAdd, (IQArray<Qubit>,IQArray<Qubit>), QVoid>((x, y));
        }
    }

    public partial class QuantumAddByNumber : Unitary<(IQArray<Qubit>,Int64)>, ICallable
    {
        public QuantumAddByNumber(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "QuantumAddByNumber";
        String ICallable.FullName => "Quantum.QSharpPeriodFinding.QuantumAddByNumber";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumIntrinsicR1Frac
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> QFTImpl
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (x,b) = __in__;
#line 150 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var n = x.Length;
#line 152 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            QFTImpl.Apply(x);
#line 153 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line 154 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                foreach (var j in new Range(0L, ((n - 1L) - i)))
#line hidden
                {
#line 155 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    if (!((((b / 2L.Pow(((n - 1L) - (i + j)))) % 2L) == 0L)))
                    {
#line 156 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        MicrosoftQuantumIntrinsicR1Frac.Apply((2L, (j + 1L), x[((n - 1L) - i)]));
                    }
                }
            }

#line 160 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            QFTImpl.Adjoint.Apply(x);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (x,b) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Apply(x);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (n - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, ((n - 1L) - i))))
#line hidden
                {
#line hidden
                    if (!((((b / 2L.Pow(((n - 1L) - (i + j)))) % 2L) == 0L)))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicR1Frac.Adjoint.Apply((2L, (j + 1L), x[((n - 1L) - i)]));
                    }
                }
            }

#line hidden
            QFTImpl.Adjoint.Apply(x);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(x,b)) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Controlled.Apply((__controlQubits__, x));
#line hidden
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line hidden
                foreach (var j in new Range(0L, ((n - 1L) - i)))
#line hidden
                {
#line hidden
                    if (!((((b / 2L.Pow(((n - 1L) - (i + j)))) % 2L) == 0L)))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicR1Frac.Controlled.Apply((__controlQubits__, (2L, (j + 1L), x[((n - 1L) - i)])));
                    }
                }
            }

#line hidden
            QFTImpl.Adjoint.Controlled.Apply((__controlQubits__, x));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(x,b)) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, x));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (n - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, ((n - 1L) - i))))
#line hidden
                {
#line hidden
                    if (!((((b / 2L.Pow(((n - 1L) - (i + j)))) % 2L) == 0L)))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicR1Frac.Adjoint.Controlled.Apply((__controlQubits__, (2L, (j + 1L), x[((n - 1L) - i)])));
                    }
                }
            }

#line hidden
            QFTImpl.Adjoint.Controlled.Apply((__controlQubits__, x));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
            this.QFTImpl = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(QFTImpl));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Int64 b)
        {
            return __m__.Run<QuantumAddByNumber, (IQArray<Qubit>,Int64), QVoid>((x, b));
        }
    }

    public partial class QuantumAddByModulus : Unitary<(Int64,IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public QuantumAddByModulus(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "QuantumAddByModulus";
        String ICallable.FullName => "Quantum.QSharpPeriodFinding.QuantumAddByModulus";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>)> QuantumAdd
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Int64)> QuantumAddByNumber
        {
            get;
            set;
        }

        public override Func<(Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (N,x,y) = __in__;
#line hidden
            {
#line 164 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                var (ancilla,cx,cy) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 166 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    var x_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cx), x);
#line 167 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    var y_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cy), y);
#line 169 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    QuantumAdd.Apply((x_large, y_large));
#line 171 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    QuantumAddByNumber.Adjoint.Apply((y_large, N));
#line 173 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((new QArray<Qubit>(y_large[0L]), ancilla));
#line 175 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    QuantumAddByNumber.Controlled.Apply((new QArray<Qubit>(ancilla), (y_large, N)));
#line 177 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    QuantumAdd.Adjoint.Apply((x_large, y_large));
#line 178 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(ancilla);
#line 179 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((new QArray<Qubit>(y_large[0L]), ancilla));
#line 180 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    QuantumAdd.Apply((x_large, y_large));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(ancilla);
#line hidden
                    Release.Apply(cx);
#line hidden
                    Release.Apply(cy);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (N,x,y) = __in__;
#line hidden
            {
#line hidden
                var (ancilla,cx,cy) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var x_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cx), x);
#line hidden
                    var y_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cy), y);
#line hidden
                    QuantumAdd.Adjoint.Apply((x_large, y_large));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((new QArray<Qubit>(y_large[0L]), ancilla));
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(ancilla);
#line hidden
                    QuantumAdd.Adjoint.Adjoint.Apply((x_large, y_large));
#line hidden
                    QuantumAddByNumber.Controlled.Adjoint.Apply((new QArray<Qubit>(ancilla), (y_large, N)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((new QArray<Qubit>(y_large[0L]), ancilla));
#line hidden
                    QuantumAddByNumber.Adjoint.Adjoint.Apply((y_large, N));
#line hidden
                    QuantumAdd.Adjoint.Apply((x_large, y_large));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(ancilla);
#line hidden
                    Release.Apply(cx);
#line hidden
                    Release.Apply(cy);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(N,x,y)) = __in__;
#line hidden
            {
#line hidden
                var (ancilla,cx,cy) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var x_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cx), x);
#line hidden
                    var y_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cy), y);
#line hidden
                    QuantumAdd.Controlled.Apply((__controlQubits__, (x_large, y_large)));
#line hidden
                    QuantumAddByNumber.Adjoint.Controlled.Apply((__controlQubits__, (y_large, N)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(y_large[0L]), ancilla)));
#line hidden
                    QuantumAddByNumber.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(ancilla), (y_large, N))));
#line hidden
                    QuantumAdd.Adjoint.Controlled.Apply((__controlQubits__, (x_large, y_large)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, ancilla));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(y_large[0L]), ancilla)));
#line hidden
                    QuantumAdd.Controlled.Apply((__controlQubits__, (x_large, y_large)));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(ancilla);
#line hidden
                    Release.Apply(cx);
#line hidden
                    Release.Apply(cy);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(N,x,y)) = __in__;
#line hidden
            {
#line hidden
                var (ancilla,cx,cy) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var x_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cx), x);
#line hidden
                    var y_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cy), y);
#line hidden
                    QuantumAdd.Adjoint.Controlled.Apply((__controlQubits__, (x_large, y_large)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(y_large[0L]), ancilla)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, ancilla));
#line hidden
                    QuantumAdd.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (x_large, y_large)));
#line hidden
                    QuantumAddByNumber.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(ancilla), (y_large, N))));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(y_large[0L]), ancilla)));
#line hidden
                    QuantumAddByNumber.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (y_large, N)));
#line hidden
                    QuantumAdd.Adjoint.Controlled.Apply((__controlQubits__, (x_large, y_large)));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(ancilla);
#line hidden
                    Release.Apply(cx);
#line hidden
                    Release.Apply(cy);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.QuantumAdd = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QuantumAdd));
            this.QuantumAddByNumber = this.Factory.Get<IUnitary<(IQArray<Qubit>,Int64)>>(typeof(QuantumAddByNumber));
        }

        public override IApplyData __dataIn((Int64,IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, IQArray<Qubit> x, IQArray<Qubit> y)
        {
            return __m__.Run<QuantumAddByModulus, (Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid>((N, x, y));
        }
    }

    public partial class QuantumMultiplyByModulus : Unitary<(Int64,Int64,IQArray<Qubit>)>, ICallable
    {
        public QuantumMultiplyByModulus(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,Int64,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "QuantumMultiplyByModulus";
        String ICallable.FullName => "Quantum.QSharpPeriodFinding.QuantumMultiplyByModulus";
        protected ICallable MicrosoftQuantumArraysZip
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumMathInverseModI
        {
            get;
            set;
        }

        protected IUnitary<(Int64,IQArray<Qubit>,IQArray<Qubit>)> QuantumAddByModulus
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (N,a,y) = __in__;
#line 185 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var n = y.Length;
#line 186 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
            var a_mod = (a % N);
#line hidden
            {
#line 188 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 192 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    foreach (var r in new Range(0L, (a_mod - 1L)))
#line hidden
                    {
#line 193 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        QuantumAddByModulus.Apply((N, y, s));
                    }

#line 198 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s))));
#line 203 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, N));
#line 204 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                    foreach (var r in new Range(0L, (a_inv - 1L)))
#line hidden
                    {
#line 205 "C:\\Demo\\Quantum-Shor-Algorithm\\QSharpPeriodFinding\\Operations.qs"
                        QuantumAddByModulus.Adjoint.Apply((N, y, s));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (N,a,y) = __in__;
#line hidden
            var n = y.Length;
#line hidden
            var a_mod = (a % N);
#line hidden
            {
#line hidden
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, N));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_inv - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Adjoint.Adjoint.Apply((N, y, s));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s))));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_mod - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Adjoint.Apply((N, y, s));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,Int64,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(N,a,y)) = __in__;
#line hidden
            var n = y.Length;
#line hidden
            var a_mod = (a % N);
#line hidden
            {
#line hidden
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    foreach (var r in new Range(0L, (a_mod - 1L)))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Controlled.Apply((__controlQubits__, (N, y, s)));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s)))));
#line hidden
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, N));
#line hidden
                    foreach (var r in new Range(0L, (a_inv - 1L)))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Adjoint.Controlled.Apply((__controlQubits__, (N, y, s)));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,Int64,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(N,a,y)) = __in__;
#line hidden
            var n = y.Length;
#line hidden
            var a_mod = (a % N);
#line hidden
            {
#line hidden
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, N));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_inv - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (N, y, s)));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s)))));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_mod - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Adjoint.Controlled.Apply((__controlQubits__, (N, y, s)));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysZip = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Zip<,>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
            this.MicrosoftQuantumMathInverseModI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Math.InverseModI));
            this.QuantumAddByModulus = this.Factory.Get<IUnitary<(Int64,IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QuantumAddByModulus));
        }

        public override IApplyData __dataIn((Int64,Int64,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, Int64 a, IQArray<Qubit> y)
        {
            return __m__.Run<QuantumMultiplyByModulus, (Int64,Int64,IQArray<Qubit>), QVoid>((N, a, y));
        }
    }
}