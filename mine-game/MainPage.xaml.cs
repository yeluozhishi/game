using mine_game.src.pages;
using mine_game.src.service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace mine_game
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private LoginService loginService;

        public MainPage()
        {
            this.InitializeComponent();
            loginService = ServiceHelper.Instance().getInstance<LoginService>(typeof(LoginService));
        }

        private void nextPage(object sender, RoutedEventArgs e)
        {
            Navigation.RootFrame.Navigate(typeof(PlayerPanel), null, new DrillInNavigationTransitionInfo());
        }

        private void login(object sender, RoutedEventArgs e)
        {
            loginService.login("1");
        }
    }
}
