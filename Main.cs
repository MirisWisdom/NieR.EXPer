using System;
using System.IO;

namespace YuMi.NieRexper
{
    public class Main : ILevelApply
    {
        int Address {
            get { return 0x0003871C; }
        }

        public static UInt32 Level10 {
            get { return 0x00C70; }
        }

        public static UInt32 Level25 {
            get { return 0x086BD; }
        }

        public static UInt32 Level50 {
            get { return 0x330E7; }
        }

        public static UInt32 Level75 {
            get { return 0x92847; }
        }

        public LevelApplyResult Apply(UInt32 amount, String path)
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
