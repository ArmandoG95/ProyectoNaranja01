using ProyectoNaranja.Entities;
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
    public partial class FrmCoordinator : MetroFramework.Forms.MetroForm
    {
        public FrmCoordinator()
        {
            InitializeComponent();
        }

        private void FrmCoordinator_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                coordinatorBindingSource.DataSource = dataContext.Coordinators.ToList();
            }
            pnlDatos.Enabled = false;
            Coordinator coordinator= coordinatorBindingSource.Current as Coordinator;
            if (coordinator != null && coordinator.Photo != null)
                pctPhoto.Image = Image.FromFile(coordinator.Photo);
            else
                pctPhoto.Image = null;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctPhoto.Image = null;
            coordinatorBindingSource.Add(new Coordinator());
            coordinatorBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtFirstName.Focus();
            Coordinator coordinator = coordinatorBindingSource.Current as Coordinator; 
        }
    }
}
