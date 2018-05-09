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
    public partial class Form3 : Form
    {

       // Form1 form1 = new Form1();
       Form2 form2 = new Form2();
      //  Form3 form3 = new Form3();
     //   Ориентир form4 = new Ориентир();

        public Form3()
        {
            InitializeComponent();
            LoadData();
        }


        public void LoadData()
        {
            SQLiteConnection myConnection;
            myConnection =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection.Open();

            string query = "SELECT * FROM Var";

            SQLiteCommand command = new SQLiteCommand(query, myConnection);
            SQLiteDataReader reader = command.ExecuteReader();

           

            while (reader.Read())
            {







                for (int i = 0; i <= 0; i++)
                {
               //     textBox1.Text = reader[0+i].ToString();


                }
            }





        }















        private void button1_Click(object sender, EventArgs e)
        {
            double sum, Number, Procent, Prn, suhu, s_rendah = 0, s_sedang = 0, s_tinggi = 0, aa, bb, cc, dd, ee, ff, gg, hh;
            SQLiteConnection myConnection;
            myConnection =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection.Open();

            string query = "SELECT * FROM Var  WHERE id='1'";

            SQLiteCommand command = new SQLiteCommand(query, myConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //низкий 1
                suhu = Convert.ToDouble(textBox9.Text);            // Convert.ToDouble(form2.textBox9.Text);
                aa = Convert.ToDouble(reader["a"].ToString());
                cc = Convert.ToDouble(reader["c"].ToString());
                if (suhu < aa)
                {
                    s_rendah = 1;
                }
                if (suhu >= aa && suhu <= cc)
                {
                    s_rendah = (cc - suhu) / (cc - aa);
                }

                if (suhu > cc)
                {
                    s_rendah = 0;
                }
                textBox10.Text = Convert.ToString(String.Format("{0:0.0}", s_rendah));

                // средний 1
                suhu = Convert.ToDouble(textBox9.Text);
                bb = Convert.ToDouble(reader["b"].ToString());
                dd = Convert.ToDouble(reader["d"].ToString());
                ff = Convert.ToDouble(reader["f"].ToString());
                gg = Convert.ToDouble(reader["g"].ToString());

                if (suhu < bb)
                {
                    s_sedang = 0;
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
                textBox11.Text = Convert.ToString(String.Format("{0:0.0}", s_sedang));


                //высокий 1
                suhu = Convert.ToDouble(textBox9.Text);
                ee = Convert.ToDouble(reader["e"].ToString());
                hh = Convert.ToDouble(reader["h"].ToString());
                if (suhu < ee)
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

            }












                SQLiteConnection myConnection2;
                myConnection2 =
    new SQLiteConnection("Data Source=TestDB.db;Version=3;");
                myConnection2.Open();

                string query2 = "SELECT * FROM Var WHERE id='2'";

                SQLiteCommand command2 = new SQLiteCommand(query2, myConnection2);
                SQLiteDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {




                    {
                  //  for (int i = 0; i <= 0; i++)
                 //   {
                        //низкий 2
                        suhu = Convert.ToDouble(textBox9.Text);
                        aa = Convert.ToDouble(reader2["a"].ToString());
                        cc = Convert.ToDouble(reader2["c"].ToString());
                        if (suhu < aa)
                        {
                            s_rendah = 1;
                        }
                        if (suhu >= aa && suhu <= cc)
                        {
                            s_rendah = (cc - suhu) / (cc - aa);
                        }

                        if (suhu > cc)
                        {
                            s_rendah = 0;
                        }
                        textBox3.Text = Convert.ToString(String.Format("{0:0.0}", s_rendah));

                        // средний 2
                        suhu = Convert.ToDouble(textBox9.Text);
                        bb = Convert.ToDouble(reader2["b"].ToString());
                        dd = Convert.ToDouble(reader2["d"].ToString());
                        ff = Convert.ToDouble(reader2["f"].ToString());
                        gg = Convert.ToDouble(reader2["g"].ToString());

                        if (suhu < bb)
                        {
                            s_sedang = 0;
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
                        textBox2.Text = Convert.ToString(String.Format("{0:0.0}", s_sedang));


                        //высокий 2
                        suhu = Convert.ToDouble(textBox9.Text);
                        ee = Convert.ToDouble(reader2["e"].ToString());
                        hh = Convert.ToDouble(reader2["h"].ToString());
                        if (suhu < ee)
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
                        textBox1.Text = Convert.ToString(String.Format("{0:0.0}", s_tinggi));

                }
            }








            SQLiteConnection myConnection3;
            myConnection3 =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection3.Open();

            string query3 = "SELECT * FROM Var WHERE id='3'";

            SQLiteCommand command3 = new SQLiteCommand(query3, myConnection3);
            SQLiteDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {




                {
                    //  for (int i = 0; i <= 0; i++)
                    //   {
                    //низкий 2
                    suhu = Convert.ToDouble(textBox9.Text);
                    aa = Convert.ToDouble(reader3["a"].ToString());
                    cc = Convert.ToDouble(reader3["c"].ToString());
                    if (suhu < aa)
                    {
                        s_rendah = 1;
                    }
                    if (suhu >= aa && suhu <= cc)
                    {
                        s_rendah = (cc - suhu) / (cc - aa);
                    }

                    if (suhu > cc)
                    {
                        s_rendah = 0;
                    }
                    textBox6.Text = Convert.ToString(String.Format("{0:0.0}", s_rendah));

                    // средний 2
                    suhu = Convert.ToDouble(textBox9.Text);
                    bb = Convert.ToDouble(reader3["b"].ToString());
                    dd = Convert.ToDouble(reader3["d"].ToString());
                    ff = Convert.ToDouble(reader3["f"].ToString());
                    gg = Convert.ToDouble(reader3["g"].ToString());

                    if (suhu < bb)
                    {
                        s_sedang = 0;
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
                    textBox5.Text = Convert.ToString(String.Format("{0:0.0}", s_sedang));


                    //высокий 2
                    suhu = Convert.ToDouble(textBox9.Text);
                    ee = Convert.ToDouble(reader3["e"].ToString());
                    hh = Convert.ToDouble(reader3["h"].ToString());
                    if (suhu < ee)
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
                    textBox4.Text = Convert.ToString(String.Format("{0:0.0}", s_tinggi));

                }
            }



            SQLiteConnection myConnection4;
            myConnection4 =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection4.Open();

            string query4 = "SELECT * FROM Var WHERE id='4'";

            SQLiteCommand command4 = new SQLiteCommand(query4, myConnection4);
            SQLiteDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())
            {

                {
                    //  for (int i = 0; i <= 0; i++)
                    //   {
                    //низкий 2
                    suhu = Convert.ToDouble(textBox9.Text);
                    aa = Convert.ToDouble(reader4["a"].ToString());
                    cc = Convert.ToDouble(reader4["c"].ToString());
                    if (suhu < aa)
                    {
                        s_rendah = 1;
                    }
                    if (suhu >= aa && suhu <= cc)
                    {
                        s_rendah = (cc - suhu) / (cc - aa);
                    }

                    if (suhu > cc)
                    {
                        s_rendah = 0;
                    }
                    textBox13.Text = Convert.ToString(String.Format("{0:0.0}", s_rendah));

                    // средний 2
                    suhu = Convert.ToDouble(textBox9.Text);
                    bb = Convert.ToDouble(reader4["b"].ToString());
                    dd = Convert.ToDouble(reader4["d"].ToString());
                    ff = Convert.ToDouble(reader4["f"].ToString());
                    gg = Convert.ToDouble(reader4["g"].ToString());

                    if (suhu < bb)
                    {
                        s_sedang = 0;
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
                    textBox8.Text = Convert.ToString(String.Format("{0:0.0}", s_sedang));


                    //высокий 2
                    suhu = Convert.ToDouble(textBox9.Text);
                    ee = Convert.ToDouble(reader4["e"].ToString());
                    hh = Convert.ToDouble(reader4["h"].ToString());
                    if (suhu < ee)
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
                    textBox7.Text = Convert.ToString(String.Format("{0:0.0}", s_tinggi));

                }
            }


            SQLiteConnection myConnection5;
            myConnection5 =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection5.Open();

            string query5 = "SELECT * FROM Var WHERE id='5'";

            SQLiteCommand command5 = new SQLiteCommand(query5, myConnection5);
            SQLiteDataReader reader5 = command5.ExecuteReader();
            while (reader5.Read())
            {

                {
                    //  for (int i = 0; i <= 0; i++)
                    //   {
                    //низкий 2
                    suhu = Convert.ToDouble(textBox9.Text);
                    aa = Convert.ToDouble(reader5["a"].ToString());
                    cc = Convert.ToDouble(reader5["c"].ToString());
                    if (suhu < aa)
                    {
                        s_rendah = 1;
                    }
                    if (suhu >= aa && suhu <= cc)
                    {
                        s_rendah = (cc - suhu) / (cc - aa);
                    }

                    if (suhu > cc)
                    {
                        s_rendah = 0;
                    }
                    textBox16.Text = Convert.ToString(String.Format("{0:0.0}", s_rendah));

                    // средний 2
                    suhu = Convert.ToDouble(textBox9.Text);
                    bb = Convert.ToDouble(reader5["b"].ToString());
                    dd = Convert.ToDouble(reader5["d"].ToString());
                    ff = Convert.ToDouble(reader5["f"].ToString());
                    gg = Convert.ToDouble(reader5["g"].ToString());

                    if (suhu < bb)
                    {
                        s_sedang = 0;
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
                    textBox15.Text = Convert.ToString(String.Format("{0:0.0}", s_sedang));


                    //высокий 2
                    suhu = Convert.ToDouble(textBox9.Text);
                    ee = Convert.ToDouble(reader5["e"].ToString());
                    hh = Convert.ToDouble(reader5["h"].ToString());
                    if (suhu < ee)
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
                    textBox14.Text = Convert.ToString(String.Format("{0:0.0}", s_tinggi));

                }
            }










            /*
                        //низкий
                        suhu = Convert.ToDouble(form2.textBox9.Text);
                        aa = Convert.ToDouble(form2.textBox1.Text);
                        cc = Convert.ToDouble(form2.textBox3.Text);
                        if (suhu < aa)
                        {
                            s_rendah = 1;
                        }
                        if (suhu >= aa && suhu <= cc)
                        {
                            s_rendah = (cc - suhu) / (cc - aa);
                        }

                        if (suhu > cc)
                        {

                            s_rendah = 0;
                        }
                        textBox10.Text = Convert.ToString(String.Format("{0:0.0}", s_rendah));

                        // средний 
                        suhu = Convert.ToDouble(form2.textBox9.Text);
                        bb = Convert.ToDouble(form2.textBox2.Text);
                        dd = Convert.ToDouble(form2.textBox4.Text);
                        ff = Convert.ToDouble(form2.textBox6.Text);
                        gg = Convert.ToDouble(form2.textBox7.Text);

                        if (suhu < bb)
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
                        form2.textBox11.Text = Convert.ToString(String.Format("{0:0.0}", s_sedang));

                        //высокий
                        suhu = Convert.ToDouble(form2.textBox9.Text);
                        ee = Convert.ToDouble(form2.textBox5.Text);
                        hh = Convert.ToDouble(form2.textBox8.Text);
                        if (suhu < ee)
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
                        form2.textBox12.Text = Convert.ToString(String.Format("{0:0.0}", s_tinggi));
            */











        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SQLiteConnection myConnection6;
            myConnection6 =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection6.Open();

            string query6 = "SELECT question FROM questions WHERE id='1'";

            SQLiteCommand command6 = new SQLiteCommand(query6, myConnection6);
            SQLiteDataReader reader6 = command6.ExecuteReader();
            while (reader6.Read())
            {
                label1.Text = reader6["question"].ToString();




            }

            string query7 = "SELECT question FROM questions WHERE id='2'";

            SQLiteCommand command7 = new SQLiteCommand(query7, myConnection6);
            SQLiteDataReader reader7 = command7.ExecuteReader();
            while (reader7.Read())
            {
                label2.Text = reader7["question"].ToString();




            }





        }
    }
}
