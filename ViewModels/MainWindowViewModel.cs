using Avalonia;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Windows.Input;


namespace avalonia_learning.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";


        public ICommand BuyMusicCommand { get; }


        public MainWindowViewModel()
        {
            BuyMusicCommand = ReactiveCommand.Create(() => { });
        }
    }
}