using System.Collections.Generic;
// klassen ärver egenskaper och metoder från huvudklassen Question

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
            // jämför om det är samma heltal
            return choseOption == correctOption;
        }
        return false;
    }
}
