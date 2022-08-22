using System;
using System.Reflection;

namespace A3DFontAwesome.Material
{
    using WinFormsFont = System.Drawing.FontFamily;
    using WpfFont = System.Windows.Media.FontFamily;
    internal static class MaterialDesignFont
    {
        public static readonly Lazy<WinFormsFont> WinForms = new(LodWinFormsFont);
        public static readonly Lazy<WpfFont> Wpf = new(LoadWpfFont);

        private static readonly Assembly FontAssembly = typeof(MaterialDesignFont).Assembly;
        private static WpfFont LoadWpfFont()
        {
            return FontAssembly.LoadFont("fonts", "Material Design Icons");
        }

        private static WinFormsFont LodWinFormsFont()
        {
            return FontAssembly.LoadResourceFont("fonts", "materialdesignicons-webfont.ttf");
        }
    }
}
