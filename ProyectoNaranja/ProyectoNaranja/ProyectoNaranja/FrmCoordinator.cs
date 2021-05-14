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
                coordinatorBindingSource.DataSource = dataContext.Students.ToList();
            }
            pnlDatos
        }
    }
}
