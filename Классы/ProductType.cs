using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilShopNet
{
    public class ProductType
    {
        //Свойства класса
        public string Name { get; set; }
        public string Note { get; set; }
        //Конструктор
        public ProductType(string _Name = "No_Name",string _Note = "")
        {
            Name = _Name;
            Note = _Note;
        }
    }
}
