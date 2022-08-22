using A3DFontAwesome;
using System;
using System.Windows.Forms;
using System.Drawing;
using A3DFontAwesome.LineAwesome;
using A3DIcons.ionicons;

namespace TestFontAwasome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Image = IconChar.Inbox.ToBitmap(System.Drawing.Color.Red);
            button1.Text = "Icon Char";
            A3DFontAwesome.Material.MaterialPictureBox materialPictureBox = new A3DFontAwesome.Material.MaterialPictureBox();
            materialPictureBox.IconChar = MaterialIcons.UsbFlashDrive;

            button2.Image = materialPictureBox.Image;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Image = LineAwesomeIcons.FileArchiveO.ToBitmap(Color.Red, 48);
            button4.Image = IonIcons.MdStar.ToBitmap(Color.Red, 48);
        }
    }
}
