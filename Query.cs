using FullProgram;
using System;

using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ChameleonProject
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        ROGGIO2Entities db = new ROGGIO2Entities();

        public DateTime FechaCaja { get; private set; }
        public DateTime FechaClasificadaHasta { get; private set; }

        private void showMessage(string msg, int duration)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duration;
                time.Tick += timeTick;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(msg);
            }
        }

        private void timeTick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        }

        private bool Exist()
        {
            int box = Convert.ToInt32(txtCaja.Text);
            var exist = db.InventarioCajas.SingleOrDefault(a => a.CAJ_Id == box);
            if (exist == null)
            {
                return false;
            }
            else { return true; }
        }

        private void txtCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                button1.PerformClick();
            }


        }




       
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

            InventarioCaja inventario = new InventarioCaja();


            if (txtCaja.Text != "")
            {


                if (!Exist())
                {
                    int caja = Convert.ToInt32(txtCaja.Text);
                    var fechaCargaCaja = db.Cajas.Where(l => l.CAJ_Id == caja).Select(l => l.CAJ_FecCarga).SingleOrDefault();                    
                    FechaCaja = Convert.ToDateTime(fechaCargaCaja);
                    //fechaCargaHastaClasificacion = Convert.ToDateTime(fechaCargaHastaClasificacion);

                    var date = new DateTime(2015, 12, 31);
                    var isValid = db.Clasificadas.Any(c => c.CAJ_Id == caja && c.CLA_FecHa <= date);





                    if (fechaCargaCaja <= date)
                    {
                        inventario.CAJ_Id = caja;
                        inventario.Retirado = true;
                        inventario.FechaCarga = DateTime.Now;
                        db.InventarioCajas.Add(inventario);
                        db.SaveChanges();
                        showMessage("Esta caja es para enviar a Interfile", 2000);
                        dgvAD.Rows.Add(txtCaja.Text, inventario.Retirado == true ? "Si" : "No", inventario.FechaCarga);
                        txtCaja.Text = "";

                    }

                    //else if (fechaCargaHastaClasificacion != null && fechaCargaHastaClasificacion <= date)
                    //{
                    //    inventario.CAJ_Id = caja;
                    //    inventario.Retirado = true;
                    //    inventario.FechaCarga = DateTime.Now;
                    //    db.InventarioCajas.Add(inventario);
                    //    db.SaveChanges();
                    //    showMessage("Esta caja es para enviar a Interfile", 2000);
                    //    dgvAD.Rows.Add(txtCaja.Text, inventario.Retirado == true ? "Si" : "No", inventario.FechaCarga);
                    //    txtCaja.Text = "";
                    //}
                    //else
                    //{
                    //    inventario.CAJ_Id = caja;
                    //    inventario.Retirado = false;
                    //    inventario.FechaCarga = DateTime.Now;
                    //    db.InventarioCajas.Add(inventario);
                    //    db.SaveChanges();
                    //    showMessage("Esta caja es para dejar en Roggio", 2000);
                    //    dgvAD.Rows.Add(txtCaja.Text, inventario.Retirado == true ? "Si" : "No", inventario.FechaCarga);
                    //    txtCaja.Text = "";
                    //}
                }
                else
                {
                    showMessage("Ya se cargo anteriormente.", 2000);
                    txtCaja.Text = "";
                    return;
                  
                }
              

            }
        }

        private void StartProgram(object sender, EventArgs e)
        {
            txtCaja.Focus();
        }
    }
}
