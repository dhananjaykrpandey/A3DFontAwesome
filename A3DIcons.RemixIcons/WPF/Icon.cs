namespace A3DIcons.RemixIcons
{
    public class Icon : IconBase<IconBlock, RemixIcon>, IHaveIconFont
    {
        public Icon(RemixIcon icon) : base(icon)
        {
        }

        public IconFont IconFont
        {
            get => IconBlock.IconFont;
            set => IconBlock.IconFont = value;
        }
    }
}
