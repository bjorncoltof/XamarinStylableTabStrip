using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace XamarinStylableTabStrip
{
    public class FragmentOne : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.FragmentOne, container, false);
        }
    }

    public class FragmentTwo : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.FragmentTwo, container, false);
        }
    }

    public class FragmentThree : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.FragmentThree, container, false);
        }
    }
}