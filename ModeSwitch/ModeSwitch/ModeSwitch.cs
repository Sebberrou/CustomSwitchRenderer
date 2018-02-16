using Xamarin.Forms;

namespace ModeSwitchCustom
{
    /// <summary>
    /// Class Mode Switch, when it's not between on and off
    /// </summary>
    public class ModeSwitch : Switch
    {
        public static readonly BindableProperty BackgroundTintColorProperty = BindableProperty.Create(
            "BackgroundTintColor", typeof(Color),typeof(ModeSwitch),defaultValue: Color.FromHex("303"));

        public static readonly BindableProperty ThumbTintColorProperty = BindableProperty.Create(
            "ThumbTintColor", typeof(Color), typeof(ModeSwitch),defaultValue: Color.FromHex("e052e0"));

        /// <summary>
        ///     Gets or sets the color of the Background tint.
        /// </summary>
        /// <value>The color of the background tint.</value>
        public Color BackgroundTintColor
        {
            get { return (Color)GetValue(BackgroundTintColorProperty); }

            set { SetValue(BackgroundTintColorProperty, value); }
        }


        /// <summary>
        ///     Gets or sets the color of the Background tint.
        /// </summary>
        /// <value>The color of the background tint.</value>
        public Color ThumbTintColor
        {
            get { return (Color)GetValue(ThumbTintColorProperty); }

            set { SetValue(ThumbTintColorProperty, value); }
        }
    }
}
