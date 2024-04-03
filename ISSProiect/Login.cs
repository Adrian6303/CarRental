using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISSProiect.service;
using ISSProiect.Domain;

namespace ISSProiect
{
    public partial class Login : Form
    {
        Service service;
        Sediu sediu;
        AlegeSediu alegeSediu;

        public Login(Service service, Sediu sediu, AlegeSediu alegeSediu)
        {
            this.service = service;
            this.sediu = sediu;
            this.alegeSediu = alegeSediu;
            InitializeComponent();
            Login_Load();

        }

        private void Login_Load()
        {
            LoginButton.Visible = true;
            NewAccountButton.Visible = true;
            BackButton.Visible = true;
            AlreadyHasAccountButton.Visible = false;
            SignUpButton.Visible = false;
            NumeTextBox.Visible = false;
            AdresaTextBox.Visible = false;
            TelefonTextBox.Visible = false;
            NumeLabel.Visible = false;
            AdresaLabel.Visible = false;
            TelefonLabel.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            alegeSediu.Show();
            this.Close();
        }

        private void NewAccountButton_Click(object sender, EventArgs e)
        {
            AlreadyHasAccountButton.Visible = true;
            NewAccountButton.Visible = false;
            SignUpButton.Visible = true;
            NumeTextBox.Visible = true;
            AdresaTextBox.Visible = true;
            TelefonTextBox.Visible = true;
            NumeLabel.Visible = true;
            AdresaLabel.Visible = true;
            TelefonLabel.Visible = true;
            LoginButton.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = service.findClient(Int32.Parse(UsernameTextBox.Text));
                if (client == null)
                {
                    MessageBox.Show("Clientul nu exista, creeaza client nou!");
                }
                else
                {
                    if (client.Parola == PasswordTextBox.Text)
                    {
                        UsernameTextBox.Clear();
                        PasswordTextBox.Clear();
                        Optiune optiune = new Optiune(service, sediu, client, this);
                        optiune.Text = client.Nume + ": Alege optiunea";
                        this.Hide();
                        optiune.Show();
                    }
                    else
                    {
                        MessageBox.Show("Parola gresita!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client(PasswordTextBox.Text, NumeTextBox.Text, AdresaTextBox.Text, TelefonTextBox.Text);
                client.Id = Int32.Parse(UsernameTextBox.Text);
                service.addClient(client);
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
                NumeTextBox.Clear();
                AdresaTextBox.Clear();
                TelefonTextBox.Clear();
                Optiune optiune = new Optiune(service, sediu, client, this);
                optiune.Text = "Alege optiunea";
                this.Hide();
                optiune.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AlreadyHasAccountButton_Click(object sender, EventArgs e)
        {
            Login_Load();
        }
    }
}
