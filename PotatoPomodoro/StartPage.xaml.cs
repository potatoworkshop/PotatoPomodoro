using System;
using System.Collections.Generic;
using System.Linq;
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

namespace PotatoPomodoro
{
    /// <summary>
    /// StartPage.xaml 的交互逻辑
    /// </summary>
    public partial class StartPage : Page
    {
        private int selectedMinutes = 25; // 默认 25 分钟

        public StartPage()
        {
            InitializeComponent();
            PopulateTimeComboBox();
            TimeComboBox.SelectedIndex = 3;
        }

        private void PopulateTimeComboBox()
        {
            // 填充 10-120 分钟，每 5 分钟间隔
            for (int i = 10; i <= 120; i += 5)
            {
                TimeComboBox.Items.Add($"{i} min.");
            }
        }

        private void TimeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TimeComboBox.SelectedItem != null)
            {
                string selectedText = TimeComboBox.SelectedItem.ToString();
                selectedMinutes = int.Parse(selectedText.Split(' ')[0]);
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new FocusPage(selectedMinutes));
        }
    }
}
