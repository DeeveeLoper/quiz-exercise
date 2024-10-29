class Program 
{
    static void Main()
    {
        TestOneXTwoQuestion();
        Console.WriteLine("Tryck på något för att avsluta!");
        Console.ReadKey();
    }

    static void TestOneXTwoQuestion() 
    {
        var question = new OneXTwoQuestion("Vad heter planeten närmast solen?", 100, "1"); //Merkurius

        bool validAnswer = question.CheckAnswer("1");
        bool invalidAnswer1 = question.CheckAnswer("2");
        bool invalidAnswer2 = question.CheckAnswer("X");

        Console.WriteLine("Testar OneXTwoQuestion:");
        Console.WriteLine($"Korrekt svar {validAnswer}");
        Console.WriteLine($"Fel svar 1:{invalidAnswer1}");
        Console.WriteLine($"Fel svar 2: {invalidAnswer2}");

        try
        {
            var invalidQuestion = new OneXTwoQuestion("Vad heter planeten närmast solen?", 100, "1");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Kastar förväntad exception: {e.Message}");
        }
    }
}