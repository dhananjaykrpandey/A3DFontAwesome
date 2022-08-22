namespace NpccIconBusiness
{
    public class Icon : IconBase<IconBlock, TIcon>, IHaveIconFont
    {
        public Icon(object icon) : base(icon)
        {
        }

        public IconFont IconFont
        {
            get => IconBlock.IconFont;
            set => IconBlock.IconFont = value;
        }
    }
}
