using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private double[] array = new double[2];

        public Form2()
        {
            InitializeComponent();
        }

        string text = "5+2";
        void check()
        {
            var s = text.Split('+');
            foreach (string text in s);
            {
                var number = Int32.Parse(text);
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                string text = textBox1.Text;
                text.Replace(" ","");
                foreach(var symbol in text)
                {
                    
                    try {
                        int number = Int32.Parse(symbol + "");
                        Console.WriteLine(symbol);

                    }
                    catch (FormatException ex)
                    {

                        Console.WriteLine(ex);
                    }
                }
            }
        }
    }
}
