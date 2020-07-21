namespace AddBenfits
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label الكتابLabel;
            System.Windows.Forms.Label الفائدةLabel;
            System.Windows.Forms.Label الصفحةLabel;
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet = new AddBenfits.Database2DataSet();
            this.database2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wordsTableAdapter = new AddBenfits.Database2DataSetTableAdapters.wordsTableAdapter();
            this.wordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new AddBenfits.Database2DataSetTableAdapters.TableAdapterManager();
            this.الكتابTextBox = new System.Windows.Forms.TextBox();
            this.الفائدةTextBox = new System.Windows.Forms.TextBox();
            this.الصفحةTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wordsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.الكتابDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الفائدةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الصفحةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            الكتابLabel = new System.Windows.Forms.Label();
            الفائدةLabel = new System.Windows.Forms.Label();
            الصفحةLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "words";
            this.wordsBindingSource.DataSource = this.database2DataSetBindingSource;
            // 
            // database2DataSetBindingSource
            // 
            this.database2DataSetBindingSource.DataSource = this.database2DataSet;
            this.database2DataSetBindingSource.Position = 0;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database2DataSetBindingSource1
            // 
            this.database2DataSetBindingSource1.DataSource = this.database2DataSet;
            this.database2DataSetBindingSource1.Position = 0;
            // 
            // wordsTableAdapter
            // 
            this.wordsTableAdapter.ClearBeforeFill = true;
            // 
            // wordsBindingSource1
            // 
            this.wordsBindingSource1.DataMember = "words";
            this.wordsBindingSource1.DataSource = this.database2DataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AddBenfits.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.wordsTableAdapter = this.wordsTableAdapter;
            // 
            // الكتابLabel
            // 
            الكتابLabel.AutoSize = true;
            الكتابLabel.Location = new System.Drawing.Point(338, 134);
            الكتابLabel.Name = "الكتابLabel";
            الكتابLabel.Size = new System.Drawing.Size(57, 19);
            الكتابLabel.TabIndex = 4;
            الكتابLabel.Text = "الكتاب:";
            // 
            // الكتابTextBox
            // 
            this.الكتابTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wordsBindingSource1, "الكتاب", true));
            this.الكتابTextBox.Location = new System.Drawing.Point(408, 131);
            this.الكتابTextBox.Name = "الكتابTextBox";
            this.الكتابTextBox.Size = new System.Drawing.Size(100, 27);
            this.الكتابTextBox.TabIndex = 5;
            // 
            // الفائدةLabel
            // 
            الفائدةLabel.AutoSize = true;
            الفائدةLabel.Location = new System.Drawing.Point(338, 167);
            الفائدةLabel.Name = "الفائدةLabel";
            الفائدةLabel.Size = new System.Drawing.Size(58, 19);
            الفائدةLabel.TabIndex = 6;
            الفائدةLabel.Text = "الفائدة:";
            // 
            // الفائدةTextBox
            // 
            this.الفائدةTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wordsBindingSource1, "الفائدة", true));
            this.الفائدةTextBox.Location = new System.Drawing.Point(408, 164);
            this.الفائدةTextBox.Name = "الفائدةTextBox";
            this.الفائدةTextBox.Size = new System.Drawing.Size(100, 27);
            this.الفائدةTextBox.TabIndex = 7;
            // 
            // الصفحةLabel
            // 
            الصفحةLabel.AutoSize = true;
            الصفحةLabel.Location = new System.Drawing.Point(338, 200);
            الصفحةLabel.Name = "الصفحةLabel";
            الصفحةLabel.Size = new System.Drawing.Size(64, 19);
            الصفحةLabel.TabIndex = 8;
            الصفحةLabel.Text = "الصفحة:";
            // 
            // الصفحةTextBox
            // 
            this.الصفحةTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wordsBindingSource1, "الصفحة", true));
            this.الصفحةTextBox.Location = new System.Drawing.Point(408, 197);
            this.الصفحةTextBox.Name = "الصفحةTextBox";
            this.الصفحةTextBox.Size = new System.Drawing.Size(100, 27);
            this.الصفحةTextBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.الكتابDataGridViewTextBoxColumn,
            this.الفائدةDataGridViewTextBoxColumn,
            this.الصفحةDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wordsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(65, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(679, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // wordsBindingSource2
            // 
            this.wordsBindingSource2.DataMember = "words";
            this.wordsBindingSource2.DataSource = this.database2DataSetBindingSource1;
            // 
            // الكتابDataGridViewTextBoxColumn
            // 
            this.الكتابDataGridViewTextBoxColumn.DataPropertyName = "الكتاب";
            this.الكتابDataGridViewTextBoxColumn.HeaderText = "الكتاب";
            this.الكتابDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.الكتابDataGridViewTextBoxColumn.Name = "الكتابDataGridViewTextBoxColumn";
            this.الكتابDataGridViewTextBoxColumn.ReadOnly = true;
            this.الكتابDataGridViewTextBoxColumn.Width = 150;
            // 
            // الفائدةDataGridViewTextBoxColumn
            // 
            this.الفائدةDataGridViewTextBoxColumn.DataPropertyName = "الفائدة";
            this.الفائدةDataGridViewTextBoxColumn.HeaderText = "الفائدة";
            this.الفائدةDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.الفائدةDataGridViewTextBoxColumn.Name = "الفائدةDataGridViewTextBoxColumn";
            this.الفائدةDataGridViewTextBoxColumn.ReadOnly = true;
            this.الفائدةDataGridViewTextBoxColumn.Width = 150;
            // 
            // الصفحةDataGridViewTextBoxColumn
            // 
            this.الصفحةDataGridViewTextBoxColumn.DataPropertyName = "الصفحة";
            this.الصفحةDataGridViewTextBoxColumn.HeaderText = "الصفحة";
            this.الصفحةDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.الصفحةDataGridViewTextBoxColumn.Name = "الصفحةDataGridViewTextBoxColumn";
            this.الصفحةDataGridViewTextBoxColumn.ReadOnly = true;
            this.الصفحةDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(الكتابLabel);
            this.Controls.Add(this.الكتابTextBox);
            this.Controls.Add(الفائدةLabel);
            this.Controls.Add(this.الفائدةTextBox);
            this.Controls.Add(الصفحةLabel);
            this.Controls.Add(this.الصفحةTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource database2DataSetBindingSource;
        private System.Windows.Forms.BindingSource database2DataSetBindingSource1;
        private System.Windows.Forms.BindingSource wordsBindingSource;
        private Database2DataSetTableAdapters.wordsTableAdapter wordsTableAdapter;
        private System.Windows.Forms.BindingSource wordsBindingSource1;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox الكتابTextBox;
        private System.Windows.Forms.TextBox الفائدةTextBox;
        private System.Windows.Forms.TextBox الصفحةTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn الكتابDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الفائدةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الصفحةDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wordsBindingSource2;
    }
}

