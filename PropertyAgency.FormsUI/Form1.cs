using System;
using System.Linq;
using System.Windows.Forms;
using PropertyAgency.DataAccess.Concrete.EntityFramework;
using PropertyAgency.Entities.Concrete;
using PropertyAgencyBusiness.Abstract;
using PropertyAgencyBusiness.Concrete;

namespace PropertyAgency.FormsUI
{
    public partial class Form1 : Form
    {
        private IHouseService _houseService;
        private IKindService _kindService;
        private ICityService _cityService;
        private ICustomerService _customerService;
        public Form1()
        {
            _houseService = new HouseManager(new EfHouseDal());
            _kindService = new KindManager(new EfKindDal());
            _cityService = new CityManager(new EfCityDal());
            _customerService = new CustomerManager(new EfCustomerDal());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadHouses();
        }
        private void LoadHouses()
        {
            dgwHouses.DataSource = _houseService.GetAll().ToList();
        }

        private void ClearTextBoxes()
        {
            tbxAdressAdd.Text = "";
            tbxAreaAdd.Text = "";
            tbxRoomsAdd.Text = "";
            tbxFloorAdd.Text = "";
            tbxKindIdAdd.Text = "";
            tbxPriceAdd.Text = "";
            tbxCityIdAdd.Text = "";
            tbxCustomerIdAdd.Text = "";

            tbxAdressUpdate.Text = "";
            tbxAreaUpdate.Text = "";
            tbxRoomsUpdate.Text = "";
            tbxFloorUpdate.Text = "";
            tbxKindIdUpdate.Text = "";
            tbxPriceUpdate.Text = "";
            tbxCityIdUpdate.Text = "";
            tbxCustomerIdUpdate.Text = "";
        }
        private void dgwHouses_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _houseService.Add(new House()
            {
                Adress = tbxAdressAdd.Text,
                Rooms = Convert.ToInt16(tbxRoomsAdd.Text),
                Floor = Convert.ToInt16(tbxAreaAdd.Text),
                Area = Convert.ToInt16(tbxAreaAdd.Text),
                Price = Convert.ToDecimal(tbxPriceAdd.Text),
                KindId = Convert.ToInt16(tbxKindIdAdd.Text),
                CityId = Convert.ToInt32(tbxCityIdAdd.Text),
                CustomerId = Convert.ToInt32(tbxCustomerIdAdd.Text)
            });
            LoadHouses();
            MessageBox.Show("Announcement Added!", "Message!");
            ClearTextBoxes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _houseService.Update(new House()
            {
                Id = (int)dgwHouses.CurrentRow.Cells[0].Value,
                Adress = tbxAdressUpdate.Text,
                Rooms = Convert.ToInt16(tbxRoomsUpdate.Text),
                Floor = Convert.ToInt16(tbxFloorUpdate.Text),
                Area = Convert.ToInt16(tbxAreaUpdate.Text),
                Price = Convert.ToDecimal(tbxPriceUpdate.Text),
                KindId = Convert.ToInt16(tbxKindIdUpdate.Text),
                CityId = Convert.ToInt16(tbxCityIdUpdate.Text),
                CustomerId = Convert.ToInt32(tbxCustomerIdUpdate.Text)
            });
            LoadHouses();
            MessageBox.Show("Announcement Updated!", "Message!");
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _houseService.Delete(new House()
            {
                Id = (int)dgwHouses.CurrentRow.Cells[0].Value,
            });
            LoadHouses();
            MessageBox.Show("Announcement Deleted!", "Message!");
        }
    }
}
