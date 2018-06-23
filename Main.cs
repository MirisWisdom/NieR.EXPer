using System;
using System.IO;

namespace YuMi.NieRexper
{
    /// <summary>
    /// Model that implements the ILevelApply interface and exposes integer values for various NieR:Automata levels.
    /// </summary>
    public class Main : ILevelApply
    {
        /// <summary>
        /// Offset in the save binary where the EXP value is stored.
        /// </summary>
        int Address {
            get { return 0x3871C; }
        }

        /// <summary>
        /// EXP required to reach level 10.
        /// </summary>
        public static int Level10 {
            get { return 0x00C70; }
        }

        /// <summary>
        /// EXP required to reach level 25.
        /// </summary>
        public static int Level25 {
            get { return 0x086BD; }
        }

        /// <summary>
        /// EXP required to reach level 50.
        /// </summary>
        public static int Level50 {
            get { return 0x330E7; }
        }

        /// <summary>
        /// EXP required to reach level 75.
        /// </summary>
        public static int Level75 {
            get { return 0x92847; }
        }

        /// <summary>
        /// Apply experience points to the specified save file.
        /// </summary>
        /// <param name="amount">Amount of EXP.</param>
        /// <param name="path">Save file location.</param>
        /// <returns>Result object representing the outcome of the patch procedure.</returns>
        public LevelApplyResult Apply(int amount, string path)
        {
            try
            {
                using (var writer = new BinaryWriter(File.OpenWrite(path)))
                {
                    var value = BitConverter.GetBytes(amount);
                    writer.BaseStream.Seek(Address, SeekOrigin.Begin);
                    writer.Write(value, 0, value.Length);

                    return new LevelApplyResult(LevelApplyStatus.Success);
                }
            }
            catch (Exception e)
            {
                return new LevelApplyResult(LevelApplyStatus.Exception, e.Message);
            }
        }
    }
}
