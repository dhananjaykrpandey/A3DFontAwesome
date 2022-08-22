namespace A3DFontAwesome
{
    public class Icon : IconBase<IconBlock, IconChar>, IHaveIconFont
    {
        public Icon(IconChar icon) : base(icon)
        {
        }

        public IconFont IconFont
        {
            get => IconBlock.IconFont;
            set => IconBlock.IconFont = value;
        }
    }
}
