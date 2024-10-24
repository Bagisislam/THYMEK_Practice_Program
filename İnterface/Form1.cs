using System.Data;

namespace İnterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccessLayer _dataAccessLayer = new DataAccessLayer();

            dataGridView1.DataSource = _dataAccessLayer.GetAll();
            // Hide the 'id' column
            if (dataGridView1.Columns["id"] != null)
            {
                dataGridView1.Columns["id"].Visible = false;
            }
            dataGridView1.Visible = true;
        }
    }
}
