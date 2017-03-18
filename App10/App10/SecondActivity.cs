
using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using Android.Widget;

namespace App10
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Log.Debug(GetType().FullName, "II - OnCreate");
            SetContentView(Resource.Layout.Second);
            var secondCounter = FindViewById<TextView>(Resource.Id.SecondCounter);
            string data = Intent.GetStringExtra("Data key");
            secondCounter.Text = data;
        }

        protected override void OnStart()
        {
            base.OnStart();
            Log.Debug(GetType().FullName, "II - onStart");
        }

        protected override void OnStop()
        {
            base.OnStop();
            Log.Debug(GetType().FullName, "II - onStop");
        }

        protected override void OnDestroy()
        {
            Log.Debug(GetType().FullName, "II - OnDestroy");
            base.OnDestroy();
        }

        protected override void OnPause()
        {
            Log.Debug(GetType().FullName, "II - OnPause");
            base.OnPause();
        }

        protected override void OnRestart()
        {
            Log.Debug(GetType().FullName, "II - OnRestart");
            base.OnRestart();
        }

        protected override void OnResume()
        {
            Log.Debug(GetType().FullName, "II - OnResume");
            base.OnResume();
        }
    }
}