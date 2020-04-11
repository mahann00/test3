using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator01
{
    public partial class Form1 : Form
    {
        IMycalculator mycalculator;
        public Form1()
        {
            InitializeComponent();
            mycalculator = new Mycalculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             

        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if(validateinput())
            {
                int divide = mycalculator.divide((int)nmb1.Value,(int)nmb2.Value);

                MessageBox.Show("int divide:" + divide);
            }
        }

        private void btnmultiple_Click(object sender, EventArgs e)
        {
            if(validateinput())
            {
                int multiple = mycalculator.multiple((int)nmb1.Value, (int)nmb2.Value);
                MessageBox.Show("int multiple:" + multiple);
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {

            if (validateinput())
            {
                int minus = mycalculator.minus((int)nmb1.Value, (int)nmb2.Value);
                MessageBox.Show("int minus:" + minus);
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {

            if (validateinput())
            {
                int plus = mycalculator.sum((int)nmb1.Value, (int)nmb2.Value);
                MessageBox.Show("int sum:" +plus);
            }
        }
        bool validateinput() 
        {
            bool isvalide = true;

            if(nmb1.Value == 0) 
            {
                MessageBox.Show("عدد نباید صفر باشد");
                isvalide = false;
            }
            else
            {
                if(nmb2.Value==0)
                {
                    MessageBox.Show("عدد دوم را هم صفر وارد نکنید");

                    isvalide = false;

                }
            }
            return isvalide;
        }
 
}
}
