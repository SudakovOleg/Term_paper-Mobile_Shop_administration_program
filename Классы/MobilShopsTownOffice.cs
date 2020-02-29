using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilShopNet
{
    public class MobilShopTownOffice
    {
        //Список привязанных магазинов
        private List<MobilShop> MobilShops;

        //Свойства класса
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string Web { get; set; }
        public string House { get; set; }

        //Конструктор
        public MobilShopTownOffice()
        {
            MobilShops = new List<MobilShop>();
        }
        //Метод добавления магазина
        public bool AddMobilShop(MobilShop new_shop)
        {
            foreach (MobilShop shop in MobilShops)
            {
                if (shop.Name == new_shop.Name)
                    return false;
            }
            MobilShops.Add(new_shop);
            return true;
        }
        //Метод удаления магазина
        public bool DeleteMobilShop(String shop_name)
        {
            foreach (MobilShop shop in MobilShops)
            {
                if (shop_name == shop.Name)
                {
                    return MobilShops.Remove(shop);
                }
            }
            return false;
        }
        //Метод нахождения магазина без товаров
        public List<MobilShop> FindEmptyShops()
        {
            List<MobilShop> shops = new List<MobilShop>();
            foreach (MobilShop shop in MobilShops)
            {
                if (shop.CountProducts == 0)
                {
                    shops.Add(shop);
                }
            }
            return shops;
        }
        //Метод получения списка для чтения
        public IReadOnlyCollection<MobilShop> GetListOfShops()
        {
            return MobilShops.AsReadOnly();
        }
    }
}
