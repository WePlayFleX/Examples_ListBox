using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxExample1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Добавление строки из textBox1  в  listBox1
        private void btnAddToListBox_Click(object sender, EventArgs e)
        {
            // Проверка на пустую строку или NULL
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                // Проверка на наличие данной строки в Items элемента listBox1
                if (!listBox1.Items.Contains(textBox1.Text))
                {
                    // Добавление строки в Items элемента listBox1
                    listBox1.Items.Add(textBox1.Text);
                }
                else
                    MessageBox.Show("Данная строка уже имеется в Списке!");
            }
            else
                MessageBox.Show("Введите строку для добавления!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] strings = { "С#", "WinForms", "WPF", "ADO.NET", "WCF", "ASP.NET"};
            // Добавление строк в Items элемента listBox1 
            listBox1.Items.AddRange(strings);
        }

        // Копирование строк из    listBox1  в   listBox2  
        private void btnCopyFromListBox_Click(object sender, EventArgs e)
        {
            // Очистка Items элемента listBox2
            listBox2.Items.Clear();
             
            for (int i = 0; i < listBox1.Items.Count; i++)
                listBox2.Items.Add(listBox1.Items[i]);
        }

        //Удаление строк из Items элемента listBox1
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            // Проверка на наличие элементов
            if (listBox1.Items.Count != 0)
            {
                // Проверка на наличие выбранных строк 
                if (listBox1.SelectedItems != null)
                {
                    // Перебор всех выбранных строк в элементе listBox1
                    for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                    {
                        // Удаление строки из Items
                        listBox1.Items.Remove(listBox1.SelectedItems[i]);
                           
                    }
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
