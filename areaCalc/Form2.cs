using System.Windows.Forms;

namespace areaCalc
{
    public partial class Form2 : Form
    {
        //入力された値を一時保存する
        public BaseArea ResultArea { get; private set; }

        public Form2()
        {
            InitializeComponent();
            squareRadio.Checked = true;
        }

        private void calcButton_Click(object sender, System.EventArgs e)
        {
            if (double.TryParse(inputLength.Text, out double number))
            {
                if (squareRadio.Checked)
                    ResultArea = new Square(number);

                if (triangleRadio.Checked)
                    ResultArea = new Triangle(number);
            }

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
