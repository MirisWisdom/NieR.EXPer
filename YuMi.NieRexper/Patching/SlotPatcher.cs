using System;
using System.IO;

namespace YuMi.NieRexper.Patching
{
    /// <summary>
    /// EXP patcher for NieR:Automata save slots.
    /// </summary>
    public class SlotPatcher : IPatcher
    {
        /// <summary>
        /// Offset in the save binary where the EXP value is stored.
        /// </summary>
        private int Address {
            get { return 0x3871C; }
        }

        /// <summary>
        /// Path of the NieR:Automata save slot to patch.
        /// </summary>
        private string SlotPath { get; }

        /// <summary>
        /// SlotPatcher constructor.
        /// </summary>
        /// <param name="slotPath">Path of the NieR:Automata save slot to patch.</param>
        public SlotPatcher(string slotPath)
        {
            SlotPath = slotPath;
        }

        /// <summary>
        /// Patches the specified EXP amount to the provided save slot.
        /// </summary>
        /// <param name="amount">Amount of EXP to apply to the object.</param>
        public void Patch(int amount)
        {
            using (var writer = new BinaryWriter(File.OpenWrite(SlotPath)))
            {
                var value = BitConverter.GetBytes(amount);
                writer.BaseStream.Seek(Address, SeekOrigin.Begin);
                writer.Write(value, 0, value.Length);
            }
        }
    }
}
