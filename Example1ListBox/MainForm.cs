using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1ListBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] strings = { "С#", "WinForms", "WPF", "ADO.NET", "WCF", "ASP.NET" };
            // Добавление строк в Items элемента listBox1 
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Items.AddRange(strings);
            listBox2.SelectionMode = SelectionMode.One;
            listBox2.Items.AddRange(strings);
            listBox3.SelectionMode = SelectionMode.MultiSimple;
            listBox3.Items.AddRange(strings);
            listBox4.SelectionMode = SelectionMode.MultiExtended;
            listBox4.Items.AddRange(strings);

        }

    }
}
