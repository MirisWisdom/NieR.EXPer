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
    ///     Represents a NieR:Automata save slot on the filesystem.
    /// </summary>
    public class Slot
    {
        /// <summary>
        ///     Numeric identifier of the slot.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Path of the Slot on the filesystem.
        /// </summary>
        public string Path
        {
            get
            {
                var personal = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                return System.IO.Path.Combine(personal, "My Games", "NieR_Automata", $"SlotData_{Id}.dat");
            }
        }

        /// <summary>
        ///     Represent object as integer.
        /// </summary>
        /// <param name="slot">
        ///     Object to represent as integer.
        /// </param>
        /// <returns>
        ///     Integer representation of the object.
        /// </returns>
        public static implicit operator int(Slot slot)
        {
            return slot.Id;
        }

        /// <summary>
        ///     Represent integer as object.
        /// </summary>
        /// <param name="id">
        ///     Integer to represent as object.
        /// </param>
        /// <returns>
        ///     Object representation of the integer.
        /// </returns>
        public static explicit operator Slot(int id)
        {
            return new Slot
            {
                Id = id
            };
        }
    }
}