using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public  void update()
        {
            this.textBox1.Text = Program.curEvent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Program.socketConnect();
                this.textBox1.Text = Program.curEvent;
            }
            catch (Exception)
            {
                (new Form2()).Show();
            }
            
        }
    }
}
