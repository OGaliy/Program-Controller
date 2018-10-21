using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace EXE_Controler
{
    public partial class FinalTask : MetroForm
    {

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateWaitableTimer(IntPtr lpTimerAttributes, bool bManualReset, string lpTimerName);

        [DllImport("kernel32.dll")]
        public static extern bool SetWaitableTimer(IntPtr hTimer, [In] ref long pDueTime, int lPeriod, IntPtr pfnCompletionRoutine, IntPtr pArgToCompletionRoutine, bool fResume);

        [DllImport("kernel32", SetLastError = true, ExactSpelling = true)]
        public static extern Int32 WaitForSingleObject(IntPtr handle, uint milliseconds);
        
        static IntPtr handle;
        
        string connectionSql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Date.mdf;Integrated Security=True";

        Dictionary<string, string> ProgramList = new Dictionary<string, string>();

        public FinalTask()
        {
            InitializeComponent();
            ADD_PR.Hide();
            string sqlRead = "SELECT * FROM INFO";
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlRead, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read()) 
                    {                        
                        object name = reader["NAME"];
                        object road = reader["ROAD"];
                        ProgramList.Add(name.ToString(), road.ToString());
                        ProgramBox.Items.Add(name.ToString());
                    }
                }
                
                reader.Close();
            }
        }

        

        private void ADD_PROGRAM_Click(object sender, EventArgs e)
        {
            ADD_PR.Show();            
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            ADD_PR.Hide();
            Name_PR.Text = "";
            Road_PR.Text = "";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Name_PR.Text) || String.IsNullOrWhiteSpace(Road_PR.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                try
                {
                    Process.Start(Road_PR.Text);
                    ProgramList.Add(Name_PR.Text, Road_PR.Text);
                    string sqlAdd = String.Format("INSERT INTO INFO (NAME, ROAD) VALUES ('{0}', '{1}')", Name_PR.Text, Road_PR.Text);
                    using (SqlConnection connection = new SqlConnection(connectionSql))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlAdd, connection);
                        command.ExecuteNonQuery();
                    }
                    ADD_PR.Hide();
                    ProgramBox.Items.Add(Name_PR.Text);
                    Name_PR.Text = "";
                    Road_PR.Text = "";
                }
                catch(Exception k)
                {
                    MessageBox.Show(k.Message);
                }
            }
        }

        private void DELETE_PROGRAM_Click(object sender, EventArgs e)
        {
            string sqlDelete = String.Format("DELETE  FROM INFO WHERE NAME='{0}'", ProgramBox.Text);
            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlDelete, connection);
                command.ExecuteNonQuery();
            }

            ProgramBox.Items.Remove(ProgramBox.Text);
                        
        }

        private void GO_PROGRAM_Click(object sender, EventArgs e)
        {
            foreach(var k in ProgramList)
            {
                if(k.Key == ProgramBox.Text)
                {
                    Process.Start(k.Value);
                    break;
                }                
            }
        }

        private void HourOff_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void MinOff_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        public void ShutDownBut_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(MinOff.Text) || String.IsNullOrWhiteSpace(HourOff.Text))
            {
                MessageBox.Show("Не вiрно вказаний час!");
            }
            else
            {
                long time_min = Convert.ToInt32(MinOff.Text) * 60 * (long)Math.Pow(10, 7);
                long time_hours = Convert.ToInt32(HourOff.Text) * 3600 * (long)Math.Pow(10, 7);
                S_Down(-(time_min + time_hours));
                this.Hide();
            }            

        }        
        void S_Down(long duetime)
        {            
            handle = CreateWaitableTimer(IntPtr.Zero, true, "MyWaitabletimer");
            SetWaitableTimer(handle, ref duetime, 0, IntPtr.Zero, IntPtr.Zero, true);
            uint INFINITE = 0xFFFFFFFF;
            int ret = WaitForSingleObject(handle, INFINITE);
            Process.Start("cmd", "/c shutdown -s -f -t 00");
        }

        void Wake_Up(long duetime)
        {                
            handle = CreateWaitableTimer(IntPtr.Zero, true, "MyWaitabletimer");
            SetWaitableTimer(handle, ref duetime, 0, IntPtr.Zero, IntPtr.Zero, true);
            uint INFINITE = 0xFFFFFFFF;
            int ret = WaitForSingleObject(handle, INFINITE);
            foreach (var k in ProgramList)
            {
                if (k.Key == ProgramBox.Text)
                {
                    Process.Start(k.Value);
                    break;
                }
            }
            this.Close();
        }

        private void Hour_up_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Min_up_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void W_UP_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Min_up.Text) || String.IsNullOrWhiteSpace(Hour_up.Text))
            {
                MessageBox.Show("Не вiрно вказаний час!");
            }
            else
            {
                long time_min = Convert.ToInt32(Min_up.Text) * 60 * (long)Math.Pow(10, 7);
                long time_hours = Convert.ToInt32(Hour_up.Text) * 3600 * (long)Math.Pow(10, 7);
                Wake_Up(-(time_min + time_hours));
                this.Hide();                
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            string info = null;
            int i = 1;
            foreach(var k in ProgramList)
            {
                info += String.Format("Program {0}:\nName: {1}; Road: {2}.\n", i, k.Key, k.Value);
                i++;
            }
            MessageBox.Show(info);            
        }

        private void ProgramBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
