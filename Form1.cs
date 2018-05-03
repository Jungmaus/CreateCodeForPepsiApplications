using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _101PepsiHack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]


        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);


        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        private string alanx, alany, btnalanx, btnalany, code = "";
        Random rndm = new Random();

        private Point benimPoint1;
        private Point benimPoint2;

        private string[] harfList =
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V",
            "Y", "Z"
        };

        private string[] sayiList = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        private void lblX_Click(object sender, EventArgs e)
        {

        }

        void BolumBir()
        {
            CreateCode();
            Clipboard.SetText(code);
            benimPoint1 = new Point(int.Parse(alanx), int.Parse(alany));
            Cursor.Position = benimPoint1;

            mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
           

            SendKeys.Send("^{a}");
            SendKeys.Send("{DEL}");
            SendKeys.Send("^{v}");
        }

        void BolumIki()
        {
            benimPoint2 = new Point(int.Parse(btnalanx), int.Parse(btnalany));       
            Cursor.Position = benimPoint2;

            mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            BolumBir();
            BolumIki();
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        void CreateCode()
        {
            string ilkUc = "";
            string sonBes = "";
            ilkUc += harfList[rndm.Next(0, harfList.Length - 1)];
            ilkUc += harfList[rndm.Next(0, harfList.Length - 1)];
            ilkUc += harfList[rndm.Next(0, harfList.Length - 1)];
            sonBes += sayiList[rndm.Next(0, sayiList.Length - 1)];
            sonBes += sayiList[rndm.Next(0, sayiList.Length - 1)];
            sonBes += sayiList[rndm.Next(0, sayiList.Length - 1)];
            sonBes += sayiList[rndm.Next(0, sayiList.Length - 1)];
            sonBes += sayiList[rndm.Next(0, sayiList.Length - 1)];
            code = ilkUc + sonBes;
            txtCode.Text = code;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblX.Text = Cursor.Position.X.ToString();
            lblY.Text = Cursor.Position.Y.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            alanx = txtAlanX.Text;
            alany = txtAlanY.Text;
            btnalanx = txtButtonX.Text;
            btnalany = txtButtonY.Text;
            timer2.Enabled = true;
        }
    }
}
