using System.Collections.Generic;

class QuizAdmin
{
    // En privat lista med frågor
    private List<Question> questions = new List<Question>();

    // Publika metoder som skapar olika typer av frågor att lägga till listan
    public void CreateTextQuestion(string text, int points, string correctAnswer) 
    {
        questions.Add(new TextQuestion(text, points, correctAnswer));
    }

    public void CreateOneXTwoQuestion(string text, int points, string correctAnswer) 
    {
        questions.Add(new OneXTwoQuestion(text, points, correctAnswer));
    }

    public void CreateMultipleChoiceQuestion(string text, int points, List<string> options, int correctOption) 
    {
        questions.Add(new MultipleChoiceQuestion(text, points, options, correctOption));
    }

    public void CreateRatingQuestion(string text, int points, int correctRating, int tolerance) 
    {
        questions.Add(new RatingQuestion(text, points, correctRating, tolerance));
    }

    public void CreateYearQuestion(string text, int points, int correctYear, int tolerance) 
    {
        questions.Add(new YearQuestion(text, points, correctYear, tolerance));
    }

    // Hämtar alla frågor
    public List<Question> GetQuestions() 
    {
        return new List<Question>(questions);
    }

    // Tar bort fråga från listan på angiven index
    public bool RemoveQuestion(int index) 
    {
        if (index >= 0 && index < questions.Count) 
        {
            questions.RemoveAt(index);
            return true;
        }
        return false;
    }
}