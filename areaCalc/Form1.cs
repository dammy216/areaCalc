using System;
using System.Windows.Forms;

namespace areaCalc
{
    public partial class Form1 : Form
    {
        private AreaManager _areaManager = new AreaManager();
        public Form1()
        {
            InitializeComponent();
            LoadCsv();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                var area = form2.ResultArea;
                _areaManager.Add(area); //本当のモデルに追加
                UpdateListView();
            }
        }

        //リストビューの更新
        public void UpdateListView()
        {
            listView.Items.Clear();
            foreach (var area in _areaManager.Areas)
            {
                //リストビューの項目数とstring配列の長さが同じであればそのまま表示できる
                ListViewItem item = new ListViewItem(_areaManager.GetListViewItem(area));  //表示用のリストでリストビューを作成
                listView.Items.Add(item);
            }
            totalLabel.Text = $"TotalArea:{AreaCalculator.CalculateTotalArea(listView).ToString()}";
        }

        //丸める処理
        public void decimalButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(RoundInput.Text, out int digit) && digit <= 15)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    if (item.SubItems.Count > 0)
                    {
                        var area = _areaManager.Areas[item.Index];
                        //モデルの値で丸めているので、桁で2を選んだ後も3で丸める計算を再度行える
                        string roundedArea = _areaManager.RoundDecimal(area.AreaValue(), digit);    //rounddecimalがstringを返すからstringに渡す

                        item.SubItems[1].Text = roundedArea;
                    }
                }
                totalLabel.Text = _areaManager.RoundDecimal(AreaCalculator.CalculateTotalArea(listView), digit);
            }
        }

        //編集
        private void editButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = listView.SelectedItems[0].Index;

            Form2 form2 = new Form2(_areaManager.GetArea(selectedIndex));
            if (form2.ShowDialog() == DialogResult.OK)
            {
                var area = form2.ResultArea;
                _areaManager.Edit(selectedIndex, area); //本当のモデルに追加
                UpdateListView();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCsv();
        }

        private void LoadCsv()
        {
            _areaManager.LoadFromCsv("D:\\Programing\\C#\\CSharpTutorial\\areaCalc\\dummy.csv");
            UpdateListView();
        }

        private void SaveCsv()
        {
            _areaManager.SaveToCsv("D:\\Programing\\C#\\CSharpTutorial\\areaCalc\\dummy.csv");
        }
    }
}
