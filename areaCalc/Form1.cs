using System;
using System.Windows.Forms;

namespace areaCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        public void AddFoodItem(AreaManager manager)
        {
            foreach (var m in manager.Areas)
            {
                ListViewItem item = new ListViewItem();
                item.Text = m.Name;

                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                subItem.Text = m.AreaValue().ToString();

                item.SubItems.Add(subItem);
                listView.Items.Add(item);

            }
            totalLabel.Text = AreaCalculator.CalculateTotalArea(manager.Areas).ToString();
        }
    }
}
