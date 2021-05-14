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
    public partial class FrmTime : MetroFramework.Forms.MetroForm
    {
        public FrmTime()
        {
            InitializeComponent();
        }

        private void FrmTime_Load(object sender, EventArgs e)
        {
            {
                using (DataContext dataContext = new DataContext())
                {
                    timeBindingSource.DataSource = dataContext.Times.ToList();
                }
                pnlDatos.Enabled = false;
                Time time = timeBindingSource.Current as Time;
                if (time != null && time.Photo != null)
                    pctPhoto.Image = Image.FromFile(time.Photo);
                else
                    pctPhoto.Image = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctPhoto.Image = null;
            timeBindingSource.Add(new Time());
            timeBindingSource.MoveLast();
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtName.Focus();
            Time time = timeBindingSource.Current as Time;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            timeBindingSource.ResetBindings(false);
            FrmTime_Load(sender, e);
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Time time = timeBindingSource.Current as Time;
            if (time != null && time.Photo != null)
                pctPhoto.Image = Image.FromFile(time.Photo);
            else
                pctPhoto.Image = null;
        }
    }
}
