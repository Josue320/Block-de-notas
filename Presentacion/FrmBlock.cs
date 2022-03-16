using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmBlock : Form
    {
        public FrmBlock()
        {
            InitializeComponent();
        }
    

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String Datos = rtbNotas.Text;

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNotas.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            System.IO.StreamReader Abrir = new System.IO.StreamReader(openFileDialog1.FileName);
            rtbNotas.Text = Abrir.ReadToEnd();
            Abrir.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            System.IO.StreamWriter Guardar = new System.IO.StreamWriter(saveFileDialog1.FileName);
            Guardar.WriteLine(rtbNotas.Text);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarComo = new SaveFileDialog();
            //System.IO.StreamWriter myStreamWriter = null;
            guardarComo.Filter = "Text (*.txt)|";
            guardarComo.CheckFileExists = true;
            guardarComo.Title = "GUARDAR COMO";
            guardarComo.ShowDialog(this);
            //try
            //{
            //    myStreamWriter = System.IO.File.AppendText(guardarComo.FileName);
            //    myStreamWriter.Write(rtbNotas.Text);
            //    myStreamWriter.Flush();
            //}
            //catch(Exception)
            //{

            //}
        }

    }
}
