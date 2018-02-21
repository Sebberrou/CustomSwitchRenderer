using System.ComponentModel;
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
                    int[][] states = new int[][] {
                        new int[] { Android.Resource.Attribute.StateEnabled}, // enabled
                        new int[] { - Android.Resource.Attribute.StateEnabled}, // disabled
                    };
                    var backgroundColorsList = new Android.Content.Res.ColorStateList(states,
                        new int[]{
                        view.BackgroundTintColor.ToAndroid(),
                        view.BackgroundTintColor.WithLuminosity(.9).ToAndroid()
                        });

                    var thumbColorsList = new Android.Content.Res.ColorStateList(states,
                    new int[]{
                        view.ThumbTintColor.ToAndroid(),
                        view.ThumbTintColor.WithSaturation(.4).WithLuminosity(.8).ToAndroid()
                    });


                    //var thumbColor = view.ThumbTintColor.ToAndroidPreserveDisabled(thumbColorsList);

                    Control.TrackTintList = backgroundColorsList;
                    Control.ThumbTintList = thumbColorsList; 
                }
            }
        }
    }
}