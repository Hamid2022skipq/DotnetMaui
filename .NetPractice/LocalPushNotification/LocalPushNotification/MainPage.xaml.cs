using Microsoft.Maui.Controls.PlatformConfiguration;
using Plugin.LocalNotification.AndroidOption;
using Plugin.LocalNotification.iOSOption;
using Plugin.LocalNotification;
namespace LocalPushNotification

{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var request = new NotificationRequest
            {
                NotificationId = 1337, // Unique ID for the notification
                Title = "TSS", // Title of the notification
                Subtitle = "Hello! I'm Hamid Ali", // Subtitle of the notification
                Description = "Local Push Notification", // Content of the notification
                BadgeNumber = 50, // Number to show on the app icon
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now.AddSeconds(3), // Schedule notification to show after 3 seconds
                },
                //AndroidSettings = new AndroidOptions // Android-specific settings
                //{
                //    Importance = Importance.High, // Set the importance level
                //    Priority = Priority.High, // Set the priority level
                //    Sound = "default", // Set the sound
                //    VibratePattern = new long[] { 100, 200, 300, 400, 500, 400, 300, 200, 400 }, // Set the vibration pattern
                //    ChannelId = "your_channel_id", // Set the channel ID
                //    ChannelName = "your_channel_name", // Set the channel name
                //    ChannelDescription = "your_channel_description", // Set the channel description
                //    Color = Android.Graphics.Color.Red, // Set the color of the notification
                //    LedColor = Android.Graphics.Color.Yellow, // Set the LED color
                //    LockScreenVisibility = NotificationVisibility.Public // Set the lock screen visibility
                //},
                //iOSSettings = new Plugin.LocalNotification.iOSOption // iOS-specific settings
                //{
                //    BadgeType = iOSBadgeType.Count, // Set the badge type
                //    ShowInForeground = true, // Show notification when app is in foreground
                //    ForegroundAlert = true, // Show alert when app is in foreground
                //    CategoryIdentifier = "your_category_identifier", // Set the category identifier
                //    ThreadIdentifier = "your_thread_identifier", // Set the thread identifier
                //    Sound = "default", // Set the sound
                //    CriticalAlertSound = "critical_alert_sound", // Set the critical alert sound
                //    CriticalAlertVolume = 1.0f // Set the volume for the critical alert sound
                //}
            };

            LocalNotificationCenter.Current.Show(request); // Show the notification

        }
    }

}
