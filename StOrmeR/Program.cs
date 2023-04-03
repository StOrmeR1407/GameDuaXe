using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Windows.Forms;
using WinFormsLabel = System.Windows.Forms.Label;
using WinTimer = System.Windows.Forms.Timer;

namespace StOrmeR
{
    internal class Program
    {
        public class ThaiHoc : Form
        {
            public Button button1;
            public PictureBox pb1;
            public WinFormsLabel lb1;
            public WinFormsLabel lb2;
            public WinFormsLabel lb3;
            public WinFormsLabel lb4;
            public WinFormsLabel lb5;
            public WinFormsLabel lb6;
            public WinFormsLabel lb7;
            public WinFormsLabel lb8;
            public WinFormsLabel lb9;
            public WinFormsLabel lb10;
            public WinFormsLabel fl;
            public Timer timer1;
            public ThaiHoc()
            {
                // Dieu chinh co ban
                this.Size = new Size(800, 800);
                this.BackgroundImage = Image.FromFile(@"E:\c#\StOrmeR\StOrmeR\Resources\racetrack.png");

                // Thoi gian
                timer1 = new Timer();
                timer1.Enabled = false;

                // Day la nut bam
                button1 = new Button();
                button1.Size = new Size(50, 50);
                button1.Location = new Point(1200, 0);           

                // Day la xe 1
                lb1 = new WinFormsLabel();
                lb1.Size = new Size(80, 40);
                lb1.Text = "Xe 1";
                lb1.Location = new Point(90,10);
                lb1.BringToFront();

                // Day la xe 2
                lb2 = new WinFormsLabel();
                lb2.Size = new Size(80, 40);
                lb2.Text = "Xe 2";
                lb2.Location = new Point(90, 80);
                lb2.BringToFront();

                // Day la xe 3
                lb3 = new WinFormsLabel();
                lb3.Size = new Size(80, 40);
                lb3.Text = "Xe 3";
                lb3.Location = new Point(90, 140);
                lb3.BringToFront();

                // Day la xe 4
                lb4 = new WinFormsLabel();
                lb4.Size = new Size(80, 40);
                lb4.Text = "Xe 4";
                lb4.Location = new Point(90, 210);
                lb4.BringToFront();

                // Day la xe 5
                lb5 = new WinFormsLabel();
                lb5.Size = new Size(80, 40);
                lb5.Text = "Xe 5";
                lb5.Location = new Point(90, 270);
                lb5.BringToFront();

                // Day la xe 6
                lb6 = new WinFormsLabel();
                lb6.Size = new Size(80, 40);
                lb6.Text = "Xe 2";
                lb6.Location = new Point(90, 330);
                lb6.BringToFront();

                // Day la co
                fl = new WinFormsLabel();
                fl.Size = new Size(58, 637);
                fl.Location = new Point(1150, 0);
                fl.BringToFront();

                // Them anh xe vao label
                Image image1 = Image.FromFile(@"E:\c#\StOrmeR\StOrmeR\Resources\car1.png");
                lb1.Image = image1;
                lb1.BackColor = Color.Transparent;

                Image image2 = Image.FromFile(@"E:\c#\StOrmeR\StOrmeR\Resources\car2.png");
                lb2.Image = image2;
                lb2.BackColor = Color.Transparent;

                Image image3 = Image.FromFile(@"E:\c#\StOrmeR\StOrmeR\Resources\car3.png");
                lb3.Image = image3;
                lb3.BackColor = Color.Transparent;

                Image image4 = Image.FromFile(@"E:\c#\StOrmeR\StOrmeR\Resources\car4.png");
                lb4.Image = image4;
                lb4.BackColor = Color.Transparent;

                Image image5 = Image.FromFile(@"E:\c#\StOrmeR\StOrmeR\Resources\car5.png");
                lb5.Image = image5;
                lb5.BackColor = Color.Transparent;

                Image image6 = Image.FromFile(@"E:\c#\StOrmeR\StOrmeR\Resources\car6.png");
                lb6.Image = image6;
                lb6.BackColor = Color.Transparent;

                // them anh co vao label flag

                Image fl1 = Image.FromFile(@"C:\Users\SIEU THI SO 4G\Downloads\flag.png");
                fl.Image = fl1;
                fl.BackColor = Color.Transparent;

                // them anh vao nut bam
                Image btn_img = Image.FromFile(@"E:\c#\StOrmeR\StOrmeR\Resources\start.png");
                button1.Image = btn_img;
                button1.BackColor = Color.Transparent;

                //  Them cac thu vao cua so
                this.Controls.Add(button1);
                button1.Click += new EventHandler(button1_Click);
                this.Controls.Add(lb1);
                this.Controls.Add(lb2);
                this.Controls.Add(lb3);
                this.Controls.Add(lb4);
                this.Controls.Add(lb5);
                this.Controls.Add(lb6);
                this.Controls.Add(fl);

            }
            private int Random()
            {
                return new Random().Next(1,31);
            }

            private int getWidth(WinFormsLabel a)
            {
                return a.Left + a.Width;
            }
            private void button1_Click(object sender, EventArgs e)
            {
                timer1.Enabled = true;      
                timer1.Tick += new EventHandler(timer1_Tick);

            }
            private void timer1_Tick(object sender, EventArgs e)
            {
                lb1.Location = new Point(lb1.Location.X + Random(), lb1.Location.Y);
                lb2.Location = new Point(lb2.Location.X + Random(), lb2.Location.Y);
                lb3.Location = new Point(lb3.Location.X + Random(), lb3.Location.Y);
                lb4.Location = new Point(lb4.Location.X + Random(), lb4.Location.Y);
                lb5.Location = new Point(lb5.Location.X + Random(), lb5.Location.Y);
                lb6.Location = new Point(lb6.Location.X + Random(), lb6.Location.Y);

                if (getWidth(lb1) + Random() >= fl.Left)
                {
                    lb1.Left = fl.Left - lb1.Width;
                    timer1.Enabled = false;
                    MessageBox.Show("Xe 1 chien thang!!!");

                }
                else if (getWidth(lb2) + Random() >= fl.Left)
                {
                    lb2.Left = fl.Left - lb2.Width;
                    timer1.Enabled = false;
                    MessageBox.Show("Xe 2 chien thang!!!");

                }
                else if (getWidth(lb3) + Random() >= fl.Left)
                {
                    lb3.Left = fl.Left - lb3.Width;
                    timer1.Enabled = false;
                    MessageBox.Show("Xe 3 chien thang!!!");
                }
                else if (getWidth(lb4) + Random() >= fl.Left)
                {
                    lb4.Left = fl.Left - lb4.Width;
                    timer1.Enabled = false;
                    MessageBox.Show("Xe 4 chien thang!!!");
                }
                else if (getWidth(lb5) + Random() >= fl.Left)
                {
                    lb5.Left = fl.Left - lb5.Width;
                    timer1.Enabled = false;
                    MessageBox.Show("Xe 5 chien thang!!!");
                }
                else if (getWidth(lb6) + Random() >= fl.Left)
                {
                    lb6.Left = fl.Left - lb6.Width;
                    timer1.Enabled = false;
                    MessageBox.Show("Xe 6 chien thang!!!");
                }

            }

            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.Run(new ThaiHoc());
            }
        }
    }
}
