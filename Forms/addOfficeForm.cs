using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilShopNet
{
    public partial class addOfficeForm : Form
    {
        public addOfficeForm()
        {
            InitializeComponent();
        }
        //Нажатие на кнопку "Добавить"
        private void Accept_btm_Click(object sender, EventArgs e)
        {
            //Если поля заполнены
            if( txtContry.TextLength > 0 &&
                txtEmail.TextLength > 0 &&
                txtHouse.TextLength > 0 &&
                txtOfficeName.TextLength > 0 &&
                txtRegion.TextLength > 0 &&
                txtStreet.TextLength > 0 &&
                txtTown.TextLength > 0 &&
                txtWeb.TextLength > 0)
            {
                MobilShopTownOffice office = new MobilShopTownOffice();
                //Заполняем
                office.Country = txtContry.Text;
                office.Email = txtEmail.Text;
                office.House = txtHouse.Text;
                office.Name = txtOfficeName.Text;
                office.Region = txtRegion.Text;
                office.Street = txtStreet.Text;
                office.Town = txtTown.Text;
                office.Web = txtWeb.Text;
                //Добавляем
                BdControler.AddOffice(office);
                //Закрываем
                Close();
            }
            //Если есть пустое поле
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
