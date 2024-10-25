using System.Data;
using System.Windows.Forms;

namespace İnterface
{
    public partial class Form1 : Form
    {
        DataAccessLayer _dataAccessLayer = new DataAccessLayer();
        İtemListPage _itemListPage;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Open_List_Button_Click(object sender, EventArgs e)
        {
            _itemListPage = new İtemListPage();
            if (!_itemListPage.IsDisposed)
            {
                _itemListPage.Show();
            }
            else
            {
                _itemListPage = new İtemListPage();
                _itemListPage.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}
