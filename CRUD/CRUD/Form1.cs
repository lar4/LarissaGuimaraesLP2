using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void addFunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFuncionario add = new AddFuncionario();
            add.ShowDialog();
        }

        private void sAIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        
    }
}
