using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;
using AvaloniaApplication1.Models;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string input = "";
        bool isDisplayingResult = false;
        public MainWindowViewModel()
        {
            ChangeInput = ReactiveCommand.Create((string x) => {
                if(isDisplayingResult)
                {
                    Input = "";
                }
                isDisplayingResult = false;
                return Input += x;
                }
            );
            Calculate = ReactiveCommand.Create(() => {
                try
                {
                    isDisplayingResult = true;
                    return Input = RomanNumberCalculator.Calculate(input).ToString();
                }
                catch (Exception ex)
                {
                    return Input = "Ошибка";
                }
            });
        }
        public string Input
        {
            set
            {
                this.RaiseAndSetIfChanged(ref input, value);
            }
            get
            {
                return this.input;
            }
        }
        public ReactiveCommand<string, string> ChangeInput { get; }
        public ReactiveCommand<Unit, string> Calculate { get; }
    }
}
