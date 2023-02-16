namespace JJ.Demos.Architecture.Presentation.Presenters;

public class QuizPresenter
{
    public QuizViewModel Answer(QuizViewModel userInput)
    {
        var viewModel = new QuizViewModel
        {
            // Yield over non-persisted properties.
            SelectedOption = userInput.SelectedOption,
            AnswerVisible = userInput.AnswerVisible
        };

        return viewModel;
    }
}
