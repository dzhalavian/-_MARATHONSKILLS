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
    public partial class RgAsARunner : template
    {
        public RgAsARunner()
        {
            InitializeComponent();
        }

        private void RgAsARunner_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new Main().Show();
            Hide();
        }
    }
}
