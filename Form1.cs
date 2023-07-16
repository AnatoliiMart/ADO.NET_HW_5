using ADO.NET_HW_5.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace ADO.NET_HW_5
{
    public partial class Form1 : Form
    {
        private CountryDataTable _data;

        private readonly Dictionary<string, string> _tasks;

        public Form1()
        {
            _tasks = new Dictionary<string, string>()
                   {
                       {"Задание 1", "Показать топ-5 стран по площади" },
                       {"Задание 2", "Показать топ-5 стран по количеству жителей" },
                       {"Задание 3", "Показать страну с самой большой площадью" },
                       {"Задание 4", "Показать страну с самым большим количеством жителей" },
                       {"Задание 5", "Показать страну с самой маленькой площадью в Европе" },
                       {"Задание 6", "Показать среднюю площадь стран в Европпе" },
                       {"Задание 7", "Показать топ-3 городов по количеству жителей для конкретной страны" },
                       {"Задание 8", "Показать общее количество стран" },
                       {"Задание 9", "Показать часть света с максимальным количеством стран" },
                       {"Задание 10", "Показать количество стран в каждой части света" }
                   };
            InitializeComponent();
            using (_data = new CountryDataTable())
            {
                dataGridView1.DataSource = _data.Countries;
                comboBox1.DataSource = _tasks.Keys.ToList();
                comboBox1.SelectedIndex = 0;
            }
        }

        private void btn_AddRow_Click(object sender, EventArgs e)
        {
            using (_data = new CountryDataTable())
            {
                _data.AddNewCountry(txtBox_CountryName.Text, txtBox_CapitalName.Text, int.Parse(txtBox_ResidentsAmount.Text),
                    float.Parse(txtBox_CountryArea.Text), txtBox_Continent.Text);
                ClearTxtBoxes();
                dataGridView1.DataSource = _data.Countries;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox_TaskText.Text = _tasks[comboBox1.SelectedItem.ToString()];
        }   

        private void ClearTxtBoxes()
        {
            txtBox_CountryName.Text = string.Empty;
            txtBox_CapitalName.Text = string.Empty;
            txtBox_ResidentsAmount.Text = string.Empty;
            txtBox_CountryArea.Text = string.Empty;
            txtBox_Continent.Text = string.Empty;           
        }
    }

    
}
