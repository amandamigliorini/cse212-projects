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

        // assigning a array to receive the results
        double[] multiples = new double[length];
        // a loop for that will run the number of times indicated by length once this is
        // how many multiples we'll need to return
        for (int i = 1; i <= length; i++){
            //add the multiple number to the array. Because the index should start in 0
            //and the for starts in 1 I am using i - 1 for the index
            multiples[i-1] = number * i;
        }

        //return the array
        return multiples; // replace this return statement with your own
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
        
        //start a new list to have the items to be in the beggining of the list
        var endList = new List<int>();
        // determine the starting index of the rotation
        int i = data.Count - amount;

        // loop for will add all the right elements to the endList and remove it from data
        for (int j = i; j < i + amount; j++){
            endList.Add(data[i]);
            data.RemoveAt(i);
        }
        //add the endList to data starting on index 0 and completing the rotation
        data.InsertRange(0, endList);

    }
}
