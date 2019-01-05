namespace YuMi.NieRexper.Patching
{
    /// <summary>
    /// Interface to be implemented by NieR:Automata EXP patchers.
    /// </summary>
    public interface IPatcher
    {
        /// <summary>
        /// Patch experience points to a resource.
        /// </summary>
        /// <param name="amount">Amount of EXP to patch to the resource.</param>
        void Patch(int amount);
    }
}
