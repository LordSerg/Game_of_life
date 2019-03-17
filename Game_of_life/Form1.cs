using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_life
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form1 f;
        private void Form1_Load(object sender, EventArgs e)
        {
            //f = new Form1();
            //Application.Run(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}
