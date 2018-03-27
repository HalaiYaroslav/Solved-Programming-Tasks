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
            this.columnsToGroupGB = new System.Windows.Forms.GroupBox();
            this.resultColumnsToGroupList = new System.Windows.Forms.ListBox();
            this.displayAllDataBtn = new System.Windows.Forms.Button();
            this.resultColumnsToSumList = new System.Windows.Forms.ListBox();
            this.columnsToSumGB = new System.Windows.Forms.GroupBox();
            this.checkBoxesToGroupLT = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxesToSumLT = new System.Windows.Forms.TableLayoutPanel();
            this.selectionModeToSum = new System.Windows.Forms.RadioButton();
            this.selectionModeToGroup = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.columnsToGroupGB.SuspendLayout();
            this.columnsToSumGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.getResultsBtn.Location = new System.Drawing.Point(456, 407);
            this.getResultsBtn.Name = "getResultsBtn";
            this.getResultsBtn.Size = new System.Drawing.Size(359, 35);
            this.getResultsBtn.TabIndex = 1;
            this.getResultsBtn.Text = "Get Results";
            this.getResultsBtn.UseVisualStyleBackColor = true;
            this.getResultsBtn.Click += new System.EventHandler(this.getResultsBtn_Click);
            // 
            // columnsToGroupGB
            // 
            this.columnsToGroupGB.Controls.Add(this.checkBoxesToGroupLT);
            this.columnsToGroupGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnsToGroupGB.Location = new System.Drawing.Point(11, 285);
            this.columnsToGroupGB.Name = "columnsToGroupGB";
            this.columnsToGroupGB.Size = new System.Drawing.Size(439, 129);
            this.columnsToGroupGB.TabIndex = 4;
            this.columnsToGroupGB.TabStop = false;
            this.columnsToGroupGB.Text = "Columns to Group:";
            // 
            // resultColumnsToGroupList
            // 
            this.resultColumnsToGroupList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultColumnsToGroupList.FormattingEnabled = true;
            this.resultColumnsToGroupList.ItemHeight = 16;
            this.resultColumnsToGroupList.Location = new System.Drawing.Point(456, 285);
            this.resultColumnsToGroupList.Name = "resultColumnsToGroupList";
            this.resultColumnsToGroupList.Size = new System.Drawing.Size(361, 116);
            this.resultColumnsToGroupList.TabIndex = 10;
            // 
            // displayAllDataBtn
            // 
            this.displayAllDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displayAllDataBtn.Location = new System.Drawing.Point(501, 12);
            this.displayAllDataBtn.Name = "displayAllDataBtn";
            this.displayAllDataBtn.Size = new System.Drawing.Size(314, 33);
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
            this.resultColumnsToSumList.Location = new System.Drawing.Point(456, 449);
            this.resultColumnsToSumList.Name = "resultColumnsToSumList";
            this.resultColumnsToSumList.Size = new System.Drawing.Size(361, 100);
            this.resultColumnsToSumList.TabIndex = 14;
            // 
            // columnsToSumGB
            // 
            this.columnsToSumGB.Controls.Add(this.checkBoxesToSumLT);
            this.columnsToSumGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnsToSumGB.Location = new System.Drawing.Point(11, 430);
            this.columnsToSumGB.Name = "columnsToSumGB";
            this.columnsToSumGB.Size = new System.Drawing.Size(439, 119);
            this.columnsToSumGB.TabIndex = 13;
            this.columnsToSumGB.TabStop = false;
            this.columnsToSumGB.Text = "Columns to Sum:";
            // 
            // checkBoxesToGroupLT
            // 
            this.checkBoxesToGroupLT.ColumnCount = 4;
            this.checkBoxesToGroupLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.46296F));
            this.checkBoxesToGroupLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.53704F));
            this.checkBoxesToGroupLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.checkBoxesToGroupLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.checkBoxesToGroupLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxesToGroupLT.Location = new System.Drawing.Point(3, 19);
            this.checkBoxesToGroupLT.Name = "checkBoxesToGroupLT";
            this.checkBoxesToGroupLT.RowCount = 3;
            this.checkBoxesToGroupLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.checkBoxesToGroupLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.checkBoxesToGroupLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.checkBoxesToGroupLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.checkBoxesToGroupLT.Size = new System.Drawing.Size(433, 107);
            this.checkBoxesToGroupLT.TabIndex = 0;
            // 
            // checkBoxesToSumLT
            // 
            this.checkBoxesToSumLT.ColumnCount = 4;
            this.checkBoxesToSumLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.78166F));
            this.checkBoxesToSumLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.21834F));
            this.checkBoxesToSumLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.checkBoxesToSumLT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.checkBoxesToSumLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxesToSumLT.Location = new System.Drawing.Point(3, 19);
            this.checkBoxesToSumLT.Name = "checkBoxesToSumLT";
            this.checkBoxesToSumLT.RowCount = 3;
            this.checkBoxesToSumLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.77612F));
            this.checkBoxesToSumLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.22388F));
            this.checkBoxesToSumLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.checkBoxesToSumLT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.checkBoxesToSumLT.Size = new System.Drawing.Size(433, 97);
            this.checkBoxesToSumLT.TabIndex = 1;
            // 
            // selectionModeToSum
            // 
            this.selectionModeToSum.AutoSize = true;
            this.selectionModeToSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectionModeToSum.Location = new System.Drawing.Point(153, 19);
            this.selectionModeToSum.Name = "selectionModeToSum";
            this.selectionModeToSum.Size = new System.Drawing.Size(133, 17);
            this.selectionModeToSum.TabIndex = 15;
            this.selectionModeToSum.TabStop = true;
            this.selectionModeToSum.Text = "Select Column To Sum";
            this.selectionModeToSum.UseVisualStyleBackColor = true;
            // 
            // selectionModeToGroup
            // 
            this.selectionModeToGroup.AutoSize = true;
            this.selectionModeToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectionModeToGroup.Location = new System.Drawing.Point(6, 19);
            this.selectionModeToGroup.Name = "selectionModeToGroup";
            this.selectionModeToGroup.Size = new System.Drawing.Size(141, 17);
            this.selectionModeToGroup.TabIndex = 16;
            this.selectionModeToGroup.TabStop = true;
            this.selectionModeToGroup.Text = "Select Column To Group";
            this.selectionModeToGroup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectionModeToSum);
            this.groupBox1.Controls.Add(this.selectionModeToGroup);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 46);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection Mode By Table Headers";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultColumnsToSumList);
            this.Controls.Add(this.columnsToSumGB);
            this.Controls.Add(this.getResultsBtn);
            this.Controls.Add(this.resultColumnsToGroupList);
            this.Controls.Add(this.displayAllDataBtn);
            this.Controls.Add(this.columnsToGroupGB);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.columnsToGroupGB.ResumeLayout(false);
            this.columnsToSumGB.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button getResultsBtn;
        private System.Windows.Forms.GroupBox columnsToGroupGB;
        private System.Windows.Forms.Button displayAllDataBtn;
        private System.Windows.Forms.ListBox resultColumnsToGroupList;
        private System.Windows.Forms.ListBox resultColumnsToSumList;
        private System.Windows.Forms.GroupBox columnsToSumGB;
        private System.Windows.Forms.TableLayoutPanel checkBoxesToGroupLT;
        private System.Windows.Forms.TableLayoutPanel checkBoxesToSumLT;
        private System.Windows.Forms.RadioButton selectionModeToSum;
        private System.Windows.Forms.RadioButton selectionModeToGroup;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

