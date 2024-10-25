using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnterface
{
    public partial class İtemListPage : Form
    {
        DataAccessLayer _dataAccessLayer = new DataAccessLayer();
        public İtemListPage()
        {
            InitializeComponent();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            var data = (List<EntityLayer>)dataGridView1.DataSource;

            _dataAccessLayer.Save(data);
            MessageBox.Show("Data saved successfully!");
           
            Visible = false;
        }

        private void İtemListPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            if (_dataAccessLayer.GetAll() != null)
            {
                dataGridView1.DataSource = _dataAccessLayer.GetAll();
            }
            if (dataGridView1.Columns["number"] != null)
            {
                dataGridView1.Columns["number"].ReadOnly = true;
            }
            
            if (dataGridView1.Columns["id"] != null)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
            
        }
    }
}
