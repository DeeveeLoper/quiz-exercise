class Program 
{
    static void Main()
    {

       
        // === Testar klassen QuizAdmin ===
        QuizAdmin adminCreateQuiz = new QuizAdmin();

        Console.WriteLine("Skapa olika frågor: ");

        // Skapa textfråga
        adminCreateQuiz.CreateTextQuestion("Vilken stad är Sveriges näst största stad?", 1000, "Göteborg");

        // Skapa en 1 X 2 fråga
        adminCreateQuiz.CreateOneXTwoQuestion("Vad heter Sveriges huvudstad?", 500, "1");

        // Visa alla frågor
        Console.WriteLine("Visa alla frågor: ");
        List<Question> allQuestions = adminCreateQuiz.GetQuestions();
        for (int i = 0; i < allQuestions.Count; i++) 
        {
            Console.WriteLine($"Fråga {i + 1}: {allQuestions[i].GetQuestion()}");
        }

        // Ta bort en fråga 
        Console.WriteLine("Ta bort fråga");
        if (adminCreateQuiz.RemoveQuestion(0)) 
        {
            Console.WriteLine("Frågan togs bort");
        }

        // Visa återstående frågor
        Console.WriteLine("Återstående frågor");
        allQuestions = adminCreateQuiz.GetQuestions();
        
        for (int i = 0; i < allQuestions.Count; i++) 
        {
            Console.WriteLine($"Fråga {i + 1}: {allQuestions[i].GetQuestion()}");
        }



        /*
        // === Testar klassen OneXTwoQuestion ===
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
        Console.WriteLine($"Korrekt svar: {validAnswer}");
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
        */

    }
}