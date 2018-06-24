namespace YuMi.NieRexper.Calculate
{
    /// <summary>
    /// Interface to be implemented by types which deal with calculating return values based on the inbound values.
    /// </summary>
    public interface ICalculate
    {
        /// <summary>
        /// Calculate the return value based on the given value.
        /// </summary>
        /// <param name="value">Value to used for the calculation.</param>
        /// <returns>Calculated value.</returns>
        int Calculate(int value);
    }
}
