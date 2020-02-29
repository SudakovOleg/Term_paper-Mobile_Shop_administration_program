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
    public partial class addShopToOffice : Form
    {
        public addShopToOffice()
        {
            InitializeComponent();
        }
        //Нажатие на кнопку "Добавить"
        private void Accept_btm_Click(object sender, EventArgs e)
        {
            //Если поля заполнены
            if ( txtBoss.TextLength > 0 &&
                txtEmail.TextLength > 0 &&
                txtOfficeName.TextLength > 0 &&
                txtPhone.TextLength > 0 &&
                txtShopName.TextLength > 0)
            {
                MobilShop shop = new MobilShop();
                //Заполняем
                shop.BossName = txtBoss.Text;
                shop.Email = txtEmail.Text;
                shop.Name = txtShopName.Text;
                shop.Phone = txtPhone.Text;
                //Добавляем
                BdControler.AddShopInOffice(txtOfficeName.Text, shop);
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
