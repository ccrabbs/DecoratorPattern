using System;
using System.Windows.Forms;

namespace DecoratorPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IComponent ic = new Component();
            DecoratorTime dct = new DecoratorTime(ic);
            MessageBox.Show(ic.Welcome("Bill"));
            DecoratorBDay dbd = new DecoratorBDay(dct);
            MessageBox.Show(dbd.Welcome("Bill"));

            // goal is to do bday decoration first then time decoration

            DecoratorBDay db2 = new DecoratorBDay(ic);
            DecoratorTime dct2 = new DecoratorTime(db2);
            MessageBox.Show(dct2.Welcome("Bill"));
        }
    }
}
