using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Subject> Subjects=new List<Subject>()
            {
             new Subject(){Num=1, Name="C#"},
              new Subject(){Num=2, Name="WinForms"},
               new Subject(){Num=3, Name="WPF"},
                new Subject(){Num=4, Name="ADO.NET"},
                 new Subject(){Num=5, Name="ASP.NET"},
            };

            comboBox6.DataSource = Subjects;
            comboBox6.DisplayMember = "Name";


        }

        private void button1_Click(object sender, EventArgs e)
        {
           int rezIndex= comboBox6.FindStringExact(textBox1.Text);
           label6.Text = "Индекс: "+rezIndex.ToString();

        }
    }

    class Subject
    {
        public int Num { get; set; }

        public string Name { get; set; }
    }


}
