using Android.App;
using Android.Content;
using Freeesh.Fragments;

namespace Freeesh.Activities
{
    [Activity(MainLauncher = true, Icon = "@drawable/icon")]
    public class StageScheduleActivity : SingleFragmentActivity
    {
        public static Intent NewIntent(Context context)
        {
            return new Intent(context, typeof(StageScheduleActivity));
        }

        protected override Android.Support.V4.App.Fragment CreateFragment()
        {
            return StageScheduleFragment.NewInstance();
        }
    }
}