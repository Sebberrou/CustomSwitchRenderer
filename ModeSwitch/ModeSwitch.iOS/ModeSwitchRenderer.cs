using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using ModeSwitchCustom;

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
                Control.TintColor = UIColor.White;
                Control.OnTintColor = view.BackgroundTintColor.ToUIColor();
            }
        }

        

    }
}