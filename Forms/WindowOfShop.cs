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
    public partial class WindowOfShop : Form
    {
        //Контролер
        shopControler control;
        //Выбранный магазин
        MobilShop shop;
        //Конструктор
        public WindowOfShop(MobilShopTownOffice office, MobilShop _shop)
        {
            InitializeComponent();
            //Инициализация магазина
            shop = new MobilShop();
            shop = _shop;
            //Вывод информации
            lblForName.Text = shop.Name;
            lblForBoss.Text = shop.BossName;
            lblForPhone.Text = shop.Phone;
            lblForEmail.Text = shop.Email;
            this.Text = shop.Name;
            //Обработчик события обновления
            control = new shopControler(shop, office.Name);
            control.update += UpdateTable;
            //Настройка таблицы
            table.GridLines = true;
            table.View = View.Details;
            table.Columns.Add("Название");
            table.Columns.Add("Количество");
            table.Columns.Add("Цена");
            table.Columns.Add("Тип товара");
            table.Columns.Add("Местоположение");
            table.Columns.Add("Информация");
            for(int i = 0; i < table.Columns.Count; i++)
                table.Columns[i].Width = 80;

            foreach (Product product in shop.GetProductList())
            {
                ListViewItem item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Count.ToString());
                item.SubItems.Add(product.Cost.ToString());
                item.SubItems.Add(product.Type.Name);
                item.SubItems.Add(product.Place);
                item.SubItems.Add(product.DataInfo);
                table.Items.Add(item);
            }
        }
        //Обработка клика на кнопку удаления магазина
        private void BtmDeleteShop_Click(object sender, EventArgs e)
        {
            control.deleteShop();
            Close();
        }
        //Обработка клика на кнопку добавления товара
        private void BtmAddProduct_Click(object sender, EventArgs e)
        {
            control.addProductToShop();
        }
        //Обработчик обновления таблицы
        private void UpdateTable()
        {
            table.Items.Clear();
            foreach (Product product in shop.GetProductList())
            {
                ListViewItem item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Count.ToString());
                item.SubItems.Add(product.Cost.ToString());
                item.SubItems.Add(product.Type.Name);
                item.SubItems.Add(product.Place);
                item.SubItems.Add(product.DataInfo);
                table.Items.Add(item);
            }
        }
        //Обработка клика на кнопку удаления товара
        private void BtmDeleteProduct_Click(object sender, EventArgs e)
        {
            control.deleteProductFromShop();
        }
    }
}
