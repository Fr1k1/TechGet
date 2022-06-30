using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechGet.Models;
using TechGet.Repositories;

namespace TechGet
{
    public partial class FrmLogin : Form
    {

        public static Employee LoggedEmployee { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
        }

     

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoggedEmployee = EmployeeRepository.GetEmployee(txtUsername.Text);

            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                if (LoggedEmployee != null && LoggedEmployee.CheckPassword(txtPassword.Text))
                {
                    FrmInput frmInput = new FrmInput();
                    Hide();
                    frmInput.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }


    }

