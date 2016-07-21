using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace Freeesh.Fragments
{
    public class StageScheduleFragment : Fragment
    {

        public static StageScheduleFragment NewInstance()
        {
            return new StageScheduleFragment();
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var v = inflater.Inflate(Resource.Layout.fragment_stage_schedule, container, false);
            return v;
        }
    }
}