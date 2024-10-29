// klassen ärver egenskaper och metoder från huvudklassen Question
using System;

public class RatingQuestion : Question 
{
    private int correctRating { get; set; } // Rätt Svar

    public RatingQuestion(string text, int points, int rating)
        : base(text, points)
    {
        if (rating < 1 || rating > 10) 
        {
            throw new ArgumentException("Måste vara mellan 1-10!")
        }
        correctRating = rating;
    }

    public override bool CheckAnswer(string answer) 
    {
        if (int.TryParse(answer, out int givenRating)) 
        {
            return givenRating == correctRating; // kollar att användarens svar samma som rätta svaret 
        }
        return false;
    }
}