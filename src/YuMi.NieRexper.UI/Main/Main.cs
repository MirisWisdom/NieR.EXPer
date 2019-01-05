using System;
using System.IO;
using YuMi.NieRexper.Calculation;
using YuMi.NieRexper.Patching;

namespace YuMi.NieRexper.UI.Main
{
    /// <summary>
    /// Model that implements the ILevelApply interface and exposes integer values for various NieR:Automata levels.
    /// </summary>
    public class Main
    {
        /// <summary>
        /// EXP required to reach level 10.
        /// </summary>
        public static int Level10 {
            get {
                return new ExpCalculator().Calculate(10);
            }
        }

        /// <summary>
        /// EXP required to reach level 25.
        /// </summary>
        public static int Level25 {
            get {
                return new ExpCalculator().Calculate(25);
            }
        }

        /// <summary>
        /// EXP required to reach level 50.
        /// </summary>
        public static int Level50 {
            get {
                return new ExpCalculator().Calculate(50);
            }
        }

        /// <summary>
        /// EXP required to reach level 75.
        /// </summary>
        public static int Level75 {
            get {
                return new ExpCalculator().Calculate(75);
            }
        }

        /// <summary>
        /// Apply experience points to the specified save file.
        /// </summary>
        /// <param name="amount">Amount of EXP.</param>
        /// <param name="slotName">Save file location.</param>
        public void PatchSlot(string slotName, int amount)
        {
            File.Copy(slotName, GetUniqueSlotName(slotName), true);
            new SlotPatcher(slotName).Patch(amount);
        }

        /// <summary>
        /// Returns the inbound save slot's file name with an unique string padded into it.
        /// </summary>
        /// <param name="fileName">Absolute slotName, e.g. C:\SlotData_0.dat</param>
        /// <returns>Unique..ified... save slot file name, e.g. C:\SlotData_0_5d8fe167.dat</returns>
        private string GetUniqueSlotName(string fileName)
        {
            var fileNameNoExtension = fileName.Substring(0, fileName.Length - 4);
            var guidWithFirst8Chars = Guid.NewGuid().ToString().Substring(0, 8);
            return $"{fileNameNoExtension}-{guidWithFirst8Chars}.dat";
        }
    }
}
