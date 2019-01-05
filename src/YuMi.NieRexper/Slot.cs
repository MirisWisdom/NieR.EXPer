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