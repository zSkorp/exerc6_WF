using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX6WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            Conversor c;
            c = new Conversor();

            c.SetMetro(double.Parse(txt1.Text));

            txt2.Text = c.ConverterMilhasParaQuilometros().ToString();
        }
    }
}
