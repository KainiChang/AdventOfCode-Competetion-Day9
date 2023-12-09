namespace code;
public class Processor2
{
    public static long Process(string[] inputRows)
    {
        long sum = 0;

        foreach (var inputRow in inputRows)
        {
            // Parse the input
            long[] section = inputRow.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            long[] tempSequence = section;

            // dynamic programming
            List<long> tempHeadList = [];
            // when all of the numbers in tempSequence are 0, stop the while loop
            while (!tempSequence.All(x => x == 0))
            {
                //get the next level of sequence numbers
                tempSequence = GetNextSequence(tempSequence, tempHeadList);

            }
            // get the sum of the tail list
            sum = sum + GetPreNumber(tempHeadList);
        }
        return sum;
    }
    public static long[] GetNextSequence(long[] sequence, List<long> tempHeadList)
    {
        tempHeadList.Add(sequence[0]);

        long[] nextSequence = new long[sequence.Length - 1];
        for (int i = 0; i < sequence.Length - 1; i++)
        {
            nextSequence[i] = sequence[i + 1] - sequence[i];
        }
        return nextSequence;
    }
    public static long GetPreNumber(List<long> tempHeadList)
    {
        long preNumber = 0;
        for (int i = tempHeadList.Count - 1; i >= 0; i--)
        {
            preNumber = tempHeadList[i]-preNumber;
        }
        return preNumber;
    }

}
