using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Umbr2.Droid.Renderers;
using Umbr2.Renderers;

[assembly: ExportRenderer(typeof(BorderlessEntryRenderer), typeof(BorderlessEntryRenderer))]

namespace Umbr2.Droid.Renderers
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        public BorderlessEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
}