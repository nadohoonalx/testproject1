using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace 인간관계프로젝트
{
    public partial class Form3 : Form
    {


        private Form1 dlg2;
        public Form3(Form1 b)
        {
            InitializeComponent();
            dlg2 = b;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e) // 회원가입 완료
        {
            

                try

                {

                    SqlConnection registerDBCONN = new SqlConnection();

                    registerDBCONN.ConnectionString = "Server=localhost;Database=register; User ID=sa;Password=sa1234;";

                    registerDBCONN.Open();

                    SqlCommand Command = new SqlCommand();

                    Command.Connection = registerDBCONN;

                    Command.CommandType = CommandType.StoredProcedure;

                    Command.CommandText = "SELECT * FROM regsiters";

                Command.Parameters.AddWithValue("@ID", textBox1.Text);

                    Command.Parameters.AddWithValue("@Name", textBox2.Text);

                    Command.Parameters.AddWithValue("@Password", textBox3.Text);

                    MessageBox.Show("앙큼한유채 : 데이터가 저장됐습니다.", "Information");



                    Command.ExecuteNonQuery();

                    //DB 닫기

                    registerDBCONN.Close();

                }

                catch (SqlException ex)

                {

                    MessageBox.Show(ex.Message);

                }

            
            Close();
        }
        
   





    //디비내용 데이터에다가 올려줘야 함.


    private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    


}
}
