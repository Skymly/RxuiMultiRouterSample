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
    public class CViewModel : ReactiveObject, IRoutableViewModel
    {
        public CViewModel()
        {
            UrlPathSegment = GetType().Name;
            HostScreen = Locator.Current.GetService<IScreen>(ScreenNames.Screen2);
        }

        public string UrlPathSegment { get; set; }
        public IScreen HostScreen { get; set; }
    }
}
