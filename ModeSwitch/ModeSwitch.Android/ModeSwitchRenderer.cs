using Android.Content;
using Android.Graphics;
using Android.OS;
using ModeSwitchCustom.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ModeSwitchCustom.ModeSwitch), typeof(ModeSwitchRenderer))]
namespace ModeSwitchCustom.Droid
{
    public class ModeSwitchRenderer : SwitchRenderer
    {
        
        ModeSwitch view;
        public ModeSwitchRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Switch> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || e.NewElement == null)
                return;
            view = (ModeSwitch)Element;
            if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBean)
            {
                if (Control != null)
                {
                   Control.TrackDrawable.SetColorFilter(
                       view.BackgroundTintColor.ToAndroid(), 
                       PorterDuff.Mode.Src
                       );
                   Control.ThumbDrawable.SetColorFilter(
                       view.ThumbTintColor.ToAndroid(),
                       PorterDuff.Mode.SrcAtop
                       );
                   
                }
            }
        }
        //protected override void Dispose(bool disposing)
        //{
            
        //    base.Dispose(disposing);
        //}
    }
}