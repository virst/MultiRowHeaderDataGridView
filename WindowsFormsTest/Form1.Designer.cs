namespace WindowsFormsTest
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.multiRowHeaderDataGridView1 = new MultiDataGridView.MultiRowHeaderDataGridView();
            this.demoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.multiRowHeaderDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // multiRowHeaderDataGridView1
            // 
            this.multiRowHeaderDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiRowHeaderDataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.multiRowHeaderDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.multiRowHeaderDataGridView1.ColumnHeadersHeight = 84;
            this.multiRowHeaderDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.multiRowHeaderDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.gDataGridViewTextBoxColumn,
            this.zDataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn});
            this.multiRowHeaderDataGridView1.DataSource = this.demoTableBindingSource;
            this.multiRowHeaderDataGridView1.Location = new System.Drawing.Point(12, 12);
            this.multiRowHeaderDataGridView1.Name = "multiRowHeaderDataGridView1";
            this.multiRowHeaderDataGridView1.ReadOnly = true;
            this.multiRowHeaderDataGridView1.Size = new System.Drawing.Size(634, 372);
            this.multiRowHeaderDataGridView1.TabIndex = 0;
            // 
            // demoTableBindingSource
            // 
            this.demoTableBindingSource.DataMember = "DemoTable";
            this.demoTableBindingSource.DataSource = typeof(WindowsFormsTest.DemoDataSet);
            this.demoTableBindingSource.Position = 0;
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "A";
            this.aDataGridViewTextBoxColumn.HeaderText = "A";
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            this.aDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "H|B|C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gDataGridViewTextBoxColumn
            // 
            this.gDataGridViewTextBoxColumn.DataPropertyName = "G";
            this.gDataGridViewTextBoxColumn.HeaderText = "H|D|E|G";
            this.gDataGridViewTextBoxColumn.Name = "gDataGridViewTextBoxColumn";
            this.gDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zDataGridViewTextBoxColumn
            // 
            this.zDataGridViewTextBoxColumn.DataPropertyName = "Z";
            this.zDataGridViewTextBoxColumn.HeaderText = "H|D|E|Z";
            this.zDataGridViewTextBoxColumn.Name = "zDataGridViewTextBoxColumn";
            this.zDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "T";
            this.tDataGridViewTextBoxColumn.HeaderText = "H|D|T";
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            this.tDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 396);
            this.Controls.Add(this.multiRowHeaderDataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.multiRowHeaderDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MultiDataGridView.MultiRowHeaderDataGridView multiRowHeaderDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource demoTableBindingSource;
    }
}

