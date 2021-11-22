using ReactiveUI;

using Splat;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RxuiMultiRouterSample.ViewModels
{
    public class BScreenViewModel : ReactiveObject, IScreen
    {
        public BScreenViewModel()
        {
            Router = new RoutingState();
            Locator.CurrentMutable.RegisterConstant<IScreen>(this, ScreenNames.Screen2);
        }
        public RoutingState Router { get; }
    }
}
