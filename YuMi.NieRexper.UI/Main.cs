using System;
using YuMi.NieRexper.Apply;
using YuMi.NieRexper.Apply.Common;
using YuMi.NieRexper.UI.Common;

namespace YuMi.NieRexper.UI
{
    /// <summary>
    /// Model that implements the ILevelApply interface and exposes integer values for various NieR:Automata levels.
    /// </summary>
    public class Main : ILevelApply
    {
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
            var slotPatch = new SlotPatch(path);
            var result = slotPatch.Patch(amount);

            switch (result.Status)
            {
                case PatchStatus.Success:
                    return new LevelApplyResult(LevelApplyStatus.Success);
                case PatchStatus.Exception:
                    return new LevelApplyResult(LevelApplyStatus.Exception, result.Data);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
