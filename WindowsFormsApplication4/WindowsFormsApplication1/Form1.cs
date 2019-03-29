using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace WindowsFormsApplication1
{
    public partial class frmOperaciones : Form
    {
        Operacion ingreso;
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ingreso = new Operacion();
            ingreso.V1 = double.Parse(txtValA.Text);
            ingreso.V2 = double.Parse(txtValB.Text);
            txtResul.Text = ingreso.Calcular().ToString();
            
        }
    }
}
