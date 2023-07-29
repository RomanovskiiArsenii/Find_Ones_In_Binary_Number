class Program
{
    /// <summary>
    /// Translation:
    /// A method that converts a number to its string binary representation 
    /// and outputs this representation to the console.
    /// </summary>
    /// <param name="num">number</param>
    static void PseudoBinary(uint num)
    {
        string pseudoBinary = Convert.ToString(num, 2);
        Console.WriteLine(pseudoBinary);
    }
    /// <summary>
    /// A method that finds the total count of the longest sequence 
    /// of ones in the binary representation of a number.
    /// </summary>
    /// <param name="num">number</param>
    /// <returns>count of the longest sequence of one</returns>
    static int FindAllOnesInBinary(uint num)
    {
        int max = 0; int current = 0;

        while (num != 0)
        {
            if ((num & 1) == 1)
            {
                current++;
            }
            else
            {
                max = Math.Max(max, current);
                current = 0;
            }
            num >>= 1;
            Console.Write(">>1 ");
            PseudoBinary(num);
        }
        return Math.Max(max, current);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a decimal number: ");
        if (uint.TryParse(Console.ReadLine().Trim(), out uint num))
        {
            Console.Write($"Binary representation of a number: ");
            PseudoBinary(num);
            Console.WriteLine("Calculation process:");
            Console.WriteLine($"Longest sequence of ones in the binary representation of a number: {FindAllOnesInBinary(num)}");
        }
    }
}