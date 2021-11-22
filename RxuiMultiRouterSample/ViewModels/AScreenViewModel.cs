using ReactiveUI;

using Splat;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RxuiMultiRouterSample.ViewModels
{
    public class AScreenViewModel : ReactiveObject, IScreen
    {
        public AScreenViewModel()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant<IScreen>(this,ScreenNames.Screen1);
        }
        public RoutingState Router { get; set; }
    }
}
