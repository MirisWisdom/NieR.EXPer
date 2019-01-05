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
    ///     NieR:Automata progress level.
    /// </summary>
    public class Level
    {
        /// <summary>
        ///     <see cref="Level" />
        /// </summary>
        private int _value;

        /// <summary>
        ///     NieR:Automata level value.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Value is below 1 or above 99.
        /// </exception>
        public int Value
        {
            get => _value;
            set
            {
                if (value < 1 || value > 99)
                    throw new ArgumentOutOfRangeException(nameof(value), "Level is out of range.");

                _value = value;
            }
        }

        /// <summary>
        ///     Represent object as integer.
        /// </summary>
        /// <param name="level">
        ///     Object to represent as integer.
        /// </param>
        /// <returns>
        ///     Integer representation of the object.
        /// </returns>
        public static implicit operator int(Level level)
        {
            return level.Value;
        }

        /// <summary>
        ///     Represent integer as object.
        /// </summary>
        /// <param name="level">
        ///     Integer to represent as object.
        /// </param>
        /// <returns>
        ///     Object representation of the integer.
        /// </returns>
        public static explicit operator Level(int level)
        {
            return new Level
            {
                Value = level
            };
        }
    }
}