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
    public partial class Form1 : Form
    {

       Form2 form2 = new Form2();
     //   Form3 form3 = new Form3();
    //   Ориентир form4 = new Ориентир();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
    private void LoadData()
        {
            SQLiteConnection myConnection;
            myConnection =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            myConnection.Open();

            string query = "SELECT * FROM Var";

            SQLiteCommand command = new SQLiteCommand(query, myConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
        
            while (reader.Read())
            {


                //  label2.Text = reader.GetValue(0).ToString();
              
           



                textBox1.Text += " "+reader["a"].ToString()+"\n";
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();


                for (int i = 0; i <= 3; i++)
                {
                    label2.Text +=' ' + reader.GetValue(0 + i).ToString(); //вывод строки - всех строк
                }



             
                //   data[data.Count - 1][6] = reader[6].ToString();
                //    data.Add(reader.GetString(0));
                //   label3.Text = data[data.Count - 1][1] = reader[1].ToString();
            }


            //     label3.Text = Convert.ToString(dataGridView2.Rows.Count);




          //  label2.Text = reader[1].ToString();


            reader.Close();
            myConnection.Close();



            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);
            label3.Text = Convert.ToString(dataGridView2.Rows.Count); //Вывести в Label число записей
                                                                      //      label2.Text = command.Rows[0].ToString(); ;
                                                                      //  for (int i = 0; i <= 3; i++)
                                                                      //  {
                                                                      //     label4.Text = (dataGridView2[1, 2 + i].Value.ToString());
        }
        //   if (reader.Read()) { Console.ReadLine(); }
        // }

        //combobox.items.add(datagrid[j, i].value.toString())
        /*      for (int i = 0; i <= 5; i++)
              {
                  label4.Text = (dataGridView2[1, 0+i].Value.ToString());
                  if (label4.Text=="") { Console.ReadLine(); }
              }
          }

      */








        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection myConnection;
            myConnection =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");
       

    
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            SQLiteConnection myConnection;
       
            myConnection =
new SQLiteConnection("Data Source=TestDB.db;Version=3;");

            myConnection.Open();
   /*
            string Имя = textBox3.Text;
            string Фамилия = textBox2.Text;
            string Группа = textBox3.Text;
            string Вопрос = textBox2.Text;
            string query = "INSERT INTO Ответ(Имя, Фамилия, Группа, Вопрос) " +
             "Values('" + Имя + "', '" + Фамилия + "', '" + Группа + "', '" + Вопрос + "')";

            SQLiteCommand command = new SQLiteCommand(query, myConnection);
           
            command.ExecuteNonQuery();
            */
            myConnection.Close();





        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            form2.textBox1.Text = "11";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
  
        private void button4_Click(object sender, EventArgs e)
        {
            Ориентир form4 = new Ориентир();
            this.Hide();
           
            form4.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
           this.Hide();
         
            form3.ShowDialog();
            this.Show();
        }



    }
    }




