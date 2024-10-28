using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using System.Xml;

namespace İnterface
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        DataAccessLayer _dataAccessLayer = new DataAccessLayer();
        İtemListPage _itemListPage;
        public List<EntityLayer> _AllItemsList = new List<EntityLayer>();
        int _line_İndex = 0;
        int _RandomNumber = 0;
        int _TheTime = 0;
        bool _IsRandom = false;
        bool _IsShowAnswered = false;
        bool _IsSwitched = false;
        bool _IsAutoSlided = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _RandomNumber = random.Next(10, 100);

            for (int i = 0; i < _dataAccessLayer.GetAll().Count; i++)
            {
                _AllItemsList.Add(_dataAccessLayer.GetAll()[i]);
            }

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
            var result = (EntityLayer)_AllItemsList[_line_İndex];

            return result;
        }

        private EntityLayer Random()
        {
            var result = (EntityLayer)_AllItemsList[_RandomNumber];

            return result;
        }

        private int RandomNumberGenerator()
        {

            return _RandomNumber = random.Next(0, 90);
        }

        private EntityLayer ChosenMethod()
        {

            if (_IsRandom)
            {
                return Random();
            }
            return Line();
        }

        private void FinalResult(Int16 what)
        {
            if (what == 1)
            {
                if (ChosenMethod().Number == null || ChosenMethod().Number == 0)
                {
                    Thread.Sleep(100);
                    ChosenMethod();
                    if (ChosenMethod().Name == null || ChosenMethod().Number == 0)
                    {
                        MessageBox.Show("Please Slowly Press The Buttons");
                        ChosenMethod();
                    }
                }
                else
                {
                    Name_Lable.Text = string.Empty;
                    Number_Label.Text = ChosenMethod().Number.ToString();
                }


            }
            if (what == 2)
            {

                if (ChosenMethod().Name == null)
                {

                    Thread.Sleep(100);
                    ChosenMethod();
                    if (ChosenMethod().Name == null)
                    {
                        MessageBox.Show("Please Slowly Press The Buttons");
                        ChosenMethod();
                    }
                }
                else
                {
                    Number_Label.Text = string.Empty;
                    Name_Lable.Text = ChosenMethod().Name.ToUpper();
                }

            }
            if (what == 3)
            {
                if (ChosenMethod().Name == null || ChosenMethod().Number == 0)
                {
                    Thread.Sleep(100);
                    ChosenMethod();
                    if (ChosenMethod().Name == null || ChosenMethod().Number == 0)
                    {
                        MessageBox.Show("Please Slowly Press The Buttons");
                        ChosenMethod();
                    }
                }
                else
                {
                    Name_Lable.Text = ChosenMethod().Name.ToUpper();
                    Number_Label.Text = ChosenMethod().Number.ToString();
                }

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

            if (_IsShowAnswered)
            {
                FinalResult(3);
            }
            else
            {
                if (!_IsSwitched)
                {
                    FinalResult(1);
                }
                else
                {
                    FinalResult(2);
                }
            }

        }

        private void Reveal_Button_Click_1(object sender, EventArgs e)
        {
            Thread.Sleep(50);
            _AllItemsList = _dataAccessLayer.GetAll();
            FinalResult(3);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ++_TheTime;

            if (TimeNumber.Value == _TheTime) 
            {
                Timer.Stop();
                Timer.Enabled = false;
            }
            
            MessageBox.Show(_TheTime.ToString());
        }

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            _IsAutoSlided = AutoSlide_Checkbox.Checked;
            _IsRandom = Random_Checkbox.Checked;
            _IsShowAnswered = ShowAnswers_Checkbox.Checked;
            _IsSwitched = Switchitems_Checkbox.Checked;

            if (_IsAutoSlided == true)
            {
                if (TimeNumber.Value <=0)
                {
                    MessageBox.Show("The Given Number Cannot Be Less Or Equal To 0");
                    AutoSlide_Checkbox.Checked = false;
                    _IsAutoSlided = AutoSlide_Checkbox.Checked;
                }
                else
                {
                    Timer.Enabled = true;
                }
                
            }
            else 
            {
                Timer.Enabled = false;
            }
        }
    }
}
