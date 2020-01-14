using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int Xlocation, Ylocation, speed;
        protected override CreateParams CreateParams
        { 
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;


            } 
        }
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Xlocation = this.Location.X;
            Ylocation = this.Location.Y;
            speed = 20;
            Speedtb.Text = speed.ToString();
        }
        public void Up(int value)
        {

            Ylocation = Ylocation - value;
            this.Location = new Point(Xlocation, Ylocation);
            
        }
        void Down(int value) {

            Ylocation = Ylocation + value;
            this.Location = new Point(Xlocation, Ylocation);
            
        }
        void Left(int value) {

            Xlocation = Xlocation - value;
            this.Location = new Point(Xlocation, Ylocation);
        }
        void Right(int value) {

            Xlocation = Xlocation + value;
            this.Location = new Point(Xlocation, Ylocation);
        }
        private void upbtn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("Q");

            //GetSpeed();
            //Up(speed);
            

    
    }
        private void downbtn_Click(object sender, EventArgs e)
        {
            GetSpeed();
            Down(speed);

        }
        private void leftbtn_Click(object sender, EventArgs e)
        {
            GetSpeed();
            Left(speed);

        }
        private void Speedtb_TextChanged(object sender, EventArgs e)
        {

        }
        private void rightbtn_Click(object sender, EventArgs e)
        {
            GetSpeed();
            Right(speed);
        }
        void GetSpeed() {

            speed = Int32.Parse (Speedtb.Text.ToString());
        
        }
    }
}
