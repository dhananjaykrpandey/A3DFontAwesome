using System;
using System.IO;
using System.Text;

namespace A3DIcons.FontEnumGenerator
{
    internal class Options
    {
        //[Option(Default = @"Content\fontawesome.css", HelpText = "Input font css file to be processed.")]
        public string Css { get; set; }

        //[Option(Default = "\\.fa.(.+):before", HelpText = "RegEx Pattern to match a font icon class.")]
        public string Pattern { get; set; }


        //[Option(Default = "IconChar", HelpText = "Class & Output file to be generated.")]
        public string Name { get; set; }

        //[Option(Default = "FontAwesome.Sharp", HelpText = "Output namespace.")]
        public string NameSpace { get; set; }
    }
}
