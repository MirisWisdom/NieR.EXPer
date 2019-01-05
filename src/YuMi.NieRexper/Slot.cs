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

namespace YuMi.NieRexper
{
    /// <summary>
    ///     Represents a NieR:Automata save slot on the filesystem.
    /// </summary>
    public class Slot
    {
        /// <summary>
        ///     <see cref="Path" />
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        ///     Represent object as string.
        /// </summary>
        /// <param name="slot">
        ///     Object to represent as string.
        /// </param>
        /// <returns>
        ///     String representation of the object.
        /// </returns>
        public static implicit operator string(Slot slot)
        {
            return slot.Path;
        }

        /// <summary>
        ///     Represent string as object.
        /// </summary>
        /// <param name="path">
        ///     String to represent as object.
        /// </param>
        /// <returns>
        ///     Object representation of the string.
        /// </returns>
        public static explicit operator Slot(string path)
        {
            return new Slot
            {
                Path = path
            };
        }
    }
}