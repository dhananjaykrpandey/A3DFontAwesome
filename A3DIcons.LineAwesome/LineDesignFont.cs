using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using Application = System.Windows.Application;
namespace NpccFontAwesome.LineAwesome
{
    using WinFormsFont = FontFamily;
    using WpfFont = System.Windows.Media.FontFamily;
    internal static class LineDesignFont
    {
        private static readonly Lazy<PrivateFontCollection> Fonts = new(InitializeFonts);
        private static readonly Lazy<FontFamily> FallbackFont = new(() => Fonts.Value.Families[0]);
        public static readonly Lazy<WinFormsFont> WinForms = new(LodWinFormsFont);
        public static readonly Lazy<WpfFont> Wpf = new(LoadWpfFont);

        private static readonly Assembly FontAssembly = typeof(LineDesignFont).Assembly;

        private static PrivateFontCollection InitializeFonts()
        {
            var fontFiles = new[] { "fa-solid-900.ttf", "fa-regular-400.ttf", "fa-brands-400.ttf" };
            var fonts = new PrivateFontCollection();
            foreach (var fontFile in fontFiles.Reverse())
            {
                try
                {
                    AddFont(fonts, fontFile);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine($"Could not load FontAwesome: {ex}");
                    throw;
                }
            }
            return fonts;
        }
        public static unsafe void AddFont(this PrivateFontCollection fonts, string fontFile,
         Assembly assembly = null, string path = "fonts")
        {
            var fontBytes = GetFontBytes(fontFile, assembly, path);
            fixed (byte* pFontData = fontBytes)
            {
                fonts.AddMemoryFont((IntPtr)pFontData, fontBytes.Length);
                uint dummy = 0;
                NativeMethods.AddFontMemResourceEx((IntPtr)pFontData, (uint)fontBytes.Length, IntPtr.Zero,
                    ref dummy);
            }
        }
        private static byte[] GetFontBytes(string fontFile,
            Assembly assembly = null, string path = "fonts")
        {
            var safeAssembly = assembly ?? typeof(FormsIconHelper).Assembly;
            var relativeUri = new Uri($"./{safeAssembly.GetName().Name};component/{path}/{fontFile}", UriKind.Relative);
            var uri = new Uri(IconHelper.BaseUri, relativeUri);
            var streamInfo = Application.GetResourceStream(uri);
            // ReSharper disable once PossibleNullReferenceException
            using (streamInfo.Stream)
            {
                return ReadAllBytes(streamInfo.Stream);
            }
        }

        private static byte[] ReadAllBytes(Stream stream)
        {
            if (stream is MemoryStream memoryStream)
                return memoryStream.ToArray();

            using (memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
        private static WpfFont LoadWpfFont()
        {
            FontAssembly.LoadFont("fonts", "la-brands-400");
            FontAssembly.LoadFont("fonts", "la-solid-900");
            return FontAssembly.LoadFont("fonts", "la-regular-400");
        }

        private static WinFormsFont LodWinFormsFont()
        {
            FontAssembly.LoadResourceFont("fonts", "la-brands-400.ttf");
            FontAssembly.LoadResourceFont("fonts", "la-solid-900.ttf");
            return FontAssembly.LoadResourceFont("fonts", "la-regular-400.ttf");
        }
    }
}
