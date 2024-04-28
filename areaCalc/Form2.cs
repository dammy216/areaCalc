using System.Windows.Forms;

namespace areaCalc
{
    public partial class Form2 : Form
    {
        private AreaManager areaManager = new AreaManager();

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
                    areaManager.Add(new Square(number));

                if (circleRadio.Checked)
                    areaManager.Add(new Circle(number));
            }

            Form1 form = new Form1();  // 新しいForm1インスタンスを作成
            form.AddFoodItem(areaManager);
            form.ShowDialog();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
