using System;
using System.IO;

namespace YuMi.NieRexper
{
    public class Main : ILevelApply
    {
        int Address {
            get { return 0x3871C; }
        }

        public static int Level10 {
            get { return 0x00C70; }
        }

        public static int Level25 {
            get { return 0x086BD; }
        }

        public static int Level50 {
            get { return 0x330E7; }
        }

        public static int Level75 {
            get { return 0x92847; }
        }

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
