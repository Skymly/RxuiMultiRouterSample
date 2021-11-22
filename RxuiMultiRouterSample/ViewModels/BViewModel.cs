using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using ReactiveUI;
using ReactiveUI.Wpf;

using Splat;

namespace RxuiMultiRouterSample.ViewModels
{
    public class BViewModel : ReactiveObject, IRoutableViewModel
    {
        public BViewModel()
        {
            UrlPathSegment = GetType().Name;
            HostScreen = Locator.Current.GetService<IScreen>(ScreenNames.Screen1);
        }

        public string UrlPathSegment { get; set; }
        public IScreen HostScreen { get; }
    }
}
