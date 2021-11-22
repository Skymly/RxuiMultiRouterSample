using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using ReactiveUI;
using ReactiveUI.Wpf;

using RxuiMultiRouterSample.ViewModels;

namespace RxuiMultiRouterSample.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel ??= new MainWindowViewModel();
            this.WhenActivated(d =>
            {
                this.WhenAnyValue(x => x.ViewModel).WhereNotNull().BindTo(this, x => x.DataContext).DisposeWith(d);
                this.BindCommand(ViewModel, vm => vm.NavigateCommand, v => v.btn1).DisposeWith(d);
            });
        }
    }
}
