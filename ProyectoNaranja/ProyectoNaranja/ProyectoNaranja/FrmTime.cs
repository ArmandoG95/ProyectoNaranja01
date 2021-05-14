using ProyectoNaranja.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                using (OpenFileDialog ofd = new OpenFileDialog()
                {
                    Filter = "archivos .JPG|*.jpg|todos los archivos|*.*"
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pctPhoto.Image = Image.FromFile(ofd.FileName);
                        Time time = timeBindingSource.Current as Time;
                        if (time != null)
                            time.Photo = ofd.FileName;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                using (DataContext dataContext = new DataContext())
                {
                    Time time = timeBindingSource.Current as Time;
                    if (time != null)
                    {
                        if (dataContext.Entry<Time>(time).State == EntityState.Detached)
                            dataContext.Set<Time>().Attach(time);
                        if (time.ID == 0)
                            dataContext.Entry<Time>(time).State = EntityState.Added;
                        else
                            dataContext.Entry<Time>(time).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos guardados");
                        grdDatos.Refresh();
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }
    }
}
