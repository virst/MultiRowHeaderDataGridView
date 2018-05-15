using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //multiRowHeaderDataGridView1.MultiHeader = true;
                //multiRowHeaderDataGridView1.LevelSeparator = '|';
                multiRowHeaderDataGridView1.Columns.Add("A", "A");
                multiRowHeaderDataGridView1.Columns.Add("C", "H|B|C");
                multiRowHeaderDataGridView1.Columns.Add("G", "H|D|E|G");
                multiRowHeaderDataGridView1.Columns.Add("Z", "H|D|E|Z");
                multiRowHeaderDataGridView1.Columns.Add("T", "H|D|T");

                this.multiRowHeaderDataGridView1.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

                this.multiRowHeaderDataGridView1.ColumnHeadersHeight =
                    this.multiRowHeaderDataGridView1.ColumnHeadersHeight * 3;
            }
            catch (Exception ex)
            {
                // ignored
            }
        }
    }
}
