using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimbingWall
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string whereStatement = formWhereStatement();
            DataTable dataset = Database.Instance.searchDatabase("climbing_wall.employee", whereStatement);
            try
            {
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataset;
                tableDataView.DataSource = bSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private string formWhereStatement()
        {
            string whereStatement = "";
            //logic
            
            return whereStatement;
        }
    }
}
