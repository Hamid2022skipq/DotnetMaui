using Android.App;
using Firebase.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Google.Crypto.Tink.Signature;

namespace PushNotificationWithFirebase.Platforms.Android.Services
{
    [Service(Exported = true)]
    [IntentFilter(["com.google.firebase.MESSAGING_EVENT"])]
    public class FirebaseServices : FirebaseMessagingService
    {
        public FirebaseServices()
        {
        }
        public override void OnNewToken(string token)
        {
            base.OnNewToken(token);
            if (Preferences.ContainsKey("DeviceToken"))
            {
                Debug.WriteLine(Preferences.Get("DeviceToken",""));
                Preferences.Remove("DeviceToken");
            }
            Debug.WriteLine(Preferences.Get("DeviceToken", ""));
            Preferences.Set("DeviceToken", token);

        }
    }
}
