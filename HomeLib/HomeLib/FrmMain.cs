using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HomeLib
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        
        private void ouvrirDossierFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pathFilm = "";

            FolderBrowserDialog DossierFilm = new FolderBrowserDialog();
            DossierFilm.ShowDialog();

            pathFilm =  DossierFilm.SelectedPath;
            

            DirectoryInfo dir = new DirectoryInfo(pathFilm);
            FileInfo[] fichiers = dir.GetFiles();
            TxtBxListFichier.ScrollBars = ScrollBars.Vertical;
            foreach (FileInfo fichier in fichiers)
            {
                
                TxtBxListFichier.AppendText(fichier.Name+"\n\n");
            }
          
        }
    }
}
