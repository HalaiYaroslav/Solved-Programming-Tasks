using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace CSharpTest_HalaiYaroslav
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private const string getAllDataQuery = "SELECT * FROM OrganizationInfo";
        private DataTable dataTable = new DataTable(); //This is local storage for data which was selected from database       

        /// <summary>
        /// This method gets searched checkbox by name and layouttable name
        /// </summary>
        /// <param name="checkBoxName">Name of searched checkbox</param>
        /// <param name="tableLayout">Name of layouttable where is providing search</param>
        /// <returns>Searched checkbox</returns>
        private CheckBox GetCheckBox(string checkBoxName, TableLayoutPanel tableLayout)
        {
            CheckBox seachedCheckBox = null;

            foreach (Control control in tableLayout.Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Text == checkBoxName)
                    {
                        seachedCheckBox = control as CheckBox;
                        break;
                    }
                }
            }

            return seachedCheckBox;
        }

        private bool IsNumeric(string type)
        {
            for (NumericTypes t = NumericTypes.Byte; t < NumericTypes.UInt64; t++)
            {
                if(t.ToString() == type)
                {
                    return true;
                }                
            }

            return false;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataTable = GetDataTable(getAllDataQuery);

            dataGridView.DataSource = dataTable;            

            BuildCheckBoxesForColumns();
        }

        private DataTable GetDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        private void BuildCheckBoxesForColumns()
        {
            List<Control> checkBoxes = new List<Control>();

            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.ColumnName.ToLower() != "id")
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Name = IsNumeric(column.DataType.Name) ? $"Numeric-{column.ColumnName}" : $"NotNumeric-{column.ColumnName}";
                    checkBox.Text = column.ColumnName;                    
                    checkBox.Dock = DockStyle.Fill;
                    checkBox.CheckStateChanged += CheckBoxes_CheckStateChanged;

                    checkBoxes.Add(checkBox);
                }
            }

            checkBoxesLayoutTable.Controls.AddRange(checkBoxes.ToArray());
        }

        private void displayAllDataBtn_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = dataTable;
        }

        private void getResultsBtn_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn selectedColumn = dataGridView.Columns[e.ColumnIndex];

            if (IsNumeric(selectedColumn.ValueType.Name) && selectedColumn.Name.ToLower() != "id")
            {
                resultColumnsToSumList.Items.Add(selectedColumn.Name);
            }
            else if(!IsNumeric(selectedColumn.ValueType.Name))
            {
                resultColumnsToGroupList.Items.Add(selectedColumn.Name);
            }
        }

        private void CheckBoxes_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            string type = checkBox.Name.Split('-')[0];
            string name = checkBox.Name.Split('-')[1];

            if (type == "Numeric" && name.ToLower() != "id")
            {
                resultColumnsToSumList.Items.Add(name);
            }
            else if (type == "NotNumeric")
            {
                resultColumnsToGroupList.Items.Add(name);
            }
        }

        private void removeColumnToGroup_Click(object sender, EventArgs e)
        {
            object selectedItem = resultColumnsToGroupList.SelectedItem;

            if (selectedItem != null)
            {
                GetCheckBox(selectedItem.ToString(), checkBoxesLayoutTable).Checked = false;
                resultColumnsToGroupList.Items.Remove(selectedItem);
            }
        }

        private void removeColumnToSum_Click(object sender, EventArgs e)
        {

        }
    }
}
