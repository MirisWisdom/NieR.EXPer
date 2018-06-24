using System;
using System.IO;
using YuMi.NieRexper.Apply.Common;

namespace YuMi.NieRexper.Apply
{
    /// <summary>
    /// EXP patcher for NieR:Automata save slots.
    /// </summary>
    public class SlotPatch : IPatch
    {
        /// <summary>
        /// Offset in the save binary where the EXP value is stored.
        /// </summary>
        int Address {
            get { return 0x3871C; }
        }

        /// <summary>
        /// Path of the NieR:Automata save slot to patch.
        /// </summary>
        string SlotPath { get; }

        /// <summary>
        /// SlotPatch constructor.
        /// </summary>
        /// <param name="slotPath">Path of the NieR:Automata save slot to patch.</param>
        public SlotPatch(string slotPath)
        {
            SlotPath = slotPath;
        }

        /// <summary>
        /// Patches the specified EXP amount to the provided save slot.
        /// </summary>
        /// <param name="amount">Amount of EXP to apply to the object.</param>
        /// <returns>PatchResult instance representing the outcome of the patching procedure.</returns>
        public PatchResult Patch(int amount)
        {
            try
            {
                using (var writer = new BinaryWriter(File.OpenWrite(SlotPath)))
                {
                    var value = BitConverter.GetBytes(amount);
                    writer.BaseStream.Seek(Address, SeekOrigin.Begin);
                    writer.Write(value, 0, value.Length);

                    return new PatchResult(PatchStatus.Success);
                }
            }
            catch (Exception e)
            {
                return new PatchResult(PatchStatus.Exception, e.Message);
            }
        }
    }
}
