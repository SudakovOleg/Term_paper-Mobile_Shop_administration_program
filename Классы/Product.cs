using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilShopNet
{
    //Класс товара
    public class Product
    {
        //Свойства класса
        public string Place { get; set; }
        public string DataInfo { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public ProductType Type { get; set; }

        //Метод клонирования
        public void Clone(Product clone)
        {
            clone.Name = Name;
            clone.Place = Place;
            clone.DataInfo = DataInfo;
            clone.Count = Count;
        }
        //Переопределение операции !=
        public static bool operator !=(Product left, Product right)
        {
            return !(left == right);
        }
        //Переопределение операции ==
        public static bool operator ==(Product left, Product right)
        {
            if (left.Name == right.Name &&
                left.Place == right.Place &&
                left.DataInfo == right.DataInfo &&
                left.Count == right.Count)
                return true;

            else return false;
        }
        //Конструктор
        public Product(string _Place="", string _data = "", string _name = "", int _count = 1, int _cost = 1, string _type = "")
        {
            Place = _Place;
            DataInfo = _data;
            Name = _name;
            Count = _count;
            Cost = _cost;
            Type = new ProductType();
            Type.Name = _type;
        }
    }
}
