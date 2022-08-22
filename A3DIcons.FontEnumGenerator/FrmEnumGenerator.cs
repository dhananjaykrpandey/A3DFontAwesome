using System.IO;
using System.Text;
using System.Data;
namespace A3DIcons.FontEnumGenerator
{
    public partial class FrmEnumGenerator : Form
    {
        public FrmEnumGenerator()
        {
            InitializeComponent();

        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmEnumGenerator_Load(object sender, EventArgs e)
        {
            RdbGenrateFromCss.Checked = true;
            RdbGenrateFromCss_CheckedChanged(RdbGenrateFromCss, null);
        }

        private void BtnOpenCssFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (var opnDls = new OpenFileDialog())
                {
                    opnDls.Title = "Select Css File";
                    opnDls.RestoreDirectory = true;
                    opnDls.Filter = "CSS File(*.css)|*.css";
                    if (opnDls.ShowDialog() == DialogResult.OK)
                    {
                        TxtSelectCssClass.Text = opnDls.FileName;
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private  void GenerateFontEnum(Options opts)
        {
            var fontParser = new FontParser { CssFile = opts.Css, Pattern = opts.Pattern };

            var items = fontParser.Parse();
            LblMessage.Text = ($"Matched {items.Count} icons from '{fontParser.CssFile}' using '{fontParser.Pattern}'");
            LblMessage.Update();
            var builder = new StringBuilder();
            builder.AppendLine(string.Format(Header, opts.Name, opts.NameSpace));
            items.ForEach(item => builder.AppendLine($"        {item.Class} = 0x{item.Code},"));
            builder.AppendLine(Footer);

            var path = $"{opts.Name}.cs";
            File.WriteAllText(path, builder.ToString());
            LblMessage.Text = ($"Generated '{path}'.");
            LblMessage.Update();
        }

        private static readonly string Header = "// ReSharper disable InconsistentNaming" + Environment.NewLine +
                                                "// ReSharper disable IdentifierTypo" + Environment.NewLine +
                                                "// ReSharper disable UnusedMember.Global" + Environment.NewLine +
                                                "// ReSharper disable once CheckNamespace" + Environment.NewLine +
                                                "namespace {1}" + Environment.NewLine +
                                                "{{" + Environment.NewLine +
                                                "    public enum {0}" + Environment.NewLine +
                                                "    {{" + Environment.NewLine +
                                                "        None = 0,";

        private static readonly string Footer = "    }" + Environment.NewLine +
                                                "}";

        private void BtnGenrate_Click(object sender, EventArgs e)
        {
            if (RdbGenrateFromCss.Checked)
            {
                Options options = new Options();
                options.Css = TxtSelectCssClass.Text.Trim();
                options.Pattern = TxtMatchingPattern.Text.Trim();
                options.NameSpace = TxtFileNameSpace.Text.Trim();
                options.Name = TxtCssFileName.Text.Trim();
                GenerateFontEnum(options);
            }
            else
            {
                DataSet ds = new DataSet();
                ds.ReadXml(TxtSelectSvgSourceFile.Text.Trim());
                var fontParser = new FontParser();
                fontParser.Pattern = TxtIconNameMatching.Text.Trim();
                var items = fontParser.ParseSvgXml(ds.Tables[TxtIconTableName.Text.Trim()],TxtIconClassName.Text.Trim(),TxtIconCodeMatching.Text.Trim());
                LblMessage.Text = ($"Matched {items.Count} icons from '{fontParser.CssFile}' using '{fontParser.Pattern}'");
                LblMessage.Update();
                var builder = new StringBuilder();
                builder.AppendLine(string.Format(Header, TxtFileName.Text.Trim(), TxtSvgFileNameSpace.Text.Trim()));
                items.ForEach(item => builder.AppendLine($"        {item.Class} = 0x{item.Code},"));
                builder.AppendLine(Footer);

                var path = $"{TxtFileName.Text.Trim()}.cs";
                File.WriteAllText(path, builder.ToString());
                LblMessage.Text=($"Generated '{path}'.");
                LblMessage.Update();
            }




        }
        

        private void RdbGenrateFromCss_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbGenrateFromCss.Checked)
            {
                splitContainer1.Panel2Collapsed = true;
                splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                splitContainer1.Panel2Collapsed = false;
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void BtnOpenSvgFileSource_Click(object sender, EventArgs e)
        {
            try
            {
                using (var opnDls = new OpenFileDialog())
                {
                    opnDls.Title = "Select Svg Xml File";
                    opnDls.RestoreDirectory = true;
                    opnDls.Filter = "Xml File(*.xml)|*.xml";
                    if (opnDls.ShowDialog() == DialogResult.OK)
                    {
                        TxtSelectSvgSourceFile.Text = opnDls.FileName;
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}