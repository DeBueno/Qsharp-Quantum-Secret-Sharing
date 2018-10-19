#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "SetIntToQb (desired : Int, register : Qubit[]) : ()", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 389L, 12L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "GenerateGHZ (register : Qubit[], wordSize : Int) : ()", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 733L, 29L, 5L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "MeasureRegister (register : Qubit[]) : Result[]", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 1055L, 43L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "BellState (q0 : Qubit[], q1 : Qubit[]) : ()", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 1319L, 56L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "BellStateM (q0 : Qubit[], q1 : Qubit[]) : Result[][]", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 1583L, 69L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "CompareResults (array1 : Result[], array2 : Result[]) : Bool", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 1954L, 85L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "itor (i : Int, bits : Int) : Result[]", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 2437L, 113L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "Power (bse : Int, e : Int) : Int", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 2791L, 133L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "rtoi (r : Result[]) : Int", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 3002L, 151L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "ApplyCaseX (cse : Result[], qbit : Qubit[]) : ()", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 3270L, 167L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "ApplyCaseZ (cse : Result[], qbit : Qubit[]) : ()", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 3545L, 183L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "abs (value : Int) : Int", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 3745L, 197L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "SecretSharing (msg : Int, msgSize : Int, basis : String, direction : String, iterations : Int) : Bool", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 3982L, 210L, 2L)]
#line hidden
namespace Quantum.Quantum_Secret_Sharing
{
    public class SetIntToQb : Operation<(Int64,QArray<Qubit>), QVoid>, ICallable
    {
        public SetIntToQb(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Qubit>)>, IApplyData
        {
            public In((Int64,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "SetIntToQb";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.SetIntToQb";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Result>> itor
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (desired,register) = __in;
#line 15 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var length = register.Count;
#line 16 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var Qdesired = itor.Apply((desired, length));
#line 17 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (length - 1L)))
            {
#line 19 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((M.Apply(register[index]) != Qdesired[index]))
                {
#line 21 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(register[index]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.itor = this.Factory.Get<ICallable<(Int64,Int64), QArray<Result>>>(typeof(Quantum.Quantum_Secret_Sharing.itor));
        }

        public override IApplyData __dataIn((Int64,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 desired, QArray<Qubit> register)
        {
            return __m__.Run<SetIntToQb, (Int64,QArray<Qubit>), QVoid>((desired, register));
        }
    }

    public class GenerateGHZ : Operation<(QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public GenerateGHZ(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "GenerateGHZ";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.GenerateGHZ";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (register,wordSize) = __in;
#line 32 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), register?.Slice(new Range(0L, (wordSize - 1L)))));
#line 33 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, ((register.Count - wordSize) - 1L)))
            {
#line 35 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((register[index], register[(wordSize + index)]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register, Int64 wordSize)
        {
            return __m__.Run<GenerateGHZ, (QArray<Qubit>,Int64), QVoid>((register, wordSize));
        }
    }

    public class MeasureRegister : Operation<QArray<Qubit>, QArray<Result>>, ICallable
    {
        public MeasureRegister(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MeasureRegister";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.MeasureRegister";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QArray<Result>> Body => (__in) =>
        {
            var register = __in;
#line 46 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var length = register.Count;
#line 47 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var results = new QArray<Result>(length);
#line 48 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (length - 1L)))
            {
#line 50 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                results[index] = M.Apply(register[index]);
            }

#line 52 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            return results;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QArray<Result> data) => data;
        public static System.Threading.Tasks.Task<QArray<Result>> Run(IOperationFactory __m__, QArray<Qubit> register)
        {
            return __m__.Run<MeasureRegister, QArray<Qubit>, QArray<Result>>(register);
        }
    }

    public class BellState : Operation<(QArray<Qubit>,QArray<Qubit>), QVoid>, ICallable
    {
        public BellState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BellState";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.BellState";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (q0,q1) = __in;
#line 59 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), q0));
#line 60 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (q0.Count - 1L)))
            {
#line 62 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((q0[index], q1[index]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> q0, QArray<Qubit> q1)
        {
            return __m__.Run<BellState, (QArray<Qubit>,QArray<Qubit>), QVoid>((q0, q1));
        }
    }

    public class BellStateM : Operation<(QArray<Qubit>,QArray<Qubit>), QArray<QArray<Result>>>, ICallable
    {
        public BellStateM(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BellStateM";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.BellStateM";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MeasureRegister
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QArray<QArray<Result>>> Body => (__in) =>
        {
            var (q0,q1) = __in;
#line 72 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (q0.Count - 1L)))
            {
#line 74 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((q0[index], q1[index]));
            }

#line 76 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), q0));
#line 77 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var measureQ0 = MeasureRegister.Apply(q0);
#line 78 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var measureQ1 = MeasureRegister.Apply(q1);
#line 79 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            return new QArray<QArray<Result>>(measureQ0, measureQ1);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MeasureRegister = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Quantum.Quantum_Secret_Sharing.MeasureRegister));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Result>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Result>>> Run(IOperationFactory __m__, QArray<Qubit> q0, QArray<Qubit> q1)
        {
            return __m__.Run<BellStateM, (QArray<Qubit>,QArray<Qubit>), QArray<QArray<Result>>>((q0, q1));
        }
    }

    public class CompareResults : Operation<(QArray<Result>,QArray<Result>), Boolean>, ICallable
    {
        public CompareResults(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Result>,QArray<Result>)>, IApplyData
        {
            public In((QArray<Result>,QArray<Result>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "CompareResults";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.CompareResults";
        public override Func<(QArray<Result>,QArray<Result>), Boolean> Body => (__in) =>
        {
            var (array1,array2) = __in;
#line 88 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((array1.Count != array2.Count))
            {
#line 90 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                return false;
            }

#line 92 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (array1.Count - 1L)))
            {
#line 94 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((array1[index] != array2[index]))
                {
#line 96 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    return false;
                }
            }

#line 99 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            return true;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Result>,QArray<Result>) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, QArray<Result> array1, QArray<Result> array2)
        {
            return __m__.Run<CompareResults, (QArray<Result>,QArray<Result>), Boolean>((array1, array2));
        }
    }

    public class itor : Operation<(Int64,Int64), QArray<Result>>, ICallable
    {
        public itor(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "itor";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.itor";
        public override Func<(Int64,Int64), QArray<Result>> Body => (__in) =>
        {
            var (i,bits) = __in;
#line 116 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var Return = new QArray<Result>(bits);
#line 117 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (bits - 1L)))
            {
#line 119 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var bit = $"{(i & (1 << (int)index))}";
#line 120 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((bit == "0"))
                {
#line 122 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    Return[((bits - 1L) - index)] = Result.Zero;
                }
                else
                {
#line 126 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    Return[((bits - 1L) - index)] = Result.One;
                }
            }

#line 129 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            return Return;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Result> data) => data;
        public static System.Threading.Tasks.Task<QArray<Result>> Run(IOperationFactory __m__, Int64 i, Int64 bits)
        {
            return __m__.Run<itor, (Int64,Int64), QArray<Result>>((i, bits));
        }
    }

    public class Power : Operation<(Int64,Int64), Int64>, ICallable
    {
        public Power(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Power";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.Power";
        public override Func<(Int64,Int64), Int64> Body => (__in) =>
        {
            var (bse,e) = __in;
#line 136 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var res = 1L;
#line 138 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((e == 0L))
            {
#line 140 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                return res;
            }

#line 142 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(1L, e))
            {
#line 144 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                res = (bse * res);
            }

#line 146 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            return res;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 bse, Int64 e)
        {
            return __m__.Run<Power, (Int64,Int64), Int64>((bse, e));
        }
    }

    public class rtoi : Operation<QArray<Result>, Int64>, ICallable
    {
        public rtoi(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "rtoi";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.rtoi";
        protected ICallable<(Int64,Int64), Int64> Power
        {
            get;
            set;
        }

        public override Func<QArray<Result>, Int64> Body => (__in) =>
        {
            var r = __in;
#line 154 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var value = 0L;
#line 155 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (r.Count - 1L)))
            {
#line 157 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((r[index] == Result.One))
                {
#line 159 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    value = (value + Power.Apply((2L, ((r.Count - 1L) - index))));
                }
            }

#line 162 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            return value;
        }

        ;
        public override void Init()
        {
            this.Power = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Quantum.Quantum_Secret_Sharing.Power));
        }

        public override IApplyData __dataIn(QArray<Result> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Result> r)
        {
            return __m__.Run<rtoi, QArray<Result>, Int64>(r);
        }
    }

    public class ApplyCaseX : Operation<(QArray<Result>,QArray<Qubit>), QVoid>, ICallable
    {
        public ApplyCaseX(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Result>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Result>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ApplyCaseX";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.ApplyCaseX";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Result>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (cse,qbit) = __in;
#line 170 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var l = cse.Count;
#line 171 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (cse.Count - 1L)))
            {
#line 173 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((cse[index] == Result.One))
                {
                    //Message($"Applied X on index {l-1-index}");
#line 176 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qbit[index]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Result>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Result> cse, QArray<Qubit> qbit)
        {
            return __m__.Run<ApplyCaseX, (QArray<Result>,QArray<Qubit>), QVoid>((cse, qbit));
        }
    }

    public class ApplyCaseZ : Operation<(QArray<Result>,QArray<Qubit>), QVoid>, ICallable
    {
        public ApplyCaseZ(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Result>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Result>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ApplyCaseZ";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.ApplyCaseZ";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(QArray<Result>,QArray<Qubit>), QVoid> Body => (__in) =>
        {
            var (cse,qbit) = __in;
#line 186 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var l = (cse.Count - 1L);
#line 187 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (cse.Count - 1L)))
            {
#line 189 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((cse[index] == Result.One))
                {
#line 191 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    MicrosoftQuantumPrimitiveZ.Apply(qbit[index]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((QArray<Result>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Result> cse, QArray<Qubit> qbit)
        {
            return __m__.Run<ApplyCaseZ, (QArray<Result>,QArray<Qubit>), QVoid>((cse, qbit));
        }
    }

    public class abs : Operation<Int64, Int64>, ICallable
    {
        public abs(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "abs";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.abs";
        public override Func<Int64, Int64> Body => (__in) =>
        {
            var value = __in;
#line 200 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var res = value;
#line 201 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((value < 0L))
            {
#line 203 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                res = (res * -(1L));
            }

#line 205 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            return res;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 value)
        {
            return __m__.Run<abs, Int64, Int64>(value);
        }
    }

    public class SecretSharing : Operation<(Int64,Int64,String,String,Int64), Boolean>, ICallable
    {
        public SecretSharing(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,String,String,Int64)>, IApplyData
        {
            public In((Int64,Int64,String,String,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "SecretSharing";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.SecretSharing";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(QArray<Result>,QArray<Qubit>), QVoid> ApplyCaseX
        {
            get;
            set;
        }

        protected ICallable<(QArray<Result>,QArray<Qubit>), QVoid> ApplyCaseZ
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Qubit>), QArray<QArray<Result>>> BellStateM
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), QVoid> GenerateGHZ
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MeasureRegister
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveS
        {
            get;
            set;
        }

        protected ICallable<(Int64,QArray<Qubit>), QVoid> SetIntToQb
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumExtensionsBitwiseXor
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Result>> itor
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, Int64> rtoi
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,String,String,Int64), Boolean> Body => (__in) =>
        {
            var (msg,msgSize,basis,direction,iterations) = __in;
#line 213 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var success = true;
#line 214 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var register = Allocate.Apply((msgSize * 4L));
            //guarantee that all qubits are set to |0>
#line 217 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            SetIntToQb.Apply((0L, register));
#line 219 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            Message.Apply($"Mesage: {msg}");
#line 220 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var i in new Range(0L, (iterations - 1L)))
            {
                //giving a name to each Qubit for better reading
#line 223 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var MessageToSend = register?.Slice(new Range((3L * msgSize), ((4L * msgSize) - 1L)));
#line 224 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var Alice = register?.Slice(new Range((2L * msgSize), ((3L * msgSize) - 1L)));
#line 225 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var Bob = register?.Slice(new Range(msgSize, ((2L * msgSize) - 1L)));
#line 226 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var Charlie = register?.Slice(new Range(0L, (msgSize - 1L)));
#line 228 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var GHZ = register?.Slice(new Range(0L, ((3L * msgSize) - 1L)));
                //goal: split the message and teleport from Alice to Charlie
                ///set the msg to Qubit
#line 232 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                SetIntToQb.Apply((msg, MessageToSend));
                ///set enconding basis
#line 235 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((basis == "H"))
                {
#line 237 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), MessageToSend));
                }

#line 240 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply($"Generating GHZ State");
#line 241 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                GenerateGHZ.Apply((GHZ, msgSize));
#line 242 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply($"GHZ State generated");
#line 244 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply($"Measuring in respect to Bell State (Message and Alice)");
#line 245 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var BellMeasurement = BellStateM.Apply((MessageToSend, Alice));
#line 246 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var iBellMeasurement0 = rtoi.Apply(BellMeasurement[0L]);
#line 247 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var iBellMeasurement1 = rtoi.Apply(BellMeasurement[1L]);
#line 248 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply($"Bell measure result: {BellMeasurement} {iBellMeasurement0} {iBellMeasurement1}");
#line 250 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply("Measuring Bob register");
#line 251 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), Bob));
#line 252 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((direction == "Y"))
                {
#line 254 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveS), Bob));
                }

#line 256 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var b = MeasureRegister.Apply(Bob);
#line 257 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var iB = rtoi.Apply(b);
#line 258 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply($"Bob result: {b} {iB}");
#line 260 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply("Applying X");
#line 261 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                ApplyCaseX.Apply((BellMeasurement[1L], Charlie));
#line 264 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var aXORb = itor.Apply((MicrosoftQuantumExtensionsBitwiseXor.Apply((rtoi.Apply(BellMeasurement[0L]), rtoi.Apply(b))), msgSize));
#line 265 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply("Applying Z");
#line 266 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                ApplyCaseZ.Apply((aXORb, Charlie));
#line 268 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply("Measuring Charlie register");
#line 269 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((basis == "H"))
                {
#line 271 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), Charlie));
                }

#line 273 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var res = MeasureRegister.Apply(Charlie);
#line 274 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var intRes = rtoi.Apply(res);
#line 277 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                SetIntToQb.Apply((0L, register));
#line 278 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((intRes != msg))
                {
#line 280 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    Message.Apply($"{i} Fault M = {BellMeasurement[0]}, A = {BellMeasurement[1]}, B = {b}, ZControl = {aXORb}");
#line 281 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    success = false;
                }
                else
                {
#line 285 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    Message.Apply($"Final Result: {res} {intRes}");
                }
            }

#line hidden
            Release.Apply(register);
#line 289 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            return success;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.ApplyCaseX = this.Factory.Get<ICallable<(QArray<Result>,QArray<Qubit>), QVoid>>(typeof(Quantum.Quantum_Secret_Sharing.ApplyCaseX));
            this.ApplyCaseZ = this.Factory.Get<ICallable<(QArray<Result>,QArray<Qubit>), QVoid>>(typeof(Quantum.Quantum_Secret_Sharing.ApplyCaseZ));
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.BellStateM = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Qubit>), QArray<QArray<Result>>>>(typeof(Quantum.Quantum_Secret_Sharing.BellStateM));
            this.GenerateGHZ = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(Quantum.Quantum_Secret_Sharing.GenerateGHZ));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MeasureRegister = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Quantum.Quantum_Secret_Sharing.MeasureRegister));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
            this.SetIntToQb = this.Factory.Get<ICallable<(Int64,QArray<Qubit>), QVoid>>(typeof(Quantum.Quantum_Secret_Sharing.SetIntToQb));
            this.MicrosoftQuantumExtensionsBitwiseXor = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Extensions.Bitwise.Xor));
            this.itor = this.Factory.Get<ICallable<(Int64,Int64), QArray<Result>>>(typeof(Quantum.Quantum_Secret_Sharing.itor));
            this.rtoi = this.Factory.Get<ICallable<QArray<Result>, Int64>>(typeof(Quantum.Quantum_Secret_Sharing.rtoi));
        }

        public override IApplyData __dataIn((Int64,Int64,String,String,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 msg, Int64 msgSize, String basis, String direction, Int64 iterations)
        {
            return __m__.Run<SecretSharing, (Int64,Int64,String,String,Int64), Boolean>((msg, msgSize, basis, direction, iterations));
        }
    }
}