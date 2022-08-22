namespace A3DIcons.ionicons
{
    public class Icon : IconBase<IconBlock, IonIcons>, IHaveIconFont
    {
        public Icon(IonIcons icon) : base(icon)
        {
        }

        public IconFont IconFont
        {
            get => IconBlock.IconFont;
            set => IconBlock.IconFont = value;
        }
    }
}
