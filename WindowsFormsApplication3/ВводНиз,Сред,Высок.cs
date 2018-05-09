using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
double  sum, Number, Procent, Prn, suhu, s_rendah = 0, s_sedang= 0, s_tinggi = 0, aa, bb, cc, dd, ee, ff, gg, hh;





            //низкий
            suhu = Convert.ToDouble(textBox9.Text);
            aa = Convert.ToDouble(textBox1.Text);
            cc = Convert.ToDouble(textBox3.Text);
            if (suhu < aa)
            {
            s_rendah= 1;
            }
            if (suhu >= aa && suhu <= cc)
            {
            s_rendah = (cc - suhu) / (cc - aa);
            }

            if (suhu > cc)
            {

                s_rendah = 0;
            }
           textBox10.Text = Convert.ToString(String.Format("{0:0.0}",  s_rendah));

        // средний 
        suhu = Convert.ToDouble(textBox9.Text);
            bb = Convert.ToDouble(textBox2.Text);
            dd = Convert.ToDouble(textBox4.Text);
            ff = Convert.ToDouble(textBox6.Text);
            gg = Convert.ToDouble(textBox7.Text);

            if (suhu<bb)
            {
                s_sedang = 1;
            }
            if (suhu >= bb && suhu <= dd)
            {
                s_sedang = (suhu - bb) / (dd - bb);
            }
            if (suhu >= dd && suhu <= ff)
            {
                s_sedang = 1;
            }
            if (suhu >= ff && suhu <= gg)
            {
                s_sedang = (gg - suhu) / (gg - ff);
            }
            if (suhu > gg)
            {
                s_sedang = 0;
            }
            textBox11.Text = Convert.ToString(String.Format("{0:0.0}",  s_sedang));
    
        //высокий
        suhu = Convert.ToDouble(textBox9.Text);
            ee = Convert.ToDouble(textBox5.Text);
            hh = Convert.ToDouble(textBox8.Text);
            if (suhu<ee)
            {
                s_tinggi = 0;
            }
            if (suhu >= ee && suhu <= hh)
            {
                s_tinggi = (suhu - ee) / (hh - ee);
            }
            if (suhu > hh)
            {

                s_tinggi = 1;
            }
           textBox12.Text = Convert.ToString(String.Format("{0:0.0}", s_tinggi));

    */
    }

        private void button2_Click(object sender, EventArgs e)
        {


            SQLiteConnection myConnection;
            myConnection =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection.Open();

            string query = "SELECT * FROM Var WHERE id='1'";

            SQLiteCommand command = new SQLiteCommand(query, myConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                textBox1.Text = reader["a"].ToString();
                textBox2.Text = reader["b"].ToString();
                textBox3.Text = reader["c"].ToString();
                textBox4.Text = reader["d"].ToString();
                textBox5.Text = reader["e"].ToString();
                textBox6.Text = reader["f"].ToString();
                textBox7.Text = reader["g"].ToString();
                textBox8.Text = reader["h"].ToString();
            }
            reader.Close();
            myConnection.Close();

    }

        private void button5_Click(object sender, EventArgs e)
        {

            SQLiteConnection myConnection;
            myConnection =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection.Open();

            string query = "SELECT * FROM Var WHERE id='2'";

            SQLiteCommand command = new SQLiteCommand(query, myConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                textBox20.Text = reader["a"].ToString();
                textBox19.Text = reader["b"].ToString();
                textBox18.Text = reader["c"].ToString();
                textBox17.Text = reader["d"].ToString();
                textBox16.Text = reader["e"].ToString();
                textBox15.Text = reader["f"].ToString();
                textBox14.Text = reader["g"].ToString();
                textBox13.Text = reader["h"].ToString();
            }






        }

        private void button7_Click(object sender, EventArgs e)
        {

            SQLiteConnection myConnection;
            myConnection =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection.Open();

            string query = "SELECT * FROM Var WHERE id='3'";

            SQLiteCommand command = new SQLiteCommand(query, myConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                textBox28.Text = reader["a"].ToString();
                textBox27.Text = reader["b"].ToString();
                textBox26.Text = reader["c"].ToString();
                textBox25.Text = reader["d"].ToString();
                textBox24.Text = reader["e"].ToString();
                textBox23.Text = reader["f"].ToString();
                textBox22.Text = reader["g"].ToString();
                textBox21.Text = reader["h"].ToString();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {

            SQLiteConnection myConnection;
            myConnection =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection.Open();

            string query = "SELECT * FROM Var WHERE id='4'";

            SQLiteCommand command = new SQLiteCommand(query, myConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                textBox36.Text = reader["a"].ToString();
                textBox35.Text = reader["b"].ToString();
                textBox34.Text = reader["c"].ToString();
                textBox33.Text = reader["d"].ToString();
                textBox32.Text = reader["e"].ToString();
                textBox31.Text = reader["f"].ToString();
                textBox30.Text = reader["g"].ToString();
                textBox29.Text = reader["h"].ToString();
            }







        }

        private void button11_Click(object sender, EventArgs e)
        {
            SQLiteConnection myConnection;
            myConnection =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection.Open();

            string query = "SELECT * FROM Var WHERE id='5'";

            SQLiteCommand command = new SQLiteCommand(query, myConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                textBox44.Text = reader["a"].ToString();
                textBox43.Text = reader["b"].ToString();
                textBox42.Text = reader["c"].ToString();
                textBox41.Text = reader["d"].ToString();
                textBox40.Text = reader["e"].ToString();
                textBox39.Text = reader["f"].ToString();
                textBox38.Text = reader["g"].ToString();
                textBox37.Text = reader["h"].ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > Convert.ToDouble(textBox2.Text) || Convert.ToDouble(textBox2.Text) > Convert.ToDouble(textBox3.Text) || Convert.ToDouble(textBox3.Text) > Convert.ToDouble(textBox4.Text) || Convert.ToDouble(textBox4.Text) > Convert.ToDouble(textBox5.Text) || Convert.ToDouble(textBox5.Text) > Convert.ToDouble(textBox6.Text) || Convert.ToDouble(textBox6.Text) > Convert.ToDouble(textBox7.Text) || Convert.ToDouble(textBox7.Text) > Convert.ToDouble(textBox8.Text))
            {
                string message = "Переменные введены не корректно"; 
                string title = "Операция отменена";
                MessageBox.Show(message, title);
                return;

            }

                string dataSource = "TestDB.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection())
            {
                connection.ConnectionString = "Data Source=" + dataSource;
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                  
                    command.CommandText = ("update Var set a ='" + textBox1.Text + "', b ='" + textBox2.Text + "',  c ='" + textBox3.Text + "', d ='" + textBox4.Text + "', e ='" + textBox5.Text + "', f ='" + textBox6.Text + "',   g ='" + textBox7.Text + "', h ='" + textBox8.Text + "' where ID ='1'");                  
                    command.ExecuteNonQuery();
                }
            }
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox20.Text) > Convert.ToDouble(textBox19.Text) || Convert.ToDouble(textBox19.Text) > Convert.ToDouble(textBox18.Text) || Convert.ToDouble(textBox18.Text) > Convert.ToDouble(textBox17.Text) || Convert.ToDouble(textBox17.Text) > Convert.ToDouble(textBox16.Text) || Convert.ToDouble(textBox16.Text) > Convert.ToDouble(textBox15.Text) || Convert.ToDouble(textBox15.Text) > Convert.ToDouble(textBox14.Text) || Convert.ToDouble(textBox14.Text) > Convert.ToDouble(textBox13.Text))
            {
                string message = "Переменные введены не корректно";
                string title = "Операция отменена";
                MessageBox.Show(message, title);
                return;

            }
            string dataSource = "TestDB.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection())
            {
                connection.ConnectionString = "Data Source=" + dataSource;
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {

                    command.CommandText = ("update Var set a ='" + textBox20.Text + "', b ='" + textBox19.Text + "',  c ='" + textBox18.Text + "', d ='" + textBox17.Text + "', e ='" + textBox16.Text + "', f ='" + textBox15.Text + "',   g ='" + textBox14.Text + "', h ='" + textBox13.Text + "' where ID ='2'");
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox28.Text) > Convert.ToDouble(textBox27.Text) || Convert.ToDouble(textBox27.Text) > Convert.ToDouble(textBox26.Text) || Convert.ToDouble(textBox26.Text) > Convert.ToDouble(textBox25.Text) || Convert.ToDouble(textBox25.Text) > Convert.ToDouble(textBox24.Text) || Convert.ToDouble(textBox24.Text) > Convert.ToDouble(textBox23.Text) || Convert.ToDouble(textBox23.Text) > Convert.ToDouble(textBox22.Text) || Convert.ToDouble(textBox22.Text) > Convert.ToDouble(textBox21.Text))
            {
                string message = "Переменные введены не корректно";
                string title = "Операция отменена";
                MessageBox.Show(message, title);
                return;

            }
            string dataSource = "TestDB.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection())
            {
                connection.ConnectionString = "Data Source=" + dataSource;
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {

                    command.CommandText = ("update Var set a ='" + textBox28.Text + "', b ='" + textBox27.Text + "',  c ='" + textBox26.Text + "', d ='" + textBox25.Text + "', e ='" + textBox24.Text + "', f ='" + textBox23.Text + "',   g ='" + textBox22.Text + "', h ='" + textBox21.Text + "' where ID ='3'");
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox36.Text) > Convert.ToDouble(textBox35.Text) || Convert.ToDouble(textBox35.Text) > Convert.ToDouble(textBox34.Text) || Convert.ToDouble(textBox34.Text) > Convert.ToDouble(textBox33.Text) || Convert.ToDouble(textBox33.Text) > Convert.ToDouble(textBox32.Text) || Convert.ToDouble(textBox32.Text) > Convert.ToDouble(textBox31.Text) || Convert.ToDouble(textBox31.Text) > Convert.ToDouble(textBox30.Text) || Convert.ToDouble(textBox30.Text) > Convert.ToDouble(textBox29.Text))
            {
                string message = "Переменные введены не корректно";
                string title = "Операция отменена";
                MessageBox.Show(message, title);
                return;

            }
            string dataSource = "TestDB.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection())
            {
                connection.ConnectionString = "Data Source=" + dataSource;
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {

                    command.CommandText = ("update Var set a ='" + textBox36.Text + "', b ='" + textBox35.Text + "',  c ='" + textBox34.Text + "', d ='" + textBox33.Text + "', e ='" + textBox32.Text + "', f ='" + textBox31.Text + "',   g ='" + textBox30.Text + "', h ='" + textBox29.Text + "' where ID ='4'");
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox44.Text) > Convert.ToDouble(textBox43.Text) || Convert.ToDouble(textBox43.Text) > Convert.ToDouble(textBox42.Text) || Convert.ToDouble(textBox42.Text) > Convert.ToDouble(textBox41.Text) || Convert.ToDouble(textBox41.Text) > Convert.ToDouble(textBox40.Text) || Convert.ToDouble(textBox40.Text) > Convert.ToDouble(textBox39.Text) || Convert.ToDouble(textBox39.Text) > Convert.ToDouble(textBox38.Text) || Convert.ToDouble(textBox38.Text) > Convert.ToDouble(textBox37.Text))
            {
                string message = "Переменные введены не корректно";
                string title = "Операция отменена";
                MessageBox.Show(message, title);
                return;

            }


            string dataSource = "TestDB.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection())
            {
                connection.ConnectionString = "Data Source=" + dataSource;
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {

                    command.CommandText = ("update Var set a ='" + textBox44.Text + "', b ='" + textBox43.Text + "',  c ='" + textBox42.Text + "', d ='" + textBox41.Text + "', e ='" + textBox40.Text + "', f ='" + textBox39.Text + "',   g ='" + textBox38.Text + "', h ='" + textBox37.Text + "' where ID ='5'");
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}