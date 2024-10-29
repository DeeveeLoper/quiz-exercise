using System.Collections.Generic;

// Anv�ndare som �r administrat�r och kan skapa och ta bort fr�gor
class QuizAdmin
{
    // En privat lista med fr�gor
    private List<Question> questions = new List<Question>();

    // Publika metoder som skapar olika typer av fr�gor att l�gga till listan
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

    public void CreateRatingQuestion(string text, int points, int rating) 
    {
        questions.Add(new RatingQuestion(text, points, rating));
    }

    public void CreateYearQuestion(string text, int points, int correctYear) 
    {
        questions.Add(new YearQuestion(text, points, correctYear));
    }

    // H�mtar alla fr�gor
    public List<Question> GetQuestions() 
    {
        return new List<Question>(questions);
    }

    // Tar bort fr�ga fr�n listan p� angiven index
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