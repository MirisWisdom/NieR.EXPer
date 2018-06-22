using System;

namespace YuMi.NieRexper
{
    public interface ILevelApply
    {
        LevelApplyResult Apply(UInt32 amount, String path);
    }
}
