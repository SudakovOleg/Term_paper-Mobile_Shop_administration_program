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
    public partial class deleteProduct : Form
    {
        string shop;
        string office;
        public deleteProduct(string _shop, string _office)
        {
            InitializeComponent();
            shop = _shop;
            office = _office;
        }
        //Нажатие на кнопку "Удалить"
        private void DeleteBtm_Click(object sender, EventArgs e)
        {
            //Если поля заполнены
            if (txtProduct.TextLength > 0)
            {
                //Удаляем
                BdControler.deleteProduct(office, shop, txtProduct.Text);
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
