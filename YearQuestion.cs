// klassen �rver egenskaper och metoder fr�n huvudklassen Question
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
            return giveYear == correctYear; // kollar att anv�ndarens svar samma som r�tta svaret 
        }
        return false;
    }
}