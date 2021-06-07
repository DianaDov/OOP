using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop3
{
    public partial class DectyptForm : Form
    {
        public DectyptForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Encoding.UTF8.GetByteCount(textBox1.Text) >= 16 && !char.IsControl(e.KeyChar);
        }
    }
}
