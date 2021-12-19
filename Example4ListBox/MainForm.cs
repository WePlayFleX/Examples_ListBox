using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleListBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // установка редима выбора одной записи в listbox
            lstSubjects.SelectionMode = SelectionMode.One;
        }

       // Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // формирвоание коллекции для отображения в lstSubjects
            List<Subject> Subjects = new List<Subject>()
            {
             new Subject(){Num=1, Name="C#", Days=24.5},
              new Subject(){Num=2, Name="WinForms", Days=12.5},
               new Subject(){Num=3, Name="WPF", Days=10.4},
                new Subject(){Num=4, Name="ADO.NET", Days=16.4},
                 new Subject(){Num=5, Name="ASP.NET", Days=20.4},
            };
            // 
            lstSubjects.DataSource = Subjects;
            
        }

        private void lstSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверка на наличие выбранных элементов 
            if (lstSubjects.SelectedItem != null)
            {   // Получение объекта выбранного элемента
                Subject selSubjects = (Subject)lstSubjects.SelectedItem;
                tbNum.Text = selSubjects.Num.ToString();
                tbName.Text = selSubjects.Name.ToString();
                tbDays.Text = selSubjects.Days.ToString();
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
