namespace TriangleCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s1; int s2; int s3;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                s1 = Convert.ToInt32(textBox1.Text);
                s2 = Convert.ToInt32(textBox2.Text);
                s3 = Convert.ToInt32(textBox3.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введены некорректные значения.\nВо все поля должны быть введены целые числа");
                return;
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Введены некорректные значения.\nВо все поля должны быть введены целые числа не более 2147483647");
                return;
            }
            if (s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1)
            {
                if (s1 == s2 && s1 == s3)
                {
                    MessageBox.Show("Треугольник равносторонний");
                }
                else if (s1 == s2 && s1 != s3 || s2 == s3 && s1 != s3 || s1 == s3 && s1 != s2)
                {
                    MessageBox.Show("Треугольник равнобедренный");
                }
                else
                {
                    MessageBox.Show("Треугольник разносторонний");
                }
            }
            else
            {
                MessageBox.Show("По введённым значениям нельзя построить треугольник");
            }
        }
    }
}
