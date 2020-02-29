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
    public partial class addProduct : Form
    {
        //Имена магазина и офиса
        string shop_name;
        string office_name;
        //Конструктор
        public addProduct(string _shop, string _office)
        {
            InitializeComponent();
            shop_name = _shop;
            office_name = _office;
            //Заполняем бокс стандартными типами товаров
            ProductsTypeCol cln = new ProductsTypeCol();
            foreach(ProductType type in cln)
            {
                BoxType.Items.Add(type.Name);
            }
        }
        //Нажатие на кнопку "Добавить"
        private void Accept_btm_Click(object sender, EventArgs e)
        {
            //Если поля заполнены
            if (numCost.Value > 0 &&
                numCount.Value > 0 &&
                txtInfo.TextLength > 0 &&
                txtName.TextLength > 0 &&
                txtPlace.TextLength > 0 &&
                BoxType.Text != "")
            {
                //Заполняем
                Product product = new Product(txtPlace.Text,txtInfo.Text,txtName.Text, (int)numCount.Value, (int)numCost.Value, BoxType.Text);
                //Добавляем
                BdControler.addProduct(office_name, shop_name,product);
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
