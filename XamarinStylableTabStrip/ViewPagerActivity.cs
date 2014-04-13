using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinStylableTabStrip
{
    [Activity(Label = "ViewPager", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.NoTitleBar")]
    public class ViewPagerActivity : Android.Support.V4.App.FragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var adapter =
                new GenericFragmentPagerAdapter(SupportFragmentManager,
                    new FragmentOne(), new FragmentTwo(), new FragmentThree());
            var viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewPager);
            viewPager.Adapter = adapter;
        }
    }
}

