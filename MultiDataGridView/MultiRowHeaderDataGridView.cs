using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace MultiDataGridView
{
    public class MultiRowHeaderDataGridView : DataGridView
    {
        private readonly MultiHeaderElimentCollection _mhc = new MultiHeaderElimentCollection();
        private readonly StringFormat _format = new StringFormat{Alignment = StringAlignment.Center,LineAlignment = StringAlignment.Center};

        [DefaultValue('|')]
        public char LevelSeparator { get; set; }

        [DefaultValue(true)]
        public bool MultiHeader { get; set; }

        public MultiRowHeaderDataGridView()
        {
            LevelSeparator = '|';
            MultiHeader = true;

            Columns.CollectionChanged += new CollectionChangeEventHandler(Columns_CollectionChanged);
            ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.BottomCenter;
            CellPainting += MultiRowHeaderDataGridView_CellPainting;
            Paint += MultiRowHeaderDataGridView_Paint;

        }

        private void MultiRowHeaderDataGridView_Paint(object sender, PaintEventArgs e)
        {
            if (!MultiHeader) return;

            foreach (var m in _mhc)
            {
                Rectangle r1 = GetCellDisplayRectangle(m.Position.X, -1, true); //get the column header cell
                r1.Y = (ColumnHeadersHeight + 1) * m.Position.Y;
                if (m.Position.Y == 0)
                    r1.Y += 1;
                r1.Width = 0;
                for (var i = 0; i < m.Position.Width; i++)
                    r1.Width += Columns[i + m.Position.X].Width;

                r1.Height = (ColumnHeadersHeight - 1) * m.Position.Height;
                r1.Height -= m.Position.Y;
                r1.Width -= 2;

                e.Graphics.FillRectangle(new SolidBrush(ColumnHeadersDefaultCellStyle.BackColor), r1);
                e.Graphics.DrawLine(new Pen(ColumnHeadersDefaultCellStyle.ForeColor), r1.Left, r1.Bottom, r1.Right, r1.Bottom);

                e.Graphics.DrawString(m.Text,
                    ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(ColumnHeadersDefaultCellStyle.ForeColor),
                    r1,
                    _format);
            }

        }

        private void MultiRowHeaderDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.PaintBackground(e.CellBounds, false);
                Rectangle r2 = e.CellBounds;
                r2.Height = ColumnHeadersHeight * (HeaderLevels - _mhc.TotalHeight(e.ColumnIndex));
                r2.Y += e.CellBounds.Height - r2.Height;
                var ss = Columns[e.ColumnIndex].HeaderText.Split(LevelSeparator);
                e.Graphics.DrawString(ss.Last(),
                    ColumnHeadersDefaultCellStyle.Font,
                    new SolidBrush(ColumnHeadersDefaultCellStyle.ForeColor),
                    r2,
                    _format);
                e.Handled = true;
            }
        }

        int _maxH = 0;

        void Columns_CollectionChanged(object sender, CollectionChangeEventArgs e)
        {
            _mhc.Clear(); _maxH = 0;
            if (!MultiHeader) return;
            string[] ss1 = null;
            for (var i = 0; i < ColumnCount; i++)
            {
                var ss2 = ss1;
                ss1 = Columns[i].HeaderText.Split(LevelSeparator);
                if (_maxH < ss1.Length) _maxH = ss1.Length;
                for (var j = 0; j < ss1.Length - 1; j++)
                {
                    if (ss2 != null && j < ss2.Length - 1 && ss1[j] == ss2[j])
                        continue;
                    var r = new MultiHeaderEliment {Position = new Rectangle(i, j, 1, 1)};
                    var w = 0;
                    for (int c = i; c < ColumnCount; c++)
                    {
                        var ss3 = Columns[c].HeaderText.Split(LevelSeparator);
                        if (ss3.Length - 1 < j)
                            break;
                        if (ss3[j] == ss1[j])
                            w++;
                        else
                            break;
                    }
                    r.Position.Width = w;
                    r.Text = ss1[j];
                    r.FullText = Columns[i].HeaderText;
                    _mhc.Add(r);
                }
            }

            foreach (MultiHeaderEliment o in _mhc)
            {
                var ss = o.FullText.Split(LevelSeparator);
                if (o.Position.Y == ss.Length - 2)
                    o.Position.Height = _maxH - ss.Length + 1;
            }
        }        

        public new int ColumnHeadersHeight
        {
            get { return base.ColumnHeadersHeight / HeaderLevels; }
            set { base.ColumnHeadersHeight = value * HeaderLevels;}
        }

        private int HeaderLevels
        {
            get
            {
                if (!MultiHeader || _maxH == 0)
                    return 1;
                return _maxH;
            }
        }


    }

}
