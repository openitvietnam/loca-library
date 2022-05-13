using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LocaLibrary.App.Services;

namespace LocaLibrary.App.Forms
{
    public partial class SelectForm : Form
    {
        public string SelectedId;

        public SelectForm()
        {
            InitializeComponent();
        }

        public DataGridView GetGrid()
        {
            return grid;
        }

        public void LoadAll(string table)
        {
            var sql = @"SELECT * From " + table;
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);

            string error = null;
            var dataTable = DatabaseService.GetDataTable(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            GetGrid().DataSource = dataTable;
            GetGrid().ClearSelection();
        }

        public void Highlight(string id)
        {
            SelectedId = id;
            var grid = GetGrid();
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                if (grid.Rows[i].Cells["Id"].Value.ToString() == id)
                {
                    grid.Rows[i].Selected = true;
                    return;
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (GetGrid().SelectedRows.Count == 0)
            {
                return;
            }
            var row = GetGrid().SelectedRows[0];
            SelectedId = row.Cells["Id"].Value.ToString();
            Close();
        }
    }
}
