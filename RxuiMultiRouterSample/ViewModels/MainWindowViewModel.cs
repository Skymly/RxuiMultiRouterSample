using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ReactiveUI.Wpf;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Reactive.Threading.Tasks;
using System.Reactive.Threading;
using Splat;
namespace RxuiMultiRouterSample.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        public MainWindowViewModel()
        {
            var canNavigate = this.WhenAnyValue(x => x.SelectedScreen, x => x.SelectedView, (s, v) => !string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(v));
            NavigateCommand = ReactiveCommand.Create(OnNavigate, canNavigate);
            Views = new() { "ViewA", "ViewB", "ViewC", "ViewD" };
            Screens = new() { ScreenNames.Screen1, ScreenNames.Screen2 };

        }

        public ReactiveCommand<Unit, Unit> NavigateCommand { get; }

        private void OnNavigate()
        {
            var screen = Locator.Current.GetService<IScreen>(SelectedScreen);
            IRoutableViewModel vm = SelectedView switch
            {
                "ViewA" => new AViewModel(),
                "ViewB" => new BViewModel(),
                "ViewC" => new CViewModel(),
                "ViewD" => new DViewModel(),
                _ => throw new ArgumentException("无效的参数"),
            };
            screen.Router.NavigateAndReset.Execute(vm);
        }

        [Reactive] public string SelectedView { get; set; }
        public List<string> Views { get; set; }
        [Reactive] public string SelectedScreen { get; set; }
        public List<string> Screens { get; set; }

    }
}
