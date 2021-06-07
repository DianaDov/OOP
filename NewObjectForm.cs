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
    public partial class NewObjectForm : Form
    {
        public void callback(String name, String type) { }
        public NewObjectForm()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            classBox.SelectedIndex = 0;
            classBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
