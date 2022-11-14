using Avalonia;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using avalonia_learning.Views;


namespace avalonia_learning.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";


        public ICommand BuyMusicCommand { get; }


        public MainWindowViewModel()
        {
            // BuyMusicCommand = ReactiveCommand.Create(() => { });
            
            ShowDialog = new Interaction<MusicStoreViewModel, AlbumViewModel?>();

            BuyMusicCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                var store = new MusicStoreViewModel();

                var result = await ShowDialog.Handle(store);
            });
        }

        public Interaction<MusicStoreViewModel, AlbumViewModel?> ShowDialog { get; }

        
    }
}