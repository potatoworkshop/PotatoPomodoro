using System.IO;
using System.Text;
using System.Text.Json;
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
public partial class FocusPage : Page
{
    private DispatcherTimer timer;
    private TimeSpan remainingTime;
    private TimeSpan timeSetting;
    private bool isRunning = false;
    private bool isBreak = false;
    private TimeSpan breakTime;
    private List<FocusSession> focusSessions = new();
    private const string DataFilePath = "focus_data.json";

    public FocusPage(int minutes)
    {
        InitializeComponent();
        remainingTime = TimeSpan.FromMinutes(minutes);
        timeSetting = TimeSpan.FromMinutes(minutes);
        UpdateTimerText();
        UpdateNotificationText();
        LoadData();

        timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += (sender, e) =>
        {
            if (remainingTime.TotalSeconds > 0 && isRunning)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                UpdateTimerText();
            }
            else
            {
                timer.Stop();
                isRunning = false;
                if (!isBreak)
                {
                    focusSessions.Add(new FocusSession
                    {
                        Duration = timeSetting,
                        Timestamp = DateTime.Now
                    });
                    SetBreakTime();
                    isBreak = true;
                    remainingTime = breakTime;
                    isRunning = false;
                    StartButton.IsEnabled = true;
                    PauseButton.IsEnabled = false;
                    UpdateTimerText();
                    UpdateNotificationText();
                    SaveData();
                }
                else
                {
                    timer.Stop();
                    isRunning = false;
                    isBreak = false;
                    remainingTime = timeSetting;
                    UpdateTimerText();
                    StartButton.IsEnabled = true;
                    PauseButton.IsEnabled = false;
                    UpdateNotificationText();
                }
            }
        };
    }

    private void StartTimer(object sender, RoutedEventArgs e)
    {
        if (!isRunning)
        {
            timer.Start();
            isRunning = true;
            StartButton.IsEnabled = false;
            PauseButton.IsEnabled = true;
            UpdateNotificationText();
        }
    }

    private void PauseTimer(object sender, RoutedEventArgs e)
    {
        if (isRunning)
        {
            timer.Stop();
            isRunning = false;
            StartButton.IsEnabled = true;
            PauseButton.IsEnabled = false;
            UpdateNotificationText();
        }
    }

    private void ResetTimer(object sender, RoutedEventArgs e)
    {
        NavigationService?.Navigate(new StartPage());
    }

    private void SetBreakTime()
    {
        if (timeSetting.TotalMinutes <= 60)
        {
            breakTime = TimeSpan.FromMinutes(5);
        }
        else if (timeSetting.TotalMinutes <= 120)
        {
            breakTime = TimeSpan.FromMinutes(10);
        }
        else
        {
            breakTime = TimeSpan.FromMinutes(20);
        }
    }

    private void UpdateTimerText()
    {
        if (remainingTime >= TimeSpan.FromMinutes(60))
        {
            TimerText.Text = remainingTime.ToString(@"hh\:mm\:ss");
        }
        else
        {
            TimerText.Text = remainingTime.ToString(@"mm\:ss");
        }
    }

    private void UpdateNotificationText()
    {
        if (isBreak)
        {
            NotificationText.Text = "Break time!";
        }
        else if (!isRunning)
        {
            NotificationText.Text = "";
        }
        else
        {
            NotificationText.Text = "Time is running!";
        }
    }

    private void SaveData()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(focusSessions, options);
        File.WriteAllText(DataFilePath, jsonString);
    }

    private void LoadData()
    {
        if (File.Exists(DataFilePath))
        {
            if (File.Exists(DataFilePath))
            {
                string jsonString = File.ReadAllText(DataFilePath);
                focusSessions = JsonSerializer.Deserialize<List<FocusSession>>(jsonString) ?? new List<FocusSession>();
            }
        }
    }
}

public class FocusSession
{
    public TimeSpan Duration { get; set; }
    public DateTime Timestamp { get; set; }
}
