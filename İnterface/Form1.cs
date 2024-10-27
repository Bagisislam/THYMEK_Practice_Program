using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Xml;

namespace İnterface
{
    public partial class Form1 : Form
    {
        DataAccessLayer _dataAccessLayer = new DataAccessLayer();
        İtemListPage _itemListPage;
        int _line_İndex = 0;
        int _RandomNumber = 0;

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!Switchitems_Checkbox.Checked)
            {
                FinalResult(1);
            }
            else
            {
                FinalResult(2);
            }

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


            var result = (EntityLayer)_dataAccessLayer.GetAll()[_RandomNumber];

            return result;


        }

        private int RandomNumberGenerator()
        {
            Thread.Sleep(100);
            Random random = new Random();
            if (_RandomNumber < 100 && _RandomNumber > 9)
            {
                var result = random.Next(10, 100);
                return result;
            }

            return _RandomNumber = random.Next(40, 80);
        }

        private EntityLayer ChosenMethod()
        {

            if (Random_Checkbox.Checked)
            {
                return Random();
            }
            return Line();
        }

        private void FinalResult(Int16 what)
        {
            if (what == 1)
            {

                Name_Lable.Text = string.Empty;
                Number_Label.Text = ChosenMethod().Number.ToString();
            }
            if (what == 2)
            {

                Number_Label.Text = "";
                Name_Lable.Text = ChosenMethod().Name.ToUpper();
            }
            if (what == 3)
            {

                Name_Lable.Text = ChosenMethod().Name.ToUpper();
                Number_Label.Text = ChosenMethod().Number.ToString();
            }
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);

            _RandomNumber = RandomNumberGenerator();

            _line_İndex++;
            if (_line_İndex >= 90)
            {
                _line_İndex = 0;
            }
            _RandomNumber = RandomNumberGenerator();

            if (!Switchitems_Checkbox.Checked)
            {
                FinalResult(1);
            }
            else
            {
                FinalResult(2);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show(Random_Checkbox.Checked.ToString());
        }

        private void Reveal_Button_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            FinalResult(3);
        }
    }


}
