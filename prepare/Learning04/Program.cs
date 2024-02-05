class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Deana", "Algebra");
        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine();

        MathAssignment myMath = new MathAssignment("Deana", "Fractions", "7.3", "8-19");
        Console.WriteLine(myMath.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment myWriting = new WritingAssignment("Deana", "History", "Causes of War");
        Console.WriteLine(myWriting.GetWritingInformation());
        Console.WriteLine();
    }
}