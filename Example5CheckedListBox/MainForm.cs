using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleCheckedListBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            chlstTarget.DisplayMember = "Name";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Subject> Subjects = new List<Subject>()
            {
             new Subject(){Num=1, Name="C#", Days=24.5},
              new Subject(){Num=2, Name="WinForms", Days=12.5},
               new Subject(){Num=3, Name="WPF", Days=10.4},
                new Subject(){Num=4, Name="ADO.NET", Days=16.4},
                 new Subject(){Num=5, Name="ASP.NET", Days=20.4},
            };
            // заполнение списка данными 
            chlstSourse.DataSource = Subjects;
            // отображение только имени Subject
            chlstSourse.DisplayMember = "Name";
        }

        private void btnCopySelect_Click(object sender, EventArgs e)
        {
			for (int i = 0; i < chlstSourse.Items.Count; i++)
			{   // проверка наличия установленного признака
				if (chlstSourse.GetItemChecked(i))
				{
					chlstTarget.Items.Add(chlstSourse.Items[i]);
				}
			}
		}

        private void btnSelect_Click(object sender, EventArgs e)
        {  for (int i = 0; i < chlstTarget.Items.Count; i++)
            {  // установка выделения 
               chlstTarget.SetItemChecked(i, true);
            }
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {  for (int i = 0; i < chlstTarget.Items.Count; i++)
            {   // снятие выделения 
                chlstTarget.SetItemChecked(i, false);
            }
        }
    }

    public class Subject
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public double Days { get; set; }

        public override string ToString()
        {
            return String.Format("{0}. \"{1}\". Всего:{2} дней", Num, Name, Days);
        }
    }
}
