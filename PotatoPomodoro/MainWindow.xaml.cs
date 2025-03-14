using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PotatoPomodoro;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        MainFrame.Navigate(new StartPage());
        Topmost = false;
    }
    private void TitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        DragMove(); // 允许拖动窗口
    }
    // 置顶按钮点击事件
    private void PinButton_Click(object sender, RoutedEventArgs e)
    {
        Topmost = !Topmost; // 切换置顶状态
        PinButton.Content = Topmost ? "📍" : "📌"; // 切换图标以指示状态
    }

    // 关闭按钮点击事件
    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        Close(); // 关闭窗口
    }
}