using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleListBox2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

     
        private void MainForm_Load(object sender, EventArgs e)
        {
            double[] prices =
                {    13.3844, 7.7544, 50.1, 532.251, 8.2559, 111.10, 962.3,
                     49.274444, 4.064, 98.444, 896.1553, 7.44551, 592.09, 238.2};

            listBox1.DataSource = prices;
            listBox3.FormatString = "N2";
            listBox3.DataSource = prices;
            
            DateTime[] dates =
                                {
                                new DateTime(2013, 4, 1),
                                new DateTime(2013, 3, 21),
                                new DateTime(2013, 7, 18),
                                new DateTime(2013, 9, 9),
                                new DateTime(2013, 11, 30),
                                new DateTime(2013, 2, 12),
                                new DateTime(2013, 4, 1),
                                new DateTime(2013, 3, 21),
                                new DateTime(2013, 7, 18),
                                new DateTime(2013, 9, 9),
                                new DateTime(2013, 11, 30),
                                new DateTime(2013, 2, 12),
                                };

            listBox2.DataSource = dates;
            listBox4.FormatString = "D";
            listBox4.DataSource = dates;
          
        }
    }
}
