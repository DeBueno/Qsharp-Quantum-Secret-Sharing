namespace Quantum.Quantum_Secret_Sharing
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Diagnostics;
	open Microsoft.Quantum.Extensions.Math;

	/// # Summary
	/// Set a Qubit register to the int value given
	operation SetIntToQb (desired : Int, register : Qubit[]) : ()
	{
		body
		{
			let length = Length(register);
			let Qdesired = itor(desired, length);
			for(index in 0..length-1)
			{
				if(M(register[index]) != Qdesired[index])
				{
					X(register[index]);
				}
			}
		}
	}
	/// # Summary
	/// Entangle n Qubits
    operation EntangleRegister (register : Qubit[]) : ()
    {
        body
        {
			H(register[0]);
			for(index in 0..Length(register)-2)
			{
				CNOT(register[index], register[index+1]);
			}
			
        }
    }

	/// # Summary
	/// measure an array of Qubits
	operation MeasureRegister(register : Qubit[]) : (Result[])
	{
		body
		{
			let length = Length(register);
			mutable results = new Result[length];
			for(index in 0..length-1)
			{
				set results[index] = M(register[index]);
			}
			return results;
		}
	}
	operation BellState(q0: Qubit, q1: Qubit) : ()
	{
		body
		{
			H(q0);
			CNOT(q0, q1);
		}
		adjoint auto;
	}
	/// # Summary
	/// Makes a measurement in respect to the Bell basis
	operation BellStateMeasurement(q0 : Qubit, q1 : Qubit):(Result[])
	{
		body
		{
			(Adjoint BellState)(q0,q1);
			let measures = MeasureRegister([q0;q1]);
			return measures;
		}
	}
	/// # Summary
	/// Compares two arrays of Results
	operation CompareResults(array1 : Result[], array2 : Result[]):(Bool)
	{
		body
		{
			if(Length(array1) != Length(array2))
			{
				return false;
			}
			for(index in 0..Length(array1)-1)
			{
				if(array1[index] != array2[index])
				{
					return false;
				}
			}
			return true;
		}
	}

	/// # Summary
	/// Converts Int to Result
	/// # Input
	/// ## i
	/// A int value desired to convert
	/// ## bits
	/// How big the Result array should be
	/// # Output
	/// Result[]
	operation itor(i : Int, bits : Int): (Result[])
	{
		body
		{
			mutable Return = new Result[bits];
			for(index in 0..bits-1)
			{
				mutable bit = $"{(i & (1 << (int)index))}";
				if(bit == "0")
				{
					set Return[bits-1-index] = Zero;
				}
				else
				{
					set Return[bits-1-index] = One;
				}
			}
			return Return;
		}
	}

	operation SecretSharing(msg : Int, basis : String) : (Bool)
	{
		body
		{
			mutable success = true;
			using(register = Qubit[4])
			{
				//guarantee that all qubits are set to |0>
				SetIntToQb(0, register);

				//giving a name to each Qubit for better reading
				let MessageToSend = register[3];
				let Alice = register[2];
				let Bob = register[1];
				let Charlie = register[0];
				//goal: split the message and teleport from Alice to Charlie

				///set the msg to Qubit
				SetIntToQb(msg, [MessageToSend]);

				///set enconding basis
				if(basis == "h")
				{
					H(MessageToSend);
					Message("Message enconded in Hadamard basis");
				}
				else
				{
					Message("Message enconded in Standard basis");
				}

				///create state |000> + |111>
				EntangleRegister([Alice; Bob; Charlie]);
				Message("GHZ state created.");

				///measure in respect to bell state the message qubit and alice GHZ qubit
				let BellMeasurement = BellStateMeasurement(MessageToSend, Alice);
				Message($"Alice measurement with results: {BellMeasurement}");

				///switch to X direction
				H(Bob);
				///measure
				let b = M(Bob);
				Message($"Bob measurement in X direction with result: [{b}]");
				
				///an array of results from alice and bob
				let results = [BellMeasurement[0]; BellMeasurement[1]; b];
				
				if
				(
					CompareResults(results, itor(0, 3))		||
					CompareResults(results, itor(5, 3))	
				)
				{
					///results are either 000 or 101
					//do nothing
					//left here for didatic purpose
				}
				if
				(
					CompareResults(results, itor(1, 3))		||
					CompareResults(results, itor(4, 3))
				)
				{
					///results are either 001 or 100
					Z(Charlie);
				}
				if
				(
					CompareResults(results, itor(2, 3))		||
					CompareResults(results, itor(7, 3))
				)
				{
					//results are either 010 or 111
					X(Charlie);
				}
				if
				(
					CompareResults(results, itor(3, 3))		||
					CompareResults(results, itor(6, 3))
				)
				{
					///results are either 011 or 110
					Z(Charlie);
					X(Charlie);
				}

				if(basis == "h")
				{
					//if it was enconded in Hadamard basis, this will return to the standard basis
					H(Charlie);
				}

				DumpRegister("Charlie.txt", [Charlie]);
				let c = M(Charlie);

				Message($"Charlie reads: [{c}]");
				
				SetIntToQb(0, register);
			}

			return success;
		}
	}
}
