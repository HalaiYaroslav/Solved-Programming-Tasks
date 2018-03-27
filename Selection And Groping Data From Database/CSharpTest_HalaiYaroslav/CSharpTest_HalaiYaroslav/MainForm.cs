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
        private DataSet dataSet = new DataSet(); //This is local storage for data which was selected from database
        private List<DataColumn> columnsNamesPossibleToSum = new List<DataColumn>(); //This lists of columns need to make new CheckBoxes dynamically 
        private List<DataColumn> columnsNamesPossibleToGroup = new List<DataColumn>();//depending on columns that we got from database 

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
                    if (((CheckBox)control).Name == checkBoxName)
                    {
                        seachedCheckBox = control as CheckBox;
                        break;
                    }
                }
            }

            return seachedCheckBox;
        }

        /// <summary>
        /// This method devide columns from datatable to two groups: ToGroup and ToSum
        /// </summary>
        /// <param name="table">Table from where data taking</param>
        private void DivideColumnsNamesToSumAndGroup(DataTable table)
        {
            foreach (DataColumn column in table.Columns)
            {
                if (IsColumnNumericType(column.DataType.Name) && column.ColumnName.ToLower() != "id")
                {
                    columnsNamesPossibleToSum.Add(column);
                }
                else if (!IsColumnNumericType(column.DataType.Name))
                {
                    columnsNamesPossibleToGroup.Add(column);
                }
            }
        }

        /// <summary>
        /// This method says if type is numeric or another
        /// </summary>
        /// <param name="type">String representation of type</param>
        /// <returns>True if type is numeric, otherwise - false</returns>
        private bool IsColumnNumericType(string type)
        {
            for (NumericTypes t = NumericTypes.Byte; t < NumericTypes.UInt64; t++)
            {
                if (type == t.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                var adapter = new SqlDataAdapter(getAllDataQuery, connection);
                adapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];

                DivideColumnsNamesToSumAndGroup(dataSet.Tables[0]);
                BuildCheckBoxesForColumns();

                connection.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BuildCheckBoxesForColumns()
        {
            Control[] checkBoxesToGroup = new Control[0];

            foreach (var toGroupColName in columnsNamesPossibleToGroup)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Name = toGroupColName.ColumnName;
                checkBox.Text = toGroupColName.ColumnName;
                checkBox.Dock = DockStyle.Fill;
                checkBox.CheckStateChanged += CheckBoxesToGroup_CheckStateChanged;

                Array.Resize(ref checkBoxesToGroup, checkBoxesToGroup.Length + 1);
                checkBoxesToGroup[checkBoxesToGroup.Length - 1] = checkBox;
            }

            Control[] checkBoxesToSum = new Control[0];

            foreach (var toSumColName in columnsNamesPossibleToSum)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Name = toSumColName.ColumnName;
                checkBox.Text = toSumColName.ColumnName;
                checkBox.CheckStateChanged += CheckBoxesToSum_CheckStateChanged;

                Array.Resize(ref checkBoxesToSum, checkBoxesToSum.Length + 1);
                checkBoxesToSum[checkBoxesToSum.Length - 1] = checkBox;
            }

            checkBoxesToGroupLT.Controls.AddRange(checkBoxesToGroup);
            checkBoxesToSumLT.Controls.AddRange(checkBoxesToSum);
        }

        private void displayAllDataBtn_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = dataSet.Tables[0];
        }

        private void getResultsBtn_Click(object sender, EventArgs e)
        {
            #region Old Working Verison            
            byte columnCount = (byte)resultColumnsToGroupList.Items.Count;

            if (columnCount > 0)
            {
                dataGridView.Columns.Clear();
                dataGridView.DataSource = null;

                List<string> colNames = new List<string>();
                foreach (var item in resultColumnsToGroupList.Items)
                {
                    colNames.Add(item.ToString());
                }

                switch (columnCount)
                {
                    case 1:
                        dataGridView.DataSource = LINQer.GetTable(dataSet, colNames[0]);
                        break;
                    case 2:
                        dataGridView.DataSource = LINQer.GetTable(dataSet, colNames[0], colNames[1]);
                        break;
                    case 3:
                        dataGridView.DataSource = LINQer.GetTable(dataSet, colNames[0], colNames[1], colNames[2]);
                        break;
                    case 4:
                        dataGridView.DataSource = LINQer.GetTable(dataSet, colNames[0], colNames[1], colNames[2], colNames[3]);
                        break;
                    case 5:
                        dataGridView.DataSource = LINQer.GetTable(dataSet, colNames[0], colNames[1], colNames[2], colNames[3], colNames[4]);
                        break;
                    default:
                        MessageBox.Show("Something went wrong in the switch statment.");
                        dataGridView.DataSource = dataSet.Tables[0];
                        break;
                }
            }
            else
            {
                MessageBox.Show("Choose at least one column to be able to Get Results.");
            }
            #endregion

            #region New Not Working Version
            //byte columnToGroupCount = (byte)resultColumnsToGroupList.Items.Count;
            //byte columnToSumCount = (byte)resultColumnsToSumList.Items.Count;

            //if (columnToGroupCount > 0 && columnToSumCount > 0)
            //{
            //    dataGridView.Columns.Clear();
            //    dataGridView.DataSource = null;

            //    List<string> columnsToGroup = new List<string>();
            //    foreach (string columnName in resultColumnsToGroupList.Items)
            //    {
            //        foreach (DataColumn column in columnsNamesPossibleToGroup)
            //        {
            //            if (columnName == column.ColumnName)
            //            {
            //                columnsToGroup.Add(column.ToString());
            //            }
            //        }
            //    }

            //    List<string> columnsToSum = new List<string>();
            //    foreach (string columnName in resultColumnsToSumList.Items)
            //    {
            //        foreach (DataColumn column in columnsNamesPossibleToSum)
            //        {
            //            if (columnName == column.ColumnName)
            //            {
            //                columnsToSum.Add(column.ToString());
            //            }
            //        }
            //    }

            //    //dataGridView.DataSource = null;
            //    //dataGridView.DataSource = LINQer.GetTable(dataSet.Tables[0], columnsToGroup, columnsToSum);
            //}
            //else
            //{
            //    MessageBox.Show("Choose at least one column to Sum and To Group to be able Get Results.");
            //}
            #endregion
        }

        private void DataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn selectedColumn = dataGridView.Columns[e.ColumnIndex];
            if (selectionModeToGroup.Checked)
            {
                if (resultColumnsToGroupList.Items.Contains(selectedColumn.Name) || selectedColumn.Name.ToLower() == "id" || IsColumnNumericType(selectedColumn.ValueType.Name))
                {
                    return;
                }
                else
                {
                    GetCheckBox(selectedColumn.Name, checkBoxesToGroupLT).CheckState = CheckState.Checked;
                }
            }
            else if (selectionModeToSum.Checked)
            {
                if (resultColumnsToSumList.Items.Contains(selectedColumn.Name) || selectedColumn.Name.ToLower() == "id" || !IsColumnNumericType(selectedColumn.ValueType.Name))
                {
                    return;
                }
                else
                {
                    GetCheckBox(selectedColumn.Name, checkBoxesToSumLT).CheckState = CheckState.Checked;
                }
            }
            else
            {
                MessageBox.Show("Choose selection mode!");
            }
        }

        private void CheckBoxesToGroup_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox checkedBox = sender as CheckBox;

            if (checkedBox.Checked && resultColumnsToGroupList.Items.Contains(checkedBox.Name) != true)
            {
                resultColumnsToGroupList.Items.Add(checkedBox.Name);
            }
            else
            {
                resultColumnsToGroupList.Items.Remove(checkedBox.Name);
            }
        }

        private void CheckBoxesToSum_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox checkedBox = sender as CheckBox;

            if (checkedBox.Checked && resultColumnsToSumList.Items.Contains(checkedBox.Name) != true)
            {
                resultColumnsToSumList.Items.Add(checkedBox.Name);
            }
            else
            {
                resultColumnsToSumList.Items.Remove(checkedBox.Name);
            }
        }
    }
}
