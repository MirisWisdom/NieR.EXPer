namespace YuMi.NieRexper
{
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