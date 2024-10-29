// klassen ärver egenskaper och metoder från huvudklassen Question
public class OneXTwoQuestion : Question
{
    // Inkapsling
    private string correctAnswer { get; set; }

    public OneXTwoQuestion(string text, int points, string answer) : base(text, points)

    {
        if (!new[] { "1", "X", "2" }.Contains(answer.ToLower()))
        {
            // Om värdet som skickas till en metod är ogiltigt används ArgumentException.
            throw new ArgumentException("Svaret måsta vara 1, X eller 2");
        }
        correctAnswer = answer.ToLower();
    }


    public override bool CheckAnswer(string answer)
    {
        if (!new[] { "1", "X", "2" }.Contains(answer.ToLower()))
        {
            return false;
        }
        return answer.ToLower() == correctAnswer;
    }
}