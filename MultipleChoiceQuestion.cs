using System.Collections.Generic;
// klassen �rver egenskaper och metoder fr�n huvudklassen Question

public class MultipleChoiceQuestion : Question
{
    private List<string> options { get; set; } // Lista med svaralternativ
    private int correctOption { get; set; }

    public MultipleChoiceQuestion(string text, int points, List<string> optionList, int correct)
        : base(text, points)
    {
        this.options = optionList;
        this.correctOption = correct;
    }

    public override bool CheckAnswer(string answer) 
    {
        // konverterar string till int
        if (int.TryParse(answer, out int choseOption)) 
        {
            // j�mf�r om det �r samma heltal
            return choseOption == correctOption;
        }
        return false;
    }
}
