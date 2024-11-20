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
                MessageBox.Show("������� ������������ ��������.\n�� ��� ���� ������ ���� ������� ����� �����");
                return;
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("������� ������������ ��������.\n�� ��� ���� ������ ���� ������� ����� ����� �� ����� 2147483647");
                return;
            }
            if (s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1)
            {
                if (s1 == s2 && s1 == s3)
                {
                    MessageBox.Show("����������� ��������������");
                }
                else if (s1 == s2 && s1 != s3 || s2 == s3 && s1 != s3 || s1 == s3 && s1 != s2)
                {
                    MessageBox.Show("����������� ��������������");
                }
                else
                {
                    MessageBox.Show("����������� ��������������");
                }
            }
            else
            {
                MessageBox.Show("�� �������� ��������� ������ ��������� �����������");
            }
        }
    }
}
