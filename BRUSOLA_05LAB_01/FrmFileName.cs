using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BRUSOLA_05LAB_01
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {

        }

        private void Okay_Click_Click(object sender, EventArgs e)
        {
            SetFileName = FileName.Text + ".txt";
            this.Close();
        }
    }
}
