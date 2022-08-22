using System.Windows;
using System.Windows.Media;
using FontFamily = System.Windows.Media.FontFamily;

namespace A3DIcons.RemixIcons
{
    // adapted from https://bitbucket.org/ioachim/fontawesome.wpf
    public class IconBlock : IconBlockBase<RemixIcon>, IHaveIconFont
    {
        public IconBlock() : base(IconHelper.FontFor(RemixIcon.StarFill, IconFont.Auto))
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

        protected override FontFamily FontFor(RemixIcon icon)
        {
            return IconHelper.FontFor(icon, IconFont);
        }
    }
}
