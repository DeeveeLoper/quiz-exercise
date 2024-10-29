// klassen �rver egenskaper och metoder fr�n huvudklassen Question
using System;

public class RatingQuestion : Question 
{
    private int correctRating { get; set; } // R�tt Svar

    public RatingQuestion(string text, int points, int rating)
        : base(text, points)
    {
        if (rating < 1 || rating > 10) 
        {
            throw new ArgumentException("M�ste vara mellan 1-10!")
        }
        correctRating = rating;
    }

    public override bool CheckAnswer(string answer) 
    {
        if (int.TryParse(answer, out int givenRating)) 
        {
            return givenRating == correctRating; // kollar att anv�ndarens svar samma som r�tta svaret 
        }
        return false;
    }
}