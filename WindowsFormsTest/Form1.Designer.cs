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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.multiRowHeaderDataGridView1 = new MultiDataGridView.MultiRowHeaderDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.multiRowHeaderDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // multiRowHeaderDataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.multiRowHeaderDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.multiRowHeaderDataGridView1.ColumnHeadersHeight = 18;
            this.multiRowHeaderDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.multiRowHeaderDataGridView1.Location = new System.Drawing.Point(26, 45);
            this.multiRowHeaderDataGridView1.Name = "multiRowHeaderDataGridView1";
            this.multiRowHeaderDataGridView1.Size = new System.Drawing.Size(604, 224);
            this.multiRowHeaderDataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 451);
            this.Controls.Add(this.multiRowHeaderDataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.multiRowHeaderDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MultiDataGridView.MultiRowHeaderDataGridView multiRowHeaderDataGridView1;

    }
}

