using System.Linq;

namespace TPlay
{
    public partial class Form1 : Form
    {
        string input;
        string output;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            input = txtInput.Text;
            //1st option
            output =  Reverse(input);
            //2nd option
            //output = ReverseXor(input);
            txtOutput.Text = output;
        }

        /// <summary>
        /// first develop a method to reverse the string input
        /// and return the result.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Reverse( string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// As the initial method only works on utf16 and not utf32
        ///create a second method that will accept strings with 
        ///for example French accents.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseXor(string s)
        {
            if (s == null) return null;
            char[] charArray = s.ToCharArray();
            int len = s.Length - 1;

            for (int i = 0; i < len; i++, len--)
            {
                charArray[i] ^= charArray[len];
                charArray[len] ^= charArray[i];
                charArray[i] ^= charArray[len];
            }

            return new string(charArray);
        }
    }
}