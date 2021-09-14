using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sabtenam
{
    public partial class Form1 : Form
    {
        db data = new db();
       

        public Form1()
        {
            
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ایا میخواهید خارج شوید" , "خروج" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning ) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tedad = data.jadval.Count().ToString();
            MessageBox.Show("تعداد کاربران سیستم: " + tedad + "نفر میباشد", "کاربران", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.jadval.ToList();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            human h = new human();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = h.search(textBox5.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            human h = new human();
            h.name = textBox1.Text;
            h.family = textBox2.Text;
            h.age = Convert.ToByte( textBox3.Text);
            h.codemeli = textBox4.Text;
            MessageBox.Show(h.rigster(h), "وضعیت عملیات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach(var item in Controls)
            {
                if (item == "System.Windows.Forms.Text")
                {
                    (item as TextBox).Clear();

                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = (data.jadval.ToList());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.jadval.ToList();
        }
    }
}
