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
    public partial class Form1 : Form
    {
        // tạo log cho class form1
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x8000000;
                return param;
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width/2-this.Width/2, Screen.PrimaryScreen.Bounds.Height - this.Height);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            log.Info("UserName: " + userName);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                SendKeys.Send("G");
                log.Info("G");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("g");
                log.Info("g");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {

            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("Q");
                SendKeys.Send("Q");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("q");
                SendKeys.Send("q");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("E");

                SendKeys.Send("E");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("e");
                SendKeys.Send("e");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("W");
                SendKeys.Send("W");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("w");
                SendKeys.Send("w");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("R");
                SendKeys.Send("R");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("r");
                SendKeys.Send("r");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("T");
                SendKeys.Send("T");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("t");
                SendKeys.Send("t");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("Y");
                SendKeys.Send("Y");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("y");
                SendKeys.Send("y");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("U");
                SendKeys.Send("U");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("u");
                SendKeys.Send("u");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("I");
                SendKeys.Send("I");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("i");
                SendKeys.Send("i");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("O");
                SendKeys.Send("O");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("o");
                SendKeys.Send("o");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("P");
                SendKeys.Send("P");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("p");
                SendKeys.Send("p");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("{");
                SendKeys.Send("{{}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else if (CTRL.Checked || CTRL2.Checked)
            {
                log.Info("CTRL [");
                SendKeys.Send("^[");
                CTRL.Checked = false;
                CTRL2.Checked = false;
            }
            else
            {
                log.Info("[");
                SendKeys.Send("[");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("}");
                SendKeys.Send("{}}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else if (CTRL.Checked || CTRL2.Checked)
            {
                log.Info("CTRL ]");
                SendKeys.Send("^]");
                CTRL.Checked = false;
                CTRL2.Checked = false;
            }
            else
            {
                log.Info("]");
                SendKeys.Send("]");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("|");
                SendKeys.Send("{|}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("\\");
                SendKeys.Send("\\");
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("A");
                SendKeys.Send("A");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else if (CTRL.Checked || CTRL2.Checked)
            {
                log.Info("CTRL A");
                SendKeys.Send("^a");
                CTRL.Checked = false;
                CTRL2.Checked = false;
            }

            else
            {
                log.Info("a");
                SendKeys.Send("a");
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("S");
                SendKeys.Send("S");
                Shift.Checked = false;
                Shift2.Checked = false;


            }
            else
            {
                log.Info("s");
                SendKeys.Send("s");
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("F");
                SendKeys.Send("F");
                Shift.Checked = false;
                Shift2.Checked = false;


            }
            else
            {
                log.Info("f");
                SendKeys.Send("f");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("H");
                SendKeys.Send("H");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("h");
                SendKeys.Send("h");
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("J");
                SendKeys.Send("J");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("j");
                SendKeys.Send("j");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("K");
                SendKeys.Send("K");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("k");
                SendKeys.Send("k");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("L");
                SendKeys.Send("L");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("l");
                SendKeys.Send("l");
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("Z");
                SendKeys.Send("Z");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("z");
                SendKeys.Send("z");
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("X");
                SendKeys.Send("X");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("x");
                SendKeys.Send("x");
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("C");
                SendKeys.Send("C");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else if (CTRL.Checked || CTRL2.Checked)
            {
                log.Info("CTRL C");
                SendKeys.Send("^c");
                CTRL.Checked = false;
                CTRL2.Checked = false;

            }
            else
            {
                log.Info("c");
                SendKeys.Send("c");
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("V");
                SendKeys.Send("V");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else if (CTRL.Checked || CTRL2.Checked)
            {
                log.Info("CTRL V");
                SendKeys.Send("^v");
                CTRL.Checked = false;
                CTRL2.Checked = false;
            }

            else
            {
                log.Info("v");
                SendKeys.Send("v");
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("B");
                SendKeys.Send("B");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("b");
                SendKeys.Send("b");
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("N");
                SendKeys.Send("N");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("n");
                SendKeys.Send("n");
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("M");
                SendKeys.Send("M");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("m");
                SendKeys.Send("m");
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("<");
                SendKeys.Send("{<}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info(",");
                SendKeys.Send(",");
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info(">");
                SendKeys.Send("{>}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info(".");
                SendKeys.Send(".");
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("?");
                SendKeys.Send("{?}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("/");
                SendKeys.Send("/");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info(":");
                SendKeys.Send("{:}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info(";");
                SendKeys.Send(";");
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("\"");
                SendKeys.Send("\"");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("'");
                SendKeys.Send("'");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("~");
                SendKeys.Send("{~}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("`");
                SendKeys.Send("`");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("!");
                SendKeys.Send("{!}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("1");
                SendKeys.Send("1");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("@");
                SendKeys.Send("{@}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("2");
                SendKeys.Send("2");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("#");
                SendKeys.Send("{#}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("3");
                SendKeys.Send("3");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("$");
                SendKeys.Send("{$}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("4");
                SendKeys.Send("4");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("%");
                SendKeys.Send("{%}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("5");
                SendKeys.Send("5");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("^");
                SendKeys.Send("{^}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("6");
                SendKeys.Send("6");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("&");
                SendKeys.Send("{&}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("7");
                SendKeys.Send("7");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("*");
                SendKeys.Send("{*}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("8");
                SendKeys.Send("8");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("(");
                SendKeys.Send("{(}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("9");
                SendKeys.Send("9");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info(")");
                SendKeys.Send("{)}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("0");
                SendKeys.Send("0");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("_");
                SendKeys.Send("{_}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("-");
                SendKeys.Send("-");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (Shift.Checked || Shift2.Checked)
            {
                log.Info("+");
                SendKeys.Send("{+}");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                log.Info("=");
                SendKeys.Send("=");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Info("Esc");
            SendKeys.Send("{Esc}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            log.Info("F1");
            SendKeys.Send("{F1}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            log.Info("F2");
            SendKeys.Send("{F2}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            log.Info("F3");
            SendKeys.Send("{F3}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Alt.Checked || Alt2.Checked)
            {
                log.Info("ALT F4");
                SendKeys.Send("%{F4}");
                CTRL.Checked = false;
                CTRL2.Checked = false;
            }
            else
            {
                log.Info("F4");
                SendKeys.Send("{F4}");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            log.Info("F5");
            SendKeys.Send("{F5}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            log.Info("F6");
            SendKeys.Send("{F6}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            log.Info("F7");
            SendKeys.Send("{F7}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            log.Info("F8");
            SendKeys.Send("{F8}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            log.Info("F9");
            SendKeys.Send("{F9}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            log.Info("F10");
            SendKeys.Send("{F10}");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            log.Info("F11");
            SendKeys.Send("{F11}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            log.Info("F12");
            SendKeys.Send("{F12}");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            log.Info("ENTER");
            SendKeys.Send("{ENTER}");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            log.Info("BACKSPACE");
            SendKeys.Send("{BS}");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            log.Info("DELETE");
            SendKeys.Send("{DEL}");
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            log.Info("PRTSC");
            SendKeys.Send("{PRTSC}");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            log.Info("HOME");
            SendKeys.Send("{HOME}");
        }

        private void button54_Click_1(object sender, EventArgs e)
        {
            log.Info("PG Up");
            SendKeys.Send("{PGUP}");
        }

        private void button71_Click(object sender, EventArgs e)
        {
            log.Info("PG DOWN");
            SendKeys.Send("{PGDN}");
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            log.Info("INSERT");
            SendKeys.Send("{INS}");
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            log.Info("END");
            SendKeys.Send("{END}");
        }



        private void button74_Click(object sender, EventArgs e)
        {
            log.Info("LEFT");
            SendKeys.Send("{LEFT}");
        }

        private void button77_Click(object sender, EventArgs e)
        {
            log.Info("RIGHT");
            SendKeys.Send("{RIGHT}");
        }

        private void button75_Click(object sender, EventArgs e)
        {
            log.Info("UP");
            SendKeys.Send("{UP}");
        }

        private void button76_Click(object sender, EventArgs e)
        {
            log.Info("DOWN");
            SendKeys.Send("{DOWN}");
        }

        private void button78_Click(object sender, EventArgs e)
        {
            log.Info("SPACE");
            SendKeys.Send(" ");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            log.Info("TAB");
            SendKeys.Send("{TAB}");
        }

        private void DELETE1_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("DELETE");
                SendKeys.Send("{DEL}");
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("1");
                SendKeys.Send("1");
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            SendKeys.Send("{NUMLOCK}");
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("2");
                SendKeys.Send("2");
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("3");
                SendKeys.Send("3");
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("0");
                SendKeys.Send("0");
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("4");
                SendKeys.Send("4");
            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("5");
                SendKeys.Send("5");
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("6");
                SendKeys.Send("6");
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("7");
                SendKeys.Send("7");
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("8");
                SendKeys.Send("8");
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("9");
                SendKeys.Send("9");
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("/");
                SendKeys.Send("/");
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("*");
                SendKeys.Send("*");
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("-");
                SendKeys.Send("-");
            }
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("+");
                SendKeys.Send("{+}");
            }
        }

        private void ENTER2_Click(object sender, EventArgs e)
        {
            if (NumLock.Checked)
            {
                log.Info("ENTER");
                SendKeys.Send("{ENTER}");
            }
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || Shift.Checked || Shift2.Checked)
            {
                log.Info("D");
                SendKeys.Send("D");
                Shift.Checked = false;
                Shift2.Checked = false;
            }
            else
            {
                SendKeys.Send("d");
            }
        }

        private void Alt2_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(3, "Phím Ảo", "Nháy đúp chuột để mở",ToolTipIcon.Info);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

    }
}
