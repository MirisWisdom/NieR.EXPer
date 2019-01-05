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
using System.IO;

namespace YuMi.NieRexper
{
    /// <summary>
    ///     EXP patcher for NieR:Automata save slots.
    /// </summary>
    public class Patcher
    {
        /// <summary>
        ///     SlotPatcher constructor.
        /// </summary>
        /// <param name="slotPath">Path of the NieR:Automata save slot to patch.</param>
        public Patcher(string slotPath)
        {
            SlotPath = slotPath;
        }

        /// <summary>
        ///     Offset in the save binary where the EXP value is stored.
        /// </summary>
        private int Address => 0x3871C;

        /// <summary>
        ///     Path of the NieR:Automata save slot to patch.
        /// </summary>
        private string SlotPath { get; }

        /// <summary>
        ///     Patches the specified EXP amount to the provided save slot.
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