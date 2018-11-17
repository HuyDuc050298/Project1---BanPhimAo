using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phima0
{
    public partial class Aboutus : Form
    {
        public Aboutus()
        {
            InitializeComponent();
        }
        static Aboutus MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show (String Text , String Caption , String OK)
        {
            MsgBox = new Aboutus();
            MsgBox.label1.Text = Text;
            MsgBox.button1.Text = OK;
            MsgBox.Text = Caption;
            MsgBox.ShowDialog();
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }
    }
}
