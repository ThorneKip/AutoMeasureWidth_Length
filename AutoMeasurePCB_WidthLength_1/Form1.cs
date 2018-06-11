using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMeasurePCB_WidthLength_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataGridViewRowCollection rows = dataGridView1.Rows;
            rows.Add(new Object[] { "TOP SM", 26.3 });
            rows.Add(new Object[] { "Cu L1", 18.3 });
        }


    }
}
