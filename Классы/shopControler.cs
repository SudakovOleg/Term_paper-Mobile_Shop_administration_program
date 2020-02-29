using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilShopNet
{
    class shopControler
    {
        //Делегат для обновления
        public delegate void workDone();
        public event workDone update;
        //Открытый магазин
        private MobilShop shop;
        //Офис магазина
        private string office;
        //Конструктор
        public shopControler(MobilShop _shop, string _office)
        {
            shop = new MobilShop();
            office = _office;
            shop = _shop;
        }
        //Метод добавления товара в магазин
        public void addProductToShop()
        {
            addProduct addForm = new addProduct(shop.Name, office);
            addForm.FormClosing += Update;
            addForm.Show();
        }
        //Метод удаления товара из магазина
        public void deleteProductFromShop()
        {
            deleteProduct delProduct = new deleteProduct(shop.Name, office);
            delProduct.FormClosed += Update;
            delProduct.Show();
        }
        //Метод удаления магазина
        public void deleteShop()
        {
            BdControler.deleteShop(office, shop.Name);
        }
        //Обработчик закрытия промежуточных форм
        private void Update(Object obj, EventArgs e)
        {
            update();
        }
    }
}
