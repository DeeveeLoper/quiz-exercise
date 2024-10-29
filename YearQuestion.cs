// klassen ärver egenskaper och metoder från huvudklassen Question
public class YearQuestion : Question
{
    private int correctYear { get; set; }

    public YearQuestion(string text, int points, int year)
        : base(text, points) 
    {
        correctYear = year;
    }

    public override bool CheckAnswer(string answer) 
    {
        if (int.TryParse(answer, out int giveYear)) 
        {
            return giveYear == correctYear; // kollar att användarens svar samma som rätta svaret 
        }
        return false;
    }
}