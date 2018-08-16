#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "SetIntToQb (desired : Int, register : Qubit[]) : ()", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 343L, 11L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "EntangleRegister (register : Qubit[]) : ()", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 676L, 28L, 5L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "MeasureRegister (register : Qubit[]) : Result[]", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 959L, 43L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "BellState (q0 : Qubit, q1 : Qubit) : ()", new string[] { "Adjoint" }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 1219L, 56L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "BellStateMeasurement (q0 : Qubit, q1 : Qubit) : Result[]", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 1430L, 67L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "CompareResults (array1 : Result[], array2 : Result[]) : Bool", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 1679L, 78L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "itor (i : Int, bits : Int) : Result[]", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 2162L, 106L, 2L)]
[assembly: OperationDeclaration("Quantum.Quantum_Secret_Sharing", "SecretSharing (msg : Int, basis : String) : Bool", new string[] { }, "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs", 2557L, 127L, 2L)]
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
#line 14 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var length = register.Count;
#line 15 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var Qdesired = itor.Apply((desired, length));
#line 16 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (length - 1L)))
            {
#line 18 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((M.Apply(register[index]) != Qdesired[index]))
                {
#line 20 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
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

    public class EntangleRegister : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public EntangleRegister(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "EntangleRegister";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.EntangleRegister";
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

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var register = __in;
#line 31 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(register[0L]);
#line 32 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (register.Count - 2L)))
            {
#line 34 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((register[index], register[(index + 1L)]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register)
        {
            return __m__.Run<EntangleRegister, QArray<Qubit>, QVoid>(register);
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

    public class BellState : Adjointable<(Qubit,Qubit)>, ICallable
    {
        public BellState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "BellState";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.BellState";
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

        public override Func<(Qubit,Qubit), QVoid> Body => (__in) =>
        {
            var (q0,q1) = __in;
#line 59 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(q0);
#line 60 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((q0, q1));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit), QVoid> AdjointBody => (__in) =>
        {
            var (q0,q1) = __in;
            MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((q0, q1));
            MicrosoftQuantumPrimitiveH.Adjoint.Apply(q0);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q0, Qubit q1)
        {
            return __m__.Run<BellState, (Qubit,Qubit), QVoid>((q0, q1));
        }
    }

    public class BellStateMeasurement : Operation<(Qubit,Qubit), QArray<Result>>, ICallable
    {
        public BellStateMeasurement(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "BellStateMeasurement";
        String ICallable.FullName => "Quantum.Quantum_Secret_Sharing.BellStateMeasurement";
        protected IAdjointable<(Qubit,Qubit)> BellState
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Result>> MeasureRegister
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit), QArray<Result>> Body => (__in) =>
        {
            var (q0,q1) = __in;
#line 70 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            BellState.Adjoint.Apply((q0, q1));
#line 71 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var measures = MeasureRegister.Apply(new QArray<Qubit>(q0, q1));
#line 72 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            return measures;
        }

        ;
        public override void Init()
        {
            this.BellState = this.Factory.Get<IAdjointable<(Qubit,Qubit)>>(typeof(Quantum.Quantum_Secret_Sharing.BellState));
            this.MeasureRegister = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Result>>>(typeof(Quantum.Quantum_Secret_Sharing.MeasureRegister));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QArray<Result> data) => data;
        public static System.Threading.Tasks.Task<QArray<Result>> Run(IOperationFactory __m__, Qubit q0, Qubit q1)
        {
            return __m__.Run<BellStateMeasurement, (Qubit,Qubit), QArray<Result>>((q0, q1));
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
#line 81 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((array1.Count != array2.Count))
            {
#line 83 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                return false;
            }

#line 85 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (array1.Count - 1L)))
            {
#line 87 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((array1[index] != array2[index]))
                {
#line 89 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    return false;
                }
            }

#line 92 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
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
#line 109 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var Return = new QArray<Result>(bits);
#line 110 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            foreach (var index in new Range(0L, (bits - 1L)))
            {
#line 112 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                var bit = $"{(i & (1 << (int)index))}";
#line 113 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                if ((bit == "0"))
                {
#line 115 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    Return[((bits - 1L) - index)] = Result.Zero;
                }
                else
                {
#line 119 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                    Return[((bits - 1L) - index)] = Result.One;
                }
            }

#line 122 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
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

    public class SecretSharing : Operation<(Int64,String), Boolean>, ICallable
    {
        public SecretSharing(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,String)>, IApplyData
        {
            public In((Int64,String) data) : base(data)
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

        protected ICallable<(Qubit,Qubit), QArray<Result>> BellStateMeasurement
        {
            get;
            set;
        }

        protected ICallable<(QArray<Result>,QArray<Result>), Boolean> CompareResults
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumExtensionsDiagnosticsDumpRegister
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> EntangleRegister
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveY
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Result>> itor
        {
            get;
            set;
        }

        public override Func<(Int64,String), Boolean> Body => (__in) =>
        {
            var (msg,basis) = __in;
#line 130 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var success = true;
#line 131 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var register = Allocate.Apply(4L);
            //guarantee that all qubits are set to |0>
#line 134 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            SetIntToQb.Apply((0L, register));
            //giving a name to each Qubit for better reading
#line 137 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var MessageToSend = register[3L];
#line 138 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var Alice = register[2L];
#line 139 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var Bob = register[1L];
#line 140 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var Charlie = register[0L];
            //goal: split the message and teleport from Alice to Charlie
            ///set the msg to Qubit
#line 144 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            SetIntToQb.Apply((msg, new QArray<Qubit>()
            {MessageToSend}));
            ///set enconding basis
#line 147 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((basis == "h"))
            {
#line 149 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(MessageToSend);
#line 150 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply("Message enconded in Hadamard basis");
            }
            else
            {
#line 154 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                Message.Apply("Message enconded in Standard basis");
            }

            ///create state |000> + |111>
#line 158 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            EntangleRegister.Apply(new QArray<Qubit>(Alice, Bob, Charlie));
#line 159 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            Message.Apply("GHZ state created.");
            ///measure in respect to bell state the message qubit and alice GHZ qubit
#line 162 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var BellMeasurement = BellStateMeasurement.Apply((MessageToSend, Alice));
#line 163 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            Message.Apply($"Alice measurement with results: {BellMeasurement}");
            ///switch to X direction
#line 166 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(Bob);
#line 167 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            MicrosoftQuantumPrimitiveS.Apply(Bob);
            ///measure
#line 169 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var b = M.Apply(Bob);
#line 170 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            Message.Apply($"Bob measurement in X direction with result: [{b}]");
            ///an array of results from alice and bob
#line 173 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var results = new QArray<Result>(BellMeasurement[0L], BellMeasurement[1L], b);
#line 175 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((CompareResults.Apply((results, itor.Apply((0L, 3L)))) || CompareResults.Apply((results, itor.Apply((5L, 3L))))))
            {
                ///results are either 000 or 101
                //do nothing
                //left here for didatic purpose
                ;
            }

#line 185 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((CompareResults.Apply((results, itor.Apply((1L, 3L)))) || CompareResults.Apply((results, itor.Apply((4L, 3L))))))
            {
                ///results are either 001 or 100
#line 192 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveZ.Apply(Charlie);
            }

#line 194 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((CompareResults.Apply((results, itor.Apply((2L, 3L)))) || CompareResults.Apply((results, itor.Apply((7L, 3L))))))
            {
                //results are either 010 or 111
#line 201 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(Charlie);
            }

#line 203 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((CompareResults.Apply((results, itor.Apply((3L, 3L)))) || CompareResults.Apply((results, itor.Apply((6L, 3L))))))
            {
                ///results are either 011 or 110
#line 210 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveZ.Apply(Charlie);
#line 211 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(Charlie);
            }

#line 214 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((basis == "h"))
            {
                //if it was enconded in Hadamard basis, this will return to the standard basis
#line 217 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(Charlie);
            }

#line 219 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            if ((b == Result.One))
            {
#line 221 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveY.Apply(Charlie);
                //Z(Charlie);
#line 223 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(Charlie);
            }

#line 225 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("Charlie.txt", new QArray<Qubit>()
            {Charlie}));
#line 226 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            var c = M.Apply(Charlie);
#line 228 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            Message.Apply($"Charlie reads: [{c}]");
#line 230 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            SetIntToQb.Apply((0L, register));
#line hidden
            Release.Apply(register);
#line 233 "C:\\Users\\Daniel\\source\\repos\\Quantum Secret Sharing\\Quantum Secret Sharing\\Operation.qs"
            return success;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.BellStateMeasurement = this.Factory.Get<ICallable<(Qubit,Qubit), QArray<Result>>>(typeof(Quantum.Quantum_Secret_Sharing.BellStateMeasurement));
            this.CompareResults = this.Factory.Get<ICallable<(QArray<Result>,QArray<Result>), Boolean>>(typeof(Quantum.Quantum_Secret_Sharing.CompareResults));
            this.MicrosoftQuantumExtensionsDiagnosticsDumpRegister = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpRegister<>));
            this.EntangleRegister = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Quantum.Quantum_Secret_Sharing.EntangleRegister));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
            this.SetIntToQb = this.Factory.Get<ICallable<(Int64,QArray<Qubit>), QVoid>>(typeof(Quantum.Quantum_Secret_Sharing.SetIntToQb));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Y));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
            this.itor = this.Factory.Get<ICallable<(Int64,Int64), QArray<Result>>>(typeof(Quantum.Quantum_Secret_Sharing.itor));
        }

        public override IApplyData __dataIn((Int64,String) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 msg, String basis)
        {
            return __m__.Run<SecretSharing, (Int64,String), Boolean>((msg, basis));
        }
    }
}