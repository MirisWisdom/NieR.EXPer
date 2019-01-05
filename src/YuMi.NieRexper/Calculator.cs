/**
 * Copyright (C) 2018-2019 Emilian Roman
 * 
 * This file is part of NieR.EXPer.
 * 
 * NieR.EXPer is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * NieR.EXPer is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with NieR.EXPer.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;

namespace YuMi.NieRexper
{
    /// <summary>
    ///     Handles the calculation of EXP points for a specified NieR:Automata level.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        ///     Array of EXPs that correspond to levels 1-99.
        /// </summary>
        private static readonly int[] Values =
        {
            0x000000, 0x000030, 0x00008B, 0x000126, 0x00020D, 0x00034B, 0x0004EB, 0x0006F6, 0x000975, 0x000C70,
            0x000FF0, 0x0013FC, 0x00189C, 0x001DD6, 0x0023B3, 0x002A39, 0x00316E, 0x00395A, 0x004202, 0x004B6D,
            0x0055A0, 0x0060A3, 0x006C7A, 0x00792B, 0x0086BD, 0x009534, 0x00A496, 0x00B4E8, 0x00C630, 0x00D874,
            0x00EBB7, 0x010000, 0x011552, 0x012BB4, 0x01432A, 0x015BB9, 0x017566, 0x019035, 0x01AC2B, 0x01C94E,
            0x01E7A0, 0x020728, 0x0227E8, 0x0249E7, 0x026D28, 0x0291B0, 0x02B783, 0x02DEA4, 0x03071A, 0x0330E7,
            0x035C11, 0x03889A, 0x03B688, 0x03E5DE, 0x0416A1, 0x0448D4, 0x047C7B, 0x04B19B, 0x04E837, 0x052054,
            0x0559F5, 0x05951E, 0x05D1D3, 0x061018, 0x064FF0, 0x06915F, 0x06D46A, 0x071913, 0x075F5F, 0x07A751,
            0x07F0ED, 0x083C36, 0x088930, 0x08D7E0, 0x092847, 0x097A6A, 0x09CE4D, 0x0A23F2, 0x0A7B5E, 0x0AD494,
            0x0B2F97, 0x0B8C6B, 0x0BEB13, 0x0C4B93, 0x0CADEE, 0x0D1227, 0x0D7842, 0x0DE043, 0x0E4A2B, 0x0EB600,
            0x0F23C4, 0x0F937A, 0x100526, 0x1078CB, 0x10EE6C, 0x11660D, 0x11DFB0, 0x125B59, 0x12D90B
        };

        /// <summary>
        ///     Returns the number of EXP points required for the level provided as an argument.
        /// </summary>
        /// <param name="level">
        ///    The level to get the required EXP value for.
        /// </param>
        /// <returns>
        ///    The EXP required for the provided level.
        /// </returns>
        public int Calculate(Level level)
        {
            return Values[level - 1];
        }
    }
}