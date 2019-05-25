using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsDemo
{
    public class IntTextBox : TextBox
    {
        int value = 0;
        public int Value
        {
            get
            {
                return value;
            }
        }
        string prev = "0";
        public IntTextBox()
        {
            Text = "0";
            TextChanged += IntTextBox_TextChanged;
        }
        private void IntTextBox_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(Text, out temp))
            {
                prev = Text;
                value = temp;
            }
            else
            {
                Text = prev;
            }
        }
        public override string ToString()
        {
            return string.Format("NewTextBox {{ Text: {0}; Value: {1}; }}", Text, Value);
        }
        public static implicit operator string(IntTextBox tbc)
        {
            return tbc.ToString();
        }
    }
}