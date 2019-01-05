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