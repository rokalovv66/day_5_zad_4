namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expression = richTextBox1.Text;
            int parenthesesBalance = 0;

            foreach (char c in expression)
            {
                if (c == '(')
                {
                    parenthesesBalance++;
                }
                else if (c == ')')
                {
                    parenthesesBalance--;
                }
                if (parenthesesBalance < 0)
                {
                    MessageBox.Show("Неправильное расположение скобок");
                    return;
                }
            }

            if (parenthesesBalance == 0)
            {
                MessageBox.Show("Скобки расставлены правильно");
            }
            else
            {
                MessageBox.Show("Неправильное расположение скобок");
            }
        }
    }
}
 