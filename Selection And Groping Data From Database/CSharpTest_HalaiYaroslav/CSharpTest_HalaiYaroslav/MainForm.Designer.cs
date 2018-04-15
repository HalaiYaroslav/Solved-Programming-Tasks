namespace CSharpTest_HalaiYaroslav
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.getResultsBtn = new System.Windows.Forms.Button();
            this.columnsGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBoxesLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.resultColumnsToGroupList = new System.Windows.Forms.ListBox();
            this.displayAllDataBtn = new System.Windows.Forms.Button();
            this.resultColumnsToSumList = new System.Windows.Forms.ListBox();
            this.removeColumnToGroup = new System.Windows.Forms.Button();
            this.removeColumnToSum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.columnsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 57);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(803, 222);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_ColumnHeaderMouseClick);
            // 
            // getResultsBtn
            // 
            this.getResultsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getResultsBtn.Location = new System.Drawing.Point(457, 296);
            this.getResultsBtn.Name = "getResultsBtn";
            this.getResultsBtn.Size = new System.Drawing.Size(358, 35);
            this.getResultsBtn.TabIndex = 1;
            this.getResultsBtn.Text = "Get Results";
            this.getResultsBtn.UseVisualStyleBackColor = true;
            this.getResultsBtn.Click += new System.EventHandler(this.getResultsBtn_Click);
            // 
            // columnsGroupBox
            // 
            this.columnsGroupBox.Controls.Add(this.checkBoxesLayoutTable);
            this.columnsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnsGroupBox.Location = new System.Drawing.Point(11, 285);
            this.columnsGroupBox.Name = "columnsGroupBox";
            this.columnsGroupBox.Size = new System.Drawing.Size(437, 264);
            this.columnsGroupBox.TabIndex = 4;
            this.columnsGroupBox.TabStop = false;
            this.columnsGroupBox.Text = "Select columns:";
            // 
            // checkBoxesLayoutTable
            // 
            this.checkBoxesLayoutTable.ColumnCount = 4;
            this.checkBoxesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.checkBoxesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.checkBoxesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.checkBoxesLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.checkBoxesLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxesLayoutTable.Location = new System.Drawing.Point(3, 19);
            this.checkBoxesLayoutTable.Name = "checkBoxesLayoutTable";
            this.checkBoxesLayoutTable.RowCount = 3;
            this.checkBoxesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.checkBoxesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.checkBoxesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.checkBoxesLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.checkBoxesLayoutTable.Size = new System.Drawing.Size(431, 242);
            this.checkBoxesLayoutTable.TabIndex = 0;
            // 
            // resultColumnsToGroupList
            // 
            this.resultColumnsToGroupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultColumnsToGroupList.FormattingEnabled = true;
            this.resultColumnsToGroupList.ItemHeight = 16;
            this.resultColumnsToGroupList.Location = new System.Drawing.Point(457, 350);
            this.resultColumnsToGroupList.Name = "resultColumnsToGroupList";
            this.resultColumnsToGroupList.Size = new System.Drawing.Size(176, 164);
            this.resultColumnsToGroupList.TabIndex = 10;
            // 
            // displayAllDataBtn
            // 
            this.displayAllDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayAllDataBtn.Location = new System.Drawing.Point(12, 12);
            this.displayAllDataBtn.Name = "displayAllDataBtn";
            this.displayAllDataBtn.Size = new System.Drawing.Size(803, 33);
            this.displayAllDataBtn.TabIndex = 9;
            this.displayAllDataBtn.Text = "Display All Data";
            this.displayAllDataBtn.UseVisualStyleBackColor = true;
            this.displayAllDataBtn.Click += new System.EventHandler(this.displayAllDataBtn_Click);
            // 
            // resultColumnsToSumList
            // 
            this.resultColumnsToSumList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultColumnsToSumList.FormattingEnabled = true;
            this.resultColumnsToSumList.ItemHeight = 16;
            this.resultColumnsToSumList.Location = new System.Drawing.Point(639, 350);
            this.resultColumnsToSumList.Name = "resultColumnsToSumList";
            this.resultColumnsToSumList.Size = new System.Drawing.Size(176, 164);
            this.resultColumnsToSumList.TabIndex = 14;
            // 
            // removeColumnToGroup
            // 
            this.removeColumnToGroup.Location = new System.Drawing.Point(457, 520);
            this.removeColumnToGroup.Name = "removeColumnToGroup";
            this.removeColumnToGroup.Size = new System.Drawing.Size(176, 29);
            this.removeColumnToGroup.TabIndex = 16;
            this.removeColumnToGroup.Text = "Remove";
            this.removeColumnToGroup.UseVisualStyleBackColor = true;
            this.removeColumnToGroup.Click += new System.EventHandler(this.removeColumnToGroup_Click);
            // 
            // removeColumnToSum
            // 
            this.removeColumnToSum.Location = new System.Drawing.Point(639, 520);
            this.removeColumnToSum.Name = "removeColumnToSum";
            this.removeColumnToSum.Size = new System.Drawing.Size(176, 29);
            this.removeColumnToSum.TabIndex = 17;
            this.removeColumnToSum.Text = "Remove";
            this.removeColumnToSum.UseVisualStyleBackColor = true;
            this.removeColumnToSum.Click += new System.EventHandler(this.removeColumnToSum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Columns to group:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Columns to sum:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeColumnToSum);
            this.Controls.Add(this.removeColumnToGroup);
            this.Controls.Add(this.resultColumnsToSumList);
            this.Controls.Add(this.getResultsBtn);
            this.Controls.Add(this.resultColumnsToGroupList);
            this.Controls.Add(this.displayAllDataBtn);
            this.Controls.Add(this.columnsGroupBox);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.columnsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button getResultsBtn;
        private System.Windows.Forms.GroupBox columnsGroupBox;
        private System.Windows.Forms.Button displayAllDataBtn;
        private System.Windows.Forms.ListBox resultColumnsToGroupList;
        private System.Windows.Forms.ListBox resultColumnsToSumList;
        private System.Windows.Forms.TableLayoutPanel checkBoxesLayoutTable;
        private System.Windows.Forms.Button removeColumnToGroup;
        private System.Windows.Forms.Button removeColumnToSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

