using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaCodeCreate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitForm();
        }

        List<String> dbTypes = new List<string> { "MySql", "Oracle", "Sql Server" };

        private void InitForm()
        {
            this.cbxDbType.DataSource = dbTypes;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {

        }

        private void btnModelFile_Click(object sender, EventArgs e)
        {

        }

        private void btnMappingFile_Click(object sender, EventArgs e)
        {

        }

        private void btnDaoFile_Click(object sender, EventArgs e)
        {

        }

        private void btnJarFile_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCfg_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {

        }
    }
}
