using System.Windows.Forms;

namespace areaCalc
{
    public partial class Form2 : Form
    {
        //入力された値を一時保存する
        public BaseArea ResultArea { get; private set; }

        public Form2() : this(null)
        {

        }

        public Form2(BaseArea area)
        {
            InitializeComponent();

            if (area == null)
            {
                squareRadio.Checked = true;
                triangleRadio.Checked = false;
            }

            switch (area)
            {
                case Square square:
                    squareRadio.Checked = true;
                    inputLength.Text = square.Length.ToString();
                    break;

                case Triangle triangle:
                    triangleRadio.Checked = true;
                    inputLength.Text = triangle.Length.ToString();
                    break;
            }
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
