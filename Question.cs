// Detta är huvudklassen (Parent) som alla frågor ärver ifrån.
public abstract class Question
{
    //Automatiskt implemnterade egenskaper som bara kan användas inom denna klass
    private string questionText { get; set; } // frågetexter
    private int points { get;  set; } // poäng
    private bool isAnswered { get; set; } // status på svar

    public Question(string text, int points) 
    {
       this.questionText = text;
       this.points = points;
       this.isAnswered = false; // sätter att ny fråga inte är besvarad
    }
    // Hämtar frågetexten
    public string GetQuestion() 
    {
        return questionText; 
    }
    // Hämtar poäng
    public int GetPoints() 
    {
        return points; 
    }
    // Markerar frågan som besvarad
    public void MarkAsAnswered() 
    {
        isAnswered = true; 
    }
    // Kollar om frågan är besvarad
    public bool IsAnswered() 
    {
        return isAnswered;
    }
    // Abstrakt metod som kontrollerar svar. Den implemnteras i alla klasser som ärver från klassen Question.
    public abstract bool CheckAnswer(string answer);
}
