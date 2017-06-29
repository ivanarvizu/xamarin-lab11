using Android.App;
using Android.Widget;
using Android.OS;

namespace Lab11
{
    [Activity(Label = "Lab11", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Complex Data;
        private int Counter = 0;

        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt("CounterValue", Counter);
            Android.Util.Log.Debug("Lab11Log", "Activity A - OnStateSaveInstance");

            base.OnSaveInstanceState(outState);
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Android.Util.Log.Debug("Lab11Log", "Activity A - Oncreate");

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.StartActivity).Click += (sender, e) =>
            {
                var ActivityIntent = new Android.Content.Intent(this, typeof(SecondActivity));
                StartActivity(ActivityIntent);
            };

            if(bundle != null)
            {
                Counter = bundle.GetInt("CounterValue", 0);
                Android.Util.Log.Debug("Lab11Log", "Activity A - Recovered Instance Save");
            }

            var ClickCounter = FindViewById<Button>(Resource.Id.ClicksCounter);
            ClickCounter.Text = Resources.GetString(Resource.String.ClicksCounter_Text, Counter);

            ClickCounter.Click += (sender, e) =>
            {
                Counter++;
                ClickCounter.Text = Resources.GetString(Resource.String.ClicksCounter_Text, Counter);
            };

        }
        //--------------------------------------------------------------------------------------------
        protected override void OnStart()
        {
            Android.Util.Log.Debug("Lab11Log", "Activity A - OnStart");
            base.OnStart();
        }
        //--------------------------------------------------------------------------------------------
        protected override void OnResume()
        {
            Android.Util.Log.Debug("Lab11Log", "Activity A - OnResume");
            base.OnResume();
        }
        //--------------------------------------------------------------------------------------------
        protected override void OnPause()
        {
            Android.Util.Log.Debug("Lab11Log", "Activity A - OnPause");
            base.OnPause();
        }
        //--------------------------------------------------------------------------------------------
        protected override void OnStop()
        {
            Android.Util.Log.Debug("Lab11Log", "Activity A - OnStop");
            base.OnStop();
        }
        //--------------------------------------------------------------------------------------------
        protected override void OnDestroy()
        {
            Android.Util.Log.Debug("Lab11Log", "Activity A - OnDestroy");
            base.OnDestroy();
        }
        //--------------------------------------------------------------------------------------------
        protected override void OnRestart()
        {
            Android.Util.Log.Debug("Lab11Log", "Activity A - OnRestart");
            base.OnRestart();
        }
    }
}

