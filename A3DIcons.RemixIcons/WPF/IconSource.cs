namespace A3DIcons.RemixIcons
{
    public class IconSource : IconSourceBase<RemixIcon>, IHaveIconFont
    {
        private IconFont _iconFont = IconFont.Auto;

        public IconSource(RemixIcon icon) : base(icon)
        {
        }

        protected override void UpdateImageSource()
        {
            ImageSource = Icon.ToImageSource(IconFont, Foreground, Size);
        }

        public IconFont IconFont
        {
            get => _iconFont;
            set
            {
                if (_iconFont.Equals(value)) return;
                _iconFont = value;
                UpdateImageSource();
            }
        }
    }
}
