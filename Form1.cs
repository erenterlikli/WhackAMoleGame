using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KöstebekOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int puan = 0; 
        Random rnd = new Random();
       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for(int i=1;i<85;i++)
            {
                Button btn = new Button();
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                btn.Width = 50;
                btn.Height = 50;
                btn.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int rastgele = rnd.Next(1, 85);
            foreach(var a in flowLayoutPanel1.Controls)
            {
                Button btn = a as Button;
                if(btn.Text==rastgele.ToString()) //rastgele bir buton yansın.
                {
                    btn.BackColor = Color.Red;
                    
                        btn.Click += new EventHandler(Btn_Click);
                    
                }

                else
                {
                    btn.BackColor = Color.White;
                }
                  
            }
        }

         void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

          if(btn.BackColor==Color.Red)
            {
                puan++;
                label2.Text = puan.ToString();
            }
            else
            {
                puan--;
                label2.Text = puan.ToString();
            }
        }
    }
}
