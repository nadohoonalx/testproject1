using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace 인간관계프로젝트
{
    public partial class Form2 : Form
    {

        private Form1 dlg;

        public Form2(Form1 a)
        {
            InitializeComponent();
            dlg = a;
        }

        ArrayList al = new ArrayList();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e) //추가버튼
        {
            ListViewItem item1 = new ListViewItem(textBox1.Text, comboBox2.SelectedIndex);
            item1.SubItems.Add(textBox2.Text);
            item1.SubItems.Add(textBox3.Text);
            item1.SubItems.Add(textBox4.Text);
            item1.SubItems.Add(textBox5.Text);

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            listView1.Items.Add(item1);
            listView1.View = View.Details;
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
