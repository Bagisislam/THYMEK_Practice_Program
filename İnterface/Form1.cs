using System.Data;
using System.Windows.Forms;

namespace İnterface
{
    public partial class Form1 : Form
    {
        DataAccessLayer _dataAccessLayer = new DataAccessLayer();
        İtemListPage _itemListPage;
        int _line_İndex = 0;

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Name_Lable.Text = Line().Name.ToUpper();
            Number_Label.Text = Line().Number.ToString();
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

        private EntityLayer Line()
        {
            
            var result = (EntityLayer)_dataAccessLayer.GetAll()[_line_İndex];

            return result;
        }

        private EntityLayer Random()
        {
            Random random = new Random();

            var result = (EntityLayer)_dataAccessLayer.GetAll()[random.Next(10,100)];

            return result;
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            _line_İndex++;
            if (_line_İndex >= 90)
            {
                _line_İndex = 0;
            }

            Name_Lable.Text = Line().Name.ToUpper();
            Number_Label.Text = Line().Number.ToString();
            
        }
    }


}
