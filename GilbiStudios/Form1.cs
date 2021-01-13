using System;
using System.Data;
using System.Windows.Forms;

namespace GilbiStudios
{
    public partial class Form1 : Form
    {
        string consulta = "";
        DataSet ds = new DataSet();
        private TextBox[] txtNew = new TextBox[10];
        TextBox txt0, txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9;
        public Form1()
        {
            InitializeComponent();
            txt0 = txt1 = txt2 = txt3 = txt4 = txt5 = txt6 = txt7 = txt8 = txt9 = new TextBox();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            consulta = "DELETE FROM Idea where idIdea = 6";
            Datos.EjecutarConsulta(consulta);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            ds = new DataSet();
            consulta = "SELECT * FROM " + cbTabla.Text + " WHERE estatus = 1";
            if (cbTabla.Text == "-Selecione la tabla-")
            {
                MessageBox.Show("Por favor seleccione una tabla o base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Datos.AgregarDataTable(ds, consulta, "ListasActivas");
            dataGridView1.DataSource = ds.Tables["ListasActivas"];
        }
    }
}
