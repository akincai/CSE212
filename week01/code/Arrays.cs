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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Initialize an empty double[] array of length: {length}
        // Create a for loop with {length} iterations starting at 0
        // Set array index [i] = ({number} * {i+1}) (i is the index of the for loop) for each iteration
        // Return the array

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i+1);
        }
        
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // If a list is rotated to the right by {amount}, you're essentially taking a slice of size {amount}
        //  off the end and moving it to the front of the list
        // If the amount is as big or greater than the size of the list, it can be said that the remainder
        //  is how much the list would be rotated by
        // List of size 10 rotated right by 2 would use a Range of (8,2) or (size-amount, amount)
        // Insertion does not affect removing the end of the list, so getting and insertion can be done
        //  before removing the end
        
        // Post submission edit: added line of code to adjust value of amount to be less than data.Count

        amount = amount % data.Count;
        data.InsertRange(0, data.GetRange(data.Count-amount, amount));
        data.RemoveRange(data.Count-amount, amount);
    }
}
