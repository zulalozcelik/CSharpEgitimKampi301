using CSharpEgitimKampi301.EFProject.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities2 db = new EgitimKampiEfTravelDbEntities2();
        private void btnList_Click(object sender, EventArgs e)
        {
            
            var values = db.C_Guide.ToString();
            dataGridView1.DataSource = values;

          
        }
    }
}
