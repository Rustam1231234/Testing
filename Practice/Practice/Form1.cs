using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        Frukts yabloko = new Frukts();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yabloko.description = "norm";
            yabloko.price = 50;
            yabloko.name = "yabloko";
            yabloko.age = 2;
            propertyGrid1.SelectedObject = yabloko;
        }
    }
}
