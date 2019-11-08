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
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
           
            
        }

     
        private SqlCommand comm;





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e) //로그인
        {
            string connectionString = "Server=localhost;Database=people; User ID=sa;Password=sa1234;";

            SqlConnection scon = new SqlConnection(connectionString);
            //접속정보 적용
            scon.Open();
            // DB 연결
            SqlCommand scom = new SqlCommand();
            //쿼리 날릴 곳은 conn 즉 아까 연결한 DB
            
            //scom.CommandText = "SELECT group, createuserid FROM GROUPTABLE";
            scom.CommandText =  "INSERT INTO WBdata(Userid, Userpassword)VALUES(@id, @password)";
            //쿼리 날리기, sqlDataReder에 결과값 저장하기.
            scom.Connection = scon;

            //SqlDataReader sdr = scom.ExecuteReader();
            

            scom.Parameters.Add("@id", SqlDbType.Text).Value = textBox1.Text;
            scom.Parameters.Add("@password", SqlDbType.Text).Value = textBox2.Text;
            //  conn.Close();

            try
            {
                comm.ExecuteNonQuery();

                MessageBox.Show("저장완료", "종료", MessageBoxButtons.OK, MessageBoxIcon.None);
                textBox1.Text = "";
                textBox2.Text = "";
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("저장실패", "종료", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                scon.Close();
                scon.Dispose();
            }

                 Form2 dlg = new Form2(this);
                 dlg.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e) //회원가입버튼
        {
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }
    }
}
