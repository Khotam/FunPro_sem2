using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wiut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var c = new Course("BIS");
            var a = new Applicant("Khotam", "Bakhromov", "SF, CA", new DateTime(2000, 1, 1), "single", "AA1234567", c);

            MessageBox.Show($"{a.Name} is on {a.Course.Name}");
        }
    }
}
