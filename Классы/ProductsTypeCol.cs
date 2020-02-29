using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MobilShopNet
{
    //Класс хранящий доступные товары
    public class ProductsTypeCol : IEnumerator
    {
        //Список с типами
        private List<ProductType> ProductTypeList;
        //Счетчик
        public int Count { get; set; }
        //Текущий элемент в контейнере
        public object Current
        {
            get { return ProductTypeList[Count]; }
        }
        //Индексатор
        public ProductType this[int index]
        {
            get { return ProductTypeList[index]; }
            set { ProductTypeList[index] = value; }
        }
        //Конструктор
        public ProductsTypeCol()
        {
            ProductTypeList = new List<ProductType>();
            ProductType typePhone = new ProductType();
            typePhone.Name = "Телефон";
            ProductType typeLaptop = new ProductType();
            typeLaptop.Name = "Планшет";
            ProductType typeCase = new ProductType();
            typeCase.Name = "Чехол";
            ProductTypeList.Add(typePhone);
            ProductTypeList.Add(typePhone);
            ProductTypeList.Add(typeLaptop);
            ProductTypeList.Add(typeCase);
        }
        //Метод добавления элемента
        public bool Add(ProductType prod)
        {
            foreach(ProductType product in ProductTypeList)
            {
                if (product == prod)
                    return false;
            }
            ProductTypeList.Add(prod);
            return true;
        }
        //Метод получения IEnumerator
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        //Перемещение в начало контейнера
        public void Reset()
        {
            Count = -1;
        }
        //Перемещение на одну позицию вперед в контейнере элементов
        public bool MoveNext()
        {
            if(Count == ProductTypeList.Count - 1)
            {
                Reset();
                return false;
            }
            Count++;
            return true;
        }
        //Метод изменинения типа товара
        public bool Change(string product_name, ProductType changs)
        {
            foreach(ProductType product in ProductTypeList)
            {
                if(product.Name == product_name)
                {
                    product.Name = changs.Name;
                    return true;
                }
            }
            return false;
        }
        //Метод очистки списка
        public void Clear()
        {
            ProductTypeList.Clear();
        }
        //Метод удаления типа товара
        public bool Delete(string name)
        {
            foreach (ProductType product in ProductTypeList)
            {
                if (product.Name == name)
                {      
                    return ProductTypeList.Remove(product); ;
                }
            }
            return false;
        }
        //Метод поиска типа товара
        public IReadOnlyList<ProductType> GetListOfTypes()
        {
            return ProductTypeList.AsReadOnly();
        }
    }
}
