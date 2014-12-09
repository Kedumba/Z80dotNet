﻿// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "LDI + LDD + LDIR + LDDR      .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The LDI instruction.
        /// </summary>
        byte LDI()
        {
            FetchFinished();

            var sourceAddress = Registers.HL;
            var destAddress = Registers.DE;
            var counter = Registers.BC;
            var value = ProcessorAgent.ReadFromMemory(sourceAddress.ToUShort());
            ProcessorAgent.WriteToMemory(destAddress.ToUShort(), value);

            Registers.HL = sourceAddress.Inc();
            Registers.DE = destAddress.Inc();
            counter = counter.Dec();
            Registers.BC = counter;

            Registers.HF = 0;
            Registers.NF = 0;
            Registers.PF = (counter != 0);

            var valuePlusA = value.Add(Registers.A).GetLowByte();
            Registers.Flag3 = valuePlusA.GetBit(3);
            Registers.Flag5 = valuePlusA.GetBit(1);


	        return 16;
		}

        /// <summary>
        /// The LDD instruction.
        /// </summary>
        byte LDD()
        {
            FetchFinished();

            var sourceAddress = Registers.HL;
            var destAddress = Registers.DE;
            var counter = Registers.BC;
            var value = ProcessorAgent.ReadFromMemory(sourceAddress.ToUShort());
            ProcessorAgent.WriteToMemory(destAddress.ToUShort(), value);

            Registers.HL = sourceAddress.Dec();
            Registers.DE = destAddress.Dec();
            counter = counter.Dec();
            Registers.BC = counter;

            Registers.HF = 0;
            Registers.NF = 0;
            Registers.PF = (counter != 0);

            var valuePlusA = value.Add(Registers.A).GetLowByte();
            Registers.Flag3 = valuePlusA.GetBit(3);
            Registers.Flag5 = valuePlusA.GetBit(1);


	        return 16;
		}

        /// <summary>
        /// The LDIR instruction.
        /// </summary>
        byte LDIR()
        {
            FetchFinished();

            var sourceAddress = Registers.HL;
            var destAddress = Registers.DE;
            var counter = Registers.BC;
            var value = ProcessorAgent.ReadFromMemory(sourceAddress.ToUShort());
            ProcessorAgent.WriteToMemory(destAddress.ToUShort(), value);

            Registers.HL = sourceAddress.Inc();
            Registers.DE = destAddress.Inc();
            counter = counter.Dec();
            Registers.BC = counter;

            Registers.HF = 0;
            Registers.NF = 0;
            Registers.PF = (counter != 0);

            var valuePlusA = value.Add(Registers.A).GetLowByte();
            Registers.Flag3 = valuePlusA.GetBit(3);
            Registers.Flag5 = valuePlusA.GetBit(1);

			if(counter != 0) {
				Registers.PC = Registers.PC.Sub(2);
				return 21;
			}

	        return 16;
		}

        /// <summary>
        /// The LDDR instruction.
        /// </summary>
        byte LDDR()
        {
            FetchFinished();

            var sourceAddress = Registers.HL;
            var destAddress = Registers.DE;
            var counter = Registers.BC;
            var value = ProcessorAgent.ReadFromMemory(sourceAddress.ToUShort());
            ProcessorAgent.WriteToMemory(destAddress.ToUShort(), value);

            Registers.HL = sourceAddress.Dec();
            Registers.DE = destAddress.Dec();
            counter = counter.Dec();
            Registers.BC = counter;

            Registers.HF = 0;
            Registers.NF = 0;
            Registers.PF = (counter != 0);

            var valuePlusA = value.Add(Registers.A).GetLowByte();
            Registers.Flag3 = valuePlusA.GetBit(3);
            Registers.Flag5 = valuePlusA.GetBit(1);

			if(counter != 0) {
				Registers.PC = Registers.PC.Sub(2);
				return 21;
			}

	        return 16;
		}

	}
}