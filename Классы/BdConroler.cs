using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MobilShopNet
{
    static public class BdControler
    {
        //Список офисов
        static private List<MobilShopTownOffice> offices = new List<MobilShopTownOffice>();
        public static void load()
        {
            //Открываем БД
            XmlDocument doc = new XmlDocument();
            doc.Load("DataBase.xml");
            //Выделяем память под список
            offices = new List<MobilShopTownOffice>();
            //Проходим по списку офисов в БД
            foreach(XmlNode officeNode in doc.ChildNodes[0].ChildNodes)
            {
                //Записываем данные о офисе
                MobilShopTownOffice townOffice = new MobilShopTownOffice();
                townOffice.Country = officeNode.ChildNodes[0].InnerText;
                townOffice.Email = officeNode.ChildNodes[1].InnerText;
                townOffice.House = officeNode.ChildNodes[2].InnerText;
                townOffice.Street = officeNode.ChildNodes[3].InnerText;
                townOffice.Region = officeNode.ChildNodes[4].InnerText;
                townOffice.Town = officeNode.ChildNodes[5].InnerText;
                townOffice.Web = officeNode.ChildNodes[6].InnerText;
                townOffice.Name = officeNode.ChildNodes[7].InnerText;
                //Проходим по списку магазинов привязанных к офису
                foreach(XmlNode shopNode in officeNode.ChildNodes[8].ChildNodes)
                {
                    //Выделяем память под магазин
                    MobilShop mobilShop = new MobilShop();
                    //Заполняем данные
                    mobilShop.Name = shopNode.ChildNodes[0].InnerText;
                    mobilShop.Email = shopNode.ChildNodes[1].InnerText;
                    mobilShop.BossName = shopNode.ChildNodes[2].InnerText;
                    mobilShop.Phone = shopNode.ChildNodes[3].InnerText;
                    //Проходим по списку товаров в магазине
                    foreach(XmlNode prdNode in shopNode.ChildNodes[4].ChildNodes)
                    {
                        //Выделяем память под товар
                        Product prd = new Product();
                        //Заполняем данные о товаре
                        prd.Name = prdNode.ChildNodes[0].InnerText;
                        prd.Cost = Int32.Parse(prdNode.ChildNodes[1].InnerText);
                        prd.Count = Int32.Parse(prdNode.ChildNodes[2].InnerText);
                        prd.DataInfo = prdNode.ChildNodes[3].InnerText;
                        prd.Type.Name = prdNode.ChildNodes[4].InnerText;
                        prd.Place = prdNode.ChildNodes[5].InnerText;
                        //Заносим товар в магазин
                        mobilShop.AddNewProduct(prd);
                    }
                    //Привязываем магазин к офису
                    townOffice.AddMobilShop(mobilShop);
                }
                //Добавляем офис в список
                offices.Add(townOffice);
            }
        }
        //Метод добавления офиса в список
        static public bool AddOffice(MobilShopTownOffice _office)
        {
            foreach(MobilShopTownOffice townOffice in offices)
            {
                if (townOffice.Name == _office.Name)
                    return false;
            }
            offices.Add(_office);
            return true;
        }
        //Метод добавления магазина
        public static bool AddShopInOffice(string _office_name, MobilShop _new_shop)
        {
            foreach (MobilShopTownOffice townOffice in offices)
            {
                if (townOffice.Name == _office_name)
                {
                    return townOffice.AddMobilShop(_new_shop);
                }
            }
            return false;
        }
        //Метод удаления офиса
        public static void DeleteOffice(string _office_name)
        {
            foreach(MobilShopTownOffice townOffice in offices)
            {
                if(townOffice.Name == _office_name)
                {
                    offices.Remove(townOffice);
                    break;
                }
            }
        }
        //Метод удаления магазина
        public static void deleteShop(string _office_name, string _shop_name)
        {
            foreach(MobilShopTownOffice townOffice in offices)
            {
                if(townOffice.Name == _office_name)
                {
                    townOffice.DeleteMobilShop(_shop_name);
                }
            }
        }
        //Метод удаления товара
        public static void deleteProduct(string _office_name, string _shop_name,string _product_name)
        {
            foreach (MobilShopTownOffice townOffice in offices)
            {
                if (townOffice.Name == _office_name)
                {
                    foreach (MobilShop shop in townOffice.GetListOfShops())
                    {
                        if(shop.Name == _shop_name)
                        {
                            shop.DeleteProduct(_product_name);
                        }
                    }
                }
            }
        }
        //Метод добавления товара
        public static void addProduct(string _office_name, string _shop_name, Product _product)
        {
            foreach (MobilShopTownOffice townOffice in offices)
            {
                if (townOffice.Name == _office_name)
                {
                    foreach (MobilShop shop in townOffice.GetListOfShops())
                    {
                        if (shop.Name == _shop_name)
                        {
                            shop.AddNewProduct(_product);
                        }
                    }
                }
            }
        }
        //Метод удаления офиса
        public static IReadOnlyCollection<MobilShopTownOffice> GetOffices()
        {
            return offices.AsReadOnly();
        }
        //Метод сохранения данных
        public static void save()
        {
            //Открываем файл БД
            XmlDocument doc = new XmlDocument();
            doc.Load("DataBase.xml");
            //Очищаем БД
            doc.RemoveAll();
            //Перезаписываем
            XmlNode NetNode = doc.CreateElement("net");
            foreach (MobilShopTownOffice townOffice in offices)
            {
                XmlNode OfficeNode = doc.CreateElement("office");

                XmlNode ContryNode = doc.CreateElement("contry");
                ContryNode.InnerText = townOffice.Country;
                OfficeNode.AppendChild(ContryNode);

                XmlNode MailNode = doc.CreateElement("mail");
                MailNode.InnerText = townOffice.Email;
                OfficeNode.AppendChild(MailNode);

                XmlNode HouseNode = doc.CreateElement("house");
                HouseNode.InnerText = townOffice.House;
                OfficeNode.AppendChild(HouseNode);

                XmlNode StreetNode = doc.CreateElement("street");
                StreetNode.InnerText = townOffice.Street;
                OfficeNode.AppendChild(StreetNode);

                XmlNode RegionNode = doc.CreateElement("region");
                RegionNode.InnerText = townOffice.Region;
                OfficeNode.AppendChild(RegionNode);

                XmlNode TownNode = doc.CreateElement("town");
                TownNode.InnerText = townOffice.Town;
                OfficeNode.AppendChild(TownNode);

                XmlNode WebNode = doc.CreateElement("web");
                WebNode.InnerText = townOffice.Web;
                OfficeNode.AppendChild(WebNode);

                XmlNode NameNode = doc.CreateElement("name");
                NameNode.InnerText = townOffice.Name;
                OfficeNode.AppendChild(NameNode);

                XmlNode ShopsNode = doc.CreateElement("shops");
                foreach (MobilShop mobilShop in townOffice.GetListOfShops())
                {
                    XmlNode ShopNode = doc.CreateElement("shop");

                    XmlNode NameShopNode = doc.CreateElement("nameshop");
                    NameShopNode.InnerText = mobilShop.Name;
                    ShopNode.AppendChild(NameShopNode);

                    XmlNode MailShopNode = doc.CreateElement("mailshop");
                    MailShopNode.InnerText = mobilShop.Email;
                    ShopNode.AppendChild(MailShopNode);

                    XmlNode BossNode = doc.CreateElement("boss");
                    BossNode.InnerText = mobilShop.BossName;
                    ShopNode.AppendChild(BossNode);

                    XmlNode PhoneNode = doc.CreateElement("phone");
                    PhoneNode.InnerText = mobilShop.Phone;
                    ShopNode.AppendChild(PhoneNode);

                    XmlNode ProductsNode = doc.CreateElement("products");
                    foreach(Product prd in mobilShop.GetProductList())
                    {
                        XmlNode ProductNode = doc.CreateElement("product");

                        XmlNode NameProductNode = doc.CreateElement("nameproduct");
                        NameProductNode.InnerText = prd.Name;
                        ProductNode.AppendChild(NameProductNode);

                        XmlNode CostNode = doc.CreateElement("cost");
                        CostNode.InnerText = prd.Cost.ToString();
                        ProductNode.AppendChild(CostNode);

                        XmlNode CountNode = doc.CreateElement("count");
                        CountNode.InnerText = prd.Count.ToString();
                        ProductNode.AppendChild(CountNode);

                        XmlNode InfoNode = doc.CreateElement("info");
                        InfoNode.InnerText = prd.DataInfo;
                        ProductNode.AppendChild(InfoNode);

                        XmlNode TypeNode = doc.CreateElement("type");
                        TypeNode.InnerText = prd.Type.Name;
                        ProductNode.AppendChild(TypeNode);

                        XmlNode PlaceNode = doc.CreateElement("place");
                        PlaceNode.InnerText = prd.Place;
                        ProductNode.AppendChild(PlaceNode);

                        ProductsNode.AppendChild(ProductNode);
                    }
                    ShopNode.AppendChild(ProductsNode);
                    ShopsNode.AppendChild(ShopNode);
                }
                OfficeNode.AppendChild(ShopsNode);
                NetNode.AppendChild(OfficeNode);
            }
            doc.AppendChild(NetNode);
            //Сохраняем файл
            doc.Save("DataBase.xml");
        }

    }
}
