using mine_game.src.connector.socket;
using mine_game.src.service;
using System;
using System.Windows;

namespace mine_game
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginService loginService = null;

        public MainWindow()
        {
            InitializeComponent();
            loginService = ServiceHelper.Instance().getInstance<LoginService>(typeof(LoginService));
        }

        private void login(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("click");
            loginService.login("1");
            Console.WriteLine("click end");
        }

        private void register(object sender, RoutedEventArgs e)
        {
            loginService.register();
        }
    }
}
