﻿namespace JJ.Demos.Architecture.Presentation.Presenters;

public class QuizPresenter
{
    public QuizViewModel Answer(QuizViewModel userInput)
    {
        var viewModel = new QuizViewModel();
        viewModel.SelectedOption = userInput.SelectedOption;
        viewModel.AnswerVisible = userInput.AnswerVisible;
        return viewModel;
    }
}
