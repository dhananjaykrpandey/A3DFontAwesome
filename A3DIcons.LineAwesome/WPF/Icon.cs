namespace A3DFontAwesome.LineAwesome
{
    public class Icon : IconBase<IconBlock, LineAwesomeIcons>, IHaveIconFont
    {
        public Icon(LineAwesomeIcons icon) : base(icon)
        {
        }

        public IconFont IconFont
        {
            get => IconBlock.IconFont;
            set => IconBlock.IconFont = value;
        }
    }
}
