// klassen Textfråga ärver egenskaper och metoder från huvudklassen Question
public class TextQuestion : Question 
{
    private string correctAnswer { get; set; }

    public TextQuestion(string text, int points, string answer)
        : base(text, points)// Skickar text och poäng till huvudklassens (Question) konstrukor
    {
        correctAnswer = answer; // det rätta svaret
    }

    //Metod som kontrollerar om svaret är rätt. 
    public override bool CheckAnswer(string answer)
    {
        return answer.ToLower() == correctAnswer.ToLower(); // Gör om båda textsträngarna till små bokstäver och jämför
        //return string.Equals(answer, correctAnswer, StringComparison.OrdinalIgnoreCase); //Jämför textsträngarna och ignorerar skillnad på stora/små bokstäver
    }
}
