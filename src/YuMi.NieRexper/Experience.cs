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
    ///     Represents a NieR:Automata experience points (EXP).
    /// </summary>
    public class Experience
    {
        /// <summary>
        ///     NieR:Automata EXP value.
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        ///     Represent object as integer.
        /// </summary>
        /// <param name="experience">
        ///     Object to represent as integer.
        /// </param>
        /// <returns>
        ///     Integer representation of the object.
        /// </returns>
        public static implicit operator int(Experience experience)
        {
            return experience.Points;
        }

        /// <summary>
        ///     Represent integer as object.
        /// </summary>
        /// <param name="points">
        ///     Integer to represent as object.
        /// </param>
        /// <returns>
        ///     Object representation of the integer.
        /// </returns>
        public static explicit operator Experience(int points)
        {
            return new Experience
            {
                Points = points
            };
        }
    }
}