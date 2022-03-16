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
            string rutaDirectorio = string.Empty;

            FolderBrowserDialog fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = fdb.SelectedPath;
            }

            DirectoryInfo di = new DirectoryInfo(@rutaDirectorio);
            foreach (var item in di.GetFiles())
            {
                treeView1.Nodes.Add(item.Name);

            }
            openFileDialog1.ShowDialog();
            System.IO.StreamReader Abrir = new System.IO.StreamReader(openFileDialog1.FileName);
            rtbNotas.Text = Abrir.ReadToEnd();
            Abrir.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter myStreamWriter = null;
            try
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    myStreamWriter = System.IO.File.AppendText(openFileDialog1.FileName);
                    myStreamWriter.Write(rtbNotas.Text);
                    myStreamWriter.Flush();
                    myStreamWriter.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarComo = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            guardarComo.Filter = "Text (*.txt)| *.txt";
            guardarComo.Title = "GUARDAR COMO";
            guardarComo.ShowDialog(this);
            try
            {
                if (File.Exists(guardarComo.FileName))
                {
                    myStreamWriter = System.IO.File.AppendText(guardarComo.FileName);
                    myStreamWriter.Write(rtbNotas.Text);
                    myStreamWriter.Flush();
                    myStreamWriter.Close();
                }
                else
                {
                    myStreamWriter = System.IO.File.AppendText(guardarComo.FileName);
                    myStreamWriter.Write(rtbNotas.Text);
                    myStreamWriter.Flush();
                    myStreamWriter.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

    }
}
