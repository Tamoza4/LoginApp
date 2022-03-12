// Created By Tamoza
// www.tamoza.net

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        // Free move for The form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection connection;
            string server = "****"; // DataBase Domain
            string database = "****"; // DataBase Name
            string uid = "****"; // DataBase User Id
            string password = "****"; // DataBase User password
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    
                    MySqlCommand cmd = new MySqlCommand("insert into  Logindb (UserName,Name,Email,Password) values(@UserName,@Name,@Email,@Password)", connection);
                    cmd.Parameters.AddWithValue("@UserName", TextBoxUser.Text);
                    cmd.Parameters.AddWithValue("@Name", TextBoxName.Text);
                    cmd.Parameters.AddWithValue("@Email", TextBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", TextBoxPass.Text);
                    cmd.ExecuteNonQuery();
                    TextBoxUser.Enabled = false;
                    TextBoxName.Enabled = false;
                    TextBoxEmail.Enabled = false;
                    TextBoxPass.Enabled = false;
                    MessageBox.Show("Data entered succesfully.", "Register");

                    Login lo = new Login();
                    lo.Show();
                    Hide();
                    
                }
                else
                {
                    MessageBox.Show("Database connection failed.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured. Please try again later.");
                
            }

            connection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            Hide();
        }

        private void register_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
