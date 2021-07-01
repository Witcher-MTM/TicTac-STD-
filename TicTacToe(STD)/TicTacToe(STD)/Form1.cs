using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_STD_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if(File.Exists("Language.txt"))
            comboBox1.SelectedItem = File.ReadAllText("Language.txt");
        }
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo(comboBox1.SelectedItem.ToString());
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, ci);
            }
            File.WriteAllText("Language.txt", comboBox1.SelectedItem.ToString());
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
