using mine_game.src.common;
using mine_game.src.connector.socket;
using mine_game.src.utils;
using System;
using System.Windows;

namespace mine_game
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("click");
            Program.Run();
            //Console.WriteLine(ExampleHelper.ProcessDirectory);
            //ReflectionUtil.run();
            Console.WriteLine("click end");
        }
    }
}
