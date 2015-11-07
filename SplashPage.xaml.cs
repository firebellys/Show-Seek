using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Show_Seek
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplashPage : Page
    {
        private DispatcherTimer _closeTimer = new DispatcherTimer();
        public SplashPage()
        {
            this.InitializeComponent();
            _closeTimer = new DispatcherTimer();
            _closeTimer.Tick += dispatcherTimer_Tick;
            _closeTimer.Interval = new TimeSpan(0, 0, 5);
            _closeTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, object e)
        {
            Frame.Navigate(typeof(MainPage));
            _closeTimer.Stop();
            _closeTimer = null;
        }
    }
}
