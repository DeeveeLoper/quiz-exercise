class Program 
{
    static void Main() 
    {
        // ==== TEST ====
        //Håller reda på poängen
        int totalScore = 0;

        TextQuestion question = new TextQuestion("Vad heter Sveriges andra största stad?", 1000, "Göteborg");

        Console.WriteLine(question.GetQuestion());

        Console.Write("\nDitt svar:");
        string userAnswer = Console.ReadLine();

        if (question.CheckAnswer(userAnswer))
        {
            totalScore += question.GetPoints();

            Console.WriteLine("Rätt svar! Vi alla gillar glass.");
            Console.WriteLine($"Du fick {question.GetPoints()} fina poäng!");
            Console.WriteLine($"Total poäng {totalScore}");
        }
        else
        {
            Console.WriteLine("Fel svar. Rimmar på Götteborg.");
            Console.WriteLine($"Du fick 0 poäng");
        }
       
    }
}