namespace A3DIcons.ThemifyIcons
{
    public class Icon : IconBase<IconBlock, ThemifyIcons>, IHaveIconFont
    {
        public Icon(ThemifyIcons icon) : base(icon)
        {
        }

        public IconFont IconFont
        {
            get => IconBlock.IconFont;
            set => IconBlock.IconFont = value;
        }
    }
}
