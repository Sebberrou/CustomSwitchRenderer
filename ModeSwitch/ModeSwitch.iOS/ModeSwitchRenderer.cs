using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ModeSwitchCustom.ModeSwitch), typeof(ModeSwitch.iOS.ModeSwitchRenderer))]

namespace ModeSwitch.iOS
{
    class ModeSwitchRenderer : SwitchRenderer
    {
        ModeSwitchCustom.ModeSwitch view;

        protected override void OnElementChanged(ElementChangedEventArgs<Switch> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement != null)
            {
                view = (ModeSwitchCustom.ModeSwitch)Element;
                Control.ThumbTintColor = view.ThumbTintColor.ToUIColor();
                Control.TintColor = view.BackgroundTintColor.ToUIColor();
                Control.OnTintColor = view.BackgroundTintColor.ToUIColor();
                Control.BackgroundColor = view.BackgroundTintColor.ToUIColor();
            }
        }

        

    }
}