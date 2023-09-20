namespace Lab_2_2winform
{
    public partial class Form1 : Form
    {
        private Ar arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vbr = int.Parse(textBox1.Text);

            if (vbr == 1)
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                arr = new Ar(a, b);
            }
            else if (vbr == 2)
            {
                string fileName = textBox4.Text;
                arr = new Ar(fileName);
            }
            else
            {
                MessageBox.Show("����������� ������� �����������");
                return;
            }

            label1.Text = $"������: {string.Join(" ", arr.GetArray())}";
            label2.Text = $"ʳ������ ��������, �� ����������� �� 1:{arr.K}";
            label3.Text = $"������ ���������� �����:{arr.Min()}";

            if (arr.Min() != 0)
            {
                int sum = arr.Sum(0, arr.Min() - 1);
                label4.Text = $"���� ��� �������� ���� �� ����������:{sum}";
            }
            else
            {
                label3.Text = "̳�������� ������� ������";
            }
        }
    }
}
