using ADO.NET_HW_5.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ADO.NET_HW_5
{

    public partial class Form2 : Form
    {
        private readonly Form1 _form;
        private readonly CountryDataTable data = new CountryDataTable();
        public Form2(Form1 form1)
        {
            data.AddFunc();
            _form = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => Close();

        private void Form2_Load(object sender, EventArgs e) => ResultsOut();

        public void ResultsOut()
        {
            
            for (int i = 0; i <= data.func.GetInvocationList().Length; i++)
                if (i == _form.comboBox1.SelectedIndex)
                {
                    lstBox_Results.DataSource = (List<string>)Invoke(data.func.GetInvocationList()[i]);
                    break;
                }
        }

    }
}
