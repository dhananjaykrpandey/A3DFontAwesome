namespace A3DFontAwesome.LineAwesome
{
    public class IconSource : IconSourceBase<LineAwesomeIcons>, IHaveIconFont
    {
        private IconFont _iconFont = IconFont.Auto;

        public IconSource(LineAwesomeIcons icon) : base(icon)
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
