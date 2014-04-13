using Android.Content;
using Android.Graphics;
using Android.Util;

namespace XamarinStylableTabStrip
{
    public class StylablePagerTabStrip : Android.Support.V4.View.PagerTabStrip
    {
        public StylablePagerTabStrip(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
            var styledAttributes = context.ObtainStyledAttributes(attrs, Resource.Styleable.StylablePagerTabStrip);

            // Style 1
            for (var i = 0; i < styledAttributes.IndexCount; ++i)
            {
                var index = styledAttributes.GetIndex(i);
                switch (index)
                {
                    case Resource.Styleable.StylablePagerTabStrip_indicatorColor:
                        TabIndicatorColor = styledAttributes.GetColor(index, Android.Resource.Color.White);
                        break;
                }
            }

            // Style 2
            TabIndicatorColor = styledAttributes.GetColor(Resource.Styleable.StylablePagerTabStrip_indicatorColor,
                Android.Resource.Color.White);
            
            styledAttributes.Recycle();
        }
    }
}