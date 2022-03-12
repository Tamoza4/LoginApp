// Created By Tamoza
// www.tamoza.net

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Login : Form
    {

        // please put your database details in Login and register forms -- replace "****" to your details

        MySqlConnection con = new MySqlConnection(@"
        Data Source=****;
        Initial Catalog=****; 
        User Id=****;
        password=****");
        
        int i;

        public Login()
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                i = 0;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Logindb where UserName= '" + TextUserName.Text + "' and password= '" + TextPass.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());


                if (i == 0)
                {
                    TextLoginError.Text = "User name or Password is invalid, Please contact the support";
                }
                else
                {
                    btnLogin.Enabled = false;
                    TextLoginError.ForeColor = Color.Green;
                    this.TextLoginError.Text = "                                   connecting.";
                    progressBar1.Visible = true;
                    this.timer1.Start();
                    await Task.Delay(1000);
                    this.TextLoginError.Text = "                                   connecting..";
                    await Task.Delay(1000);
                    this.TextLoginError.Text = "                                   connecting...";
                    await Task.Delay(1000);
                    this.TextLoginError.Text = "                                   connected";
                    await Task.Delay(500);
                    //await Task.Delay(3000);
                    Welcome welc = new Welcome();
                    welc.Show();
                    Hide();
                }

                con.Close();

            }
            catch
            {
                TextLoginError.Text = "Error with Database";
            }


            if (checkSaveLogin.Checked)
            {
                // Saveing Login detiles as config.txt file in program folder
                System.IO.File.WriteAllText("Config.txt",
                                this.TextUserName.Text.ToString()
                                + System.Environment.NewLine
                                + this.TextPass.Text.ToString()
                                + System.Environment.NewLine
                                + this.checkSaveLogin.Checked.ToString());
            }
            else
            {
                System.IO.File.Delete("Config.txt");
            }





            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin; // Enter key triggering the Login button 

            // Load the login detiles from config.txt file
            try
            {
                var TextLine1 = File.ReadLines("config.txt").Skip(0).First();
                TextUserName.Text = TextLine1;
                var TextLine2 = File.ReadLines("config.txt").Skip(1).First();
                TextPass.Text = TextLine2;
                var TextLine3 = File.ReadLines("config.txt").Skip(2).First();
                checkSaveLogin.Checked = bool.Parse(TextLine3);
            }
            catch
            {

            }


        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tamozaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            register regi = new register();
            regi.Show();
            Hide();
        }
    }
}
