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
    public partial class information : template
    {
        public information()
        {
            InitializeComponent();
        }

        private void information_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new Main().Show();
            Hide();
        }
    }
}
