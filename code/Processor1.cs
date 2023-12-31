namespace code;
public class Processor1
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
            List<long> tempTailList = [];
            // when all of the numbers in tempSequence are 0, stop the while loop
            while (!tempSequence.All(x => x == 0))
            {
                //get the next level of sequence numbers
                tempSequence = GetNextSequence(tempSequence, tempTailList);

            }

            // get the sum of the tail list
            sum = sum + tempTailList.Sum();
        }
        return sum;
    }
    public static long[] GetNextSequence(long[] sequence, List<long> tempTailList)
    {
        tempTailList.Add(sequence[sequence.Length - 1]);

        long[] nextSequence = new long[sequence.Length - 1];
        for (int i = 0; i < sequence.Length - 1; i++)
        {
            nextSequence[i] = sequence[i + 1] - sequence[i];
        }
        return nextSequence;
    }

}
