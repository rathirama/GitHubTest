using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubTest
{
    public partial class frmGitHubTest : Form
    {
        public frmGitHubTest()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Lets add some comments...
            Close();
        }

        private void btnDoSomething_Click(object sender, EventArgs e)
        {
            ARandomClass arc = new ARandomClass(DateTime.Now.Second);
            Debug.WriteLine(arc.GetRandomNumber());
        }
    }
}
