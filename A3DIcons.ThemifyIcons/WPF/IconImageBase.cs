using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace A3DIcons.ThemifyIcons
{
    public abstract class IconImageBase<TEnum> : System.Windows.Controls.Image where TEnum : struct, IConvertible, IComparable, IFormattable
    {
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(nameof(Icon),
            typeof(TEnum), typeof(IconImageBase<TEnum>),
            new PropertyMetadata(default(TEnum), OnIconPropertyChanged));

        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.Register(nameof(Foreground),
            typeof(System.Windows.Media.Brush), typeof(IconImageBase<TEnum>),
            new PropertyMetadata(IconHelper.DefaultBrush, OnForegroundPropertyChanged));

        protected abstract ImageSource ImageSourceFor(TEnum icon);

        protected IconImageBase()
        {
            if (!typeof(TEnum).IsEnum) throw new ArgumentException("TEnum must be an enum.");
        }

        public TEnum Icon
        {
            get => (TEnum)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public System.Windows.Media.Brush Foreground
        {
            get => (System.Windows.Media.Brush)GetValue(ForegroundProperty);
            set => SetValue(ForegroundProperty, value);
        }

        private static void OnIconPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is IconImageBase<TEnum> iconImage)) return;
            var icon = (TEnum)e.NewValue;
            var imageSource = iconImage.ImageSourceFor(icon);
            iconImage.SetValue(SourceProperty, imageSource);
        }

        private static void OnForegroundPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is IconImageBase<TEnum> iconImage)) return;
            var icon = (TEnum)d.GetValue(IconProperty);
            var imageSource = iconImage.ImageSourceFor(icon);
            iconImage.SetValue(SourceProperty, imageSource);
        }
    }
}
