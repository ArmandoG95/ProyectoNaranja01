using ProyectoNaranja.Entities;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoNaranja
{
    public partial class FrmCoach : MetroFramework.Forms.MetroForm
    {
        public FrmCoach()
        {
            InitializeComponent();
        }

        private void FrmCoach_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                coachBindingSource.DataSource = dataContext.Coaches.ToList();
            }
            pnlDatos.Enabled = false;
            Coach coach = coachBindingSource.Current as Coach;
            if (coach != null && coach.Photo != null)
                pctCoach.Image = Image.FromFile(coach.Photo);
            else
                pctCoach.Image = null;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            pctCoach.Image = null;
            coachBindingSource.Add(new Coach());
            coachBindingSource.MoveLast();
            txtFirstName.Focus();
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = true;
            txtFirstName.Focus();
            Coach coach = coachBindingSource.Current as Coach;
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            pnlDatos.Enabled = false;
            coachBindingSource.ResetBindings(false);
            FrmCoach_Load(sender, e);
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Coach coach = coachBindingSource.Current as Coach;
            if (coach != null && coach.Photo != null)
                pctCoach.Image = Image.FromFile(coach.Photo);
            else
                pctCoach.Image = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "archivos .JGP|*.jpg|todos los archivos|*.*"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctCoach.Image = Image.FromFile(ofd.FileName);
                    Coach coach = coachBindingSource.Current as Coach;
                    if (coach != null)
                        coach.Photo = ofd.FileName;
                }
            }
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            {
                using (DataContext dataContext = new DataContext())
                {
                    Coach coach = coachBindingSource.Current as Coach;
                    if (coach != null)
                    {
                        if (dataContext.Entry<Coach>(coach).State == EntityState.Detached)
                            dataContext.Set<Coach>().Attach(coach);
                        if (coach.ID == 0)
                            dataContext.Entry<Coach>(coach).State = EntityState.Added;
                        else
                            dataContext.Entry<Coach>(coach).State = EntityState.Modified;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos guardados");
                        grdDatos.Refresh();
                        pnlDatos.Enabled = false;
                    }
                }
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Quieres eliminar al asesor?") == DialogResult.OK)
            {
                using (DataContext dataContext = new DataContext())
                {
                    Coach coach = coachBindingSource.Current as Coach;
                    if (coach != null)
                    {
                        if (dataContext.Entry<Coach>(coach).State == EntityState.Detached)
                            dataContext.Set<Coach>().Attach(coach);
                        dataContext.Entry<Coach>(coach).State = EntityState.Deleted;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Datos Eliminados");
                        coachBindingSource.RemoveCurrent();
                        pctCoach.Image = null;
                        pnlDatos.Enabled = false;
                    }
                }

            }
        }
    }
}
