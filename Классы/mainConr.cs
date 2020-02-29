using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilShopNet
{
    public class mainControl
    {
        //Список офисов
        private List<MobilShopTownOffice> offices;
        //Делегат с событием для обновления
        public delegate void workDone();
        public event workDone update;
        //Конструктор
        public mainControl()
        {
            BdControler.load();
            offices = new List<MobilShopTownOffice>(BdControler.GetOffices());
        }
        //Метод добавления офиса
        public void addOffice()
        {
            addOfficeForm addOffice = new addOfficeForm();
            addOffice.FormClosed += Signal;
            addOffice.Show();
        }
        //Метод удаления офиса
        public void deleteOffice()
        {
            deleteOffice deleteOffice = new deleteOffice();
            deleteOffice.FormClosed += Signal;
            deleteOffice.Show();
        }
        //Метод добавления магазина
        public void addShop()
        {
            addShopToOffice shopToOffice = new addShopToOffice();
            shopToOffice.FormClosed += Signal;
            shopToOffice.Show();
        }
        //Метод сохранения в БД
        public void save()
        {
            BdControler.save();
        }
        //Метод получения списка офисов
        public IReadOnlyList<MobilShopTownOffice> getOffices()
        {
            return offices.AsReadOnly();
        }
        //Обработчик закрытия промежуточных форм
        private void Signal(object sender, EventArgs e)
        {
            offices = new List<MobilShopTownOffice> (BdControler.GetOffices());
            update();
        }
        //Метод открытия магазина
        public void ShopInfo(string office, string shop)
        {
            foreach(MobilShopTownOffice townOffice in offices)
            {
                if(townOffice.Name == office)
                {
                    foreach(MobilShop mobilShop in townOffice.GetListOfShops())
                    {
                        if(mobilShop.Name == shop)
                        {
                            WindowOfShop wndShop = new WindowOfShop(townOffice, mobilShop);
                            wndShop.FormClosed += Signal;
                            wndShop.Show();
                        }
                    }
                }
            }
        }
    }
}
