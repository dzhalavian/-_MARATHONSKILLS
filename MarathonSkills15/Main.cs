using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonSkills15
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RgAsARunner().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SprARun().Show();
            Hide();
        }

        private void bt_Sbi_Click(object sender, EventArgs e)
        {
            new information().Show();
            Hide();
        }
    }
}
