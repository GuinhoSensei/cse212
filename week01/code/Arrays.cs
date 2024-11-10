public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
               // Step 1: Create an array of size 'length' to hold the result.
        double[] multiples = new double[length];

        // Step 2: Loop through each position in the array.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple by multiplying the number by (i + 1).
            multiples[i] = number * (i + 1);
        }

        // Step 4: Return the filled array.
        return multiples;
    }
    

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        {
        // Step 1: Ensure the 'amount' is within the range by using modulus.
        amount %= data.Count;

        // Step 2: Extract the part of the list that needs to be moved to the front.
        List<int> rotatedPart = data.GetRange(data.Count - amount, amount);

        // Step 3: Remove the elements that were extracted from the original list.
        data.RemoveRange(data.Count - amount, amount);

        // Step 4: Insert the extracted elements at the beginning of the list.
        data.InsertRange(0, rotatedPart);
    }
    }
}
