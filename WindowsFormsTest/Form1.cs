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


                this.multiRowHeaderDataGridView1.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
               
            }
            catch (Exception ex)
            {
                // ignored
            }
        }
    }
}
