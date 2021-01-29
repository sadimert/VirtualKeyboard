using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("O");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("o");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("P");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("p");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("Ğ");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("ğ");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("Ü");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("ü");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("U");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("u");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("Y");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("y");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("T");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("t");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("R");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("r");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("E");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("e");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("W");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("w");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("Q");
                checkBox2.Checked = false;
            }
            else
                SendKeys.Send("q");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("I");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("ı");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("A");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("a");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("S");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("s");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("D");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("d");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("F");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("f");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("G");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("g");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("H");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("h");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("J");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("j");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("K");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("k");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("L");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("l");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("Ş");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("ş");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                SendKeys.Send("İ");
                checkBox3.Checked = false;
            }
            else
                SendKeys.Send("i");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send(";");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send(",");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send(">");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("<");

        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Z");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("z");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("X");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("x");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("C");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("c");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("V");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("v");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("B");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("b");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("N");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("n");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("M");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("m");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Ö");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("ö");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Ç");
                checkBox3.Checked = false;


            }
            else
                SendKeys.Send("ç");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send("S");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send("s");
        }

        //space
        private void button43_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                SendKeys.Send("!");
            }
            else
                SendKeys.Send("1");
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked || checkBox3.Checked)
            {
                SendKeys.Send(":");
                checkBox3.Checked = false;

            }
            else
                SendKeys.Send(".");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                SendKeys.Send("'");

            }
            else
                SendKeys.Send("2");


        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {

                SendKeys.Send("#");

            }
            else
                SendKeys.Send("3");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {

                SendKeys.Send("$");

            }
            else
                SendKeys.Send("4");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {

                SendKeys.Send("{%}");

            }
            else
                SendKeys.Send("5");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {

                SendKeys.Send(@"\");

            }
            else
                SendKeys.Send("6");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {

                SendKeys.Send("/");

            }
            else
                SendKeys.Send("7");
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {

                SendKeys.Send("{(}");

            }
            else
                SendKeys.Send("8");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {

                SendKeys.Send("{)}");

            }
            else
                SendKeys.Send("9");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {

                SendKeys.Send("=");

            }
            else
                SendKeys.Send("0");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{-}");
        }



        private void button13_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{+}");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }



        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                button63.Text = "1";
                button62.Text = "2";
                button61.Text = "3";
                button60.Text = "4";
                button59.Text = "5";
                button57.Text = "7";
                button58.Text = "6";
                button52.Text = "8";
                button53.Text = "9";
                button54.Text = "0";
                checkBox5.Checked = false;
            }

         
        }

    
        

        private void button26_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            SendKeys.Send("*");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            SendKeys.Send("/");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{{}");
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{}}");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            SendKeys.Send("[");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            SendKeys.Send("]");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            SendKeys.Send("-");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            SendKeys.Send("_");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            SendKeys.Send("?");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            SendKeys.Send("@");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                button63.Text = "!";
                button62.Text = "'";
                button61.Text = "#";
                button60.Text = "$";
                button59.Text = "%";
                button57.Text = "/";
                button58.Text = @"\";
                button52.Text = "(";
                button53.Text = ")";
                button54.Text = "=";
               
            }
        }

        }
}


