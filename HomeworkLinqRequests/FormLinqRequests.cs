using HomeworkLinqRequests.ModelDataBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HomeworkLinqRequests
{
    public partial class FormLinqRequests : Form
    {
        private readonly DataBase db;

        public FormLinqRequests()
        {
            InitializeComponent();
            db = new DataBase();
            db.InitStaticDb();
        }

        private void ClearDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
        }

        private void AddDataDataGridView(List<string> data)
        {
            foreach (var item in data)
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void AddRowsDataGridView(List<string[]> data)
        {
            foreach (string[] item in data)
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void ButtonRequestNameOfPlayers_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            AddColumnsDataGridView(new List<(string, string)> { ("PlayerName", "Имя игрока") });
            AddDataDataGridView(Requests.NameOfPlayers(db));
        }

        private void ButtonRequestNameOfPlayersAndNameOfClass_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            AddColumnsDataGridView(new List<(string, string)> { ("PlayerName", "Имя игрока"), ("NameClass", "Название класса") });
            AddRowsDataGridView(Requests.NameOfPlayersAndNameOfClass(db));
        }

        private void AddColumnsDataGridView(List<(string columnName, string headerText)> listColumns)
        {
            foreach((string columnName, string headerText) in listColumns)
            {
                dataGridView1.Columns.Add(columnName, headerText);
            }
        }

        private void ButtonRequestNameOfPlayersAndNameOfSpell_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            AddColumnsDataGridView(new List<(string, string)> { ("PlayerName", "Имя игрока"), ("Skills", "Умения") });
            AddRowsDataGridView(Requests.NameOfPlayersAndNameOfSpell(db));
        }

        private void ButtonRequesNameOfClassAndNameOfSpell_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            AddColumnsDataGridView(new List<(string, string)> { ("NameClass", "Название класса"), ("Skills", "Умения") });
            AddRowsDataGridView(Requests.NameOfClassAndNameOfSpell(db));
        }
    }
}
