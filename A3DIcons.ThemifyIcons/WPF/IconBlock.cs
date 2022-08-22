using System.Windows;
using System.Windows.Media;
using FontFamily = System.Windows.Media.FontFamily;

namespace A3DIcons.ThemifyIcons
{
    // adapted from https://bitbucket.org/ioachim/fontawesome.wpf
    public class IconBlock : IconBlockBase<ThemifyIcons>, IHaveIconFont
    {
        public IconBlock() : base(IconHelper.FontFor(ThemifyIcons.Star, IconFont.Auto))
        { }

        public static readonly DependencyProperty IconFontProperty = DependencyProperty.Register(nameof(IconFont),
            typeof(IconFont), typeof(IconBlock),
            new PropertyMetadata(IconFont.Auto, OnIconFontPropertyChanged));

        private static void OnIconFontPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is IconBlock iconBlock)) return;
            iconBlock.SetValue(FontFamilyProperty, iconBlock.FontFor(iconBlock.Icon));
        }


        public IconFont IconFont
        {
            get => (IconFont)GetValue(IconFontProperty);
            set => SetValue(IconFontProperty, value);
        }

        protected override FontFamily FontFor(ThemifyIcons icon)
        {
            return IconHelper.FontFor(icon, IconFont);
        }
    }
}
