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

using RxuiMultiRouterSample.ViewModels;
namespace RxuiMultiRouterSample.Views
{
    /// <summary>
    /// AScreen.xaml 的交互逻辑
    /// </summary>
    public partial class AScreen : ReactiveUserControl<AScreenViewModel>
    {
        public AScreen()
        {
            InitializeComponent();
            ViewModel ??= new AScreenViewModel();
            this.WhenActivated(d =>
            {
                this.WhenAnyValue(x => x.ViewModel).BindTo(this, x => x.DataContext).DisposeWith(d);

            });

        }
    }
}
