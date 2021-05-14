using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNaranja
{
    public partial class Form1 : MetroFramework.Forms.MetroForm 
    { 
        public Form1()
        { 
            InitializeComponent();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            FrmTime frmTime = new FrmTime();
            frmTime.Show();
        }

        private void btnAdviser_Click(object sender, EventArgs e)
        {
            FrmAdviser frmAdviser = new FrmAdviser();
            frmAdviser.Show();
        }

        private void btnCoach_Click(object sender, EventArgs e)
        {
            FrmCoach frmCoach = new FrmCoach();
            frmCoach.Show();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            FrmCompany frmCompany = new FrmCompany();
            frmCompany.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            FrmContact frmContact = new FrmContact();
            frmContact.Show();
        }

        private void btnCoordinator_Click(object sender, EventArgs e)
        {
            FrmCoordinator frmCoordinator = new FrmCoordinator();
            frmCoordinator.Show();
        }

        private void btnMajor_Click(object sender, EventArgs e)
        {
            FrmMajor frmMajor = new FrmMajor();
            frmMajor.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            FrmStudent frmStudent = new FrmStudent();
            frmStudent.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
