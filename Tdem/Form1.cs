using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary.Models;
using MyLibrary.Helpers;

namespace Tdem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn_Get_Click(null, null);
        }

        private async void Btn_AddOrUpdate_Click(object sender, EventArgs e)
        {
            var header = new Header();
            //if (!string.IsNullOrEmpty(Txt_Filename.Text)) header.FileName = int.Parse(Txt_Filename.Text);
            if (!string.IsNullOrEmpty(Txt_Filename.Text))//Do when is not null
            {
                header.FileName = Txt_Filename.Text;
                header.Flag = Txt_Flag.Text;
                await Service.AddOrUpdateHeader(header);
                dataGridView1.DataSource = await Service.GetHeaders();
            }
            
        }

        private async void Btn_Get_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = await Service.GetHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}
