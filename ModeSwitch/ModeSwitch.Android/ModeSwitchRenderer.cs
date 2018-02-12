using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using ModeSwitchCustom;
using Xamarin.Forms;
using ModeSwitchCustom.Droid;
using Android.Graphics;

[assembly: ExportRenderer(typeof(ModeSwitchCustom.ModeSwitch), typeof(ModeSwitchRenderer))]
namespace ModeSwitchCustom.Droid
{
    public class ModeSwitchRenderer : SwitchRenderer
    {
        
        ModeSwitch view;
        public ModeSwitchRenderer(Context context) : base(context)
        {
            System.Diagnostics.Debug.WriteLine("ctor Custom Renderer");
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
                    if (Control.Checked)
                    {
                        Control.TrackDrawable.SetColorFilter(view.BackgroundTintColor.ToAndroid(), PorterDuff.Mode.SrcAtop);
            
                    }
                    else
                    {
                        Control.TrackDrawable.SetColorFilter(Android.Graphics.Color.White, PorterDuff.Mode.SrcAtop);
                       
                    }
                    Control.CheckedChange += OnCheckedChange;
                }
                Control.ThumbDrawable.SetColorFilter(view.ThumbTintColor.ToAndroid(), PorterDuff.Mode.Multiply);
            }
        }


        private void OnCheckedChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            if (Control.Checked)
            {
                Control.TrackDrawable.SetColorFilter(view.BackgroundTintColor.ToAndroid(), PorterDuff.Mode.SrcAtop);
            }
            else
            {
                Control.TrackDrawable.SetColorFilter(Android.Graphics.Color.White, PorterDuff.Mode.SrcAtop);
            }
        }
        protected override void Dispose(bool disposing)
        {
            Control.CheckedChange -= OnCheckedChange;
            base.Dispose(disposing);
        }
    }
}