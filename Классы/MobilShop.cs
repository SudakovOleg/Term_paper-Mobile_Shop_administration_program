using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilShopNet
{
    public class MobilShop
    {
        //Список товаров
        private List<Product> ProductList;
        //Свойства класса
        public string BossName { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        //Метод подсчета товаров
        public int CountProducts
        {
            get { return ProductList.Count; }
        }

        //Метод добавления нового вида товара
        public bool AddNewProduct(Product new_product)
        {
            foreach (Product product in ProductList)
            {
                if (product == new_product)
                    return false;
            }
            ProductList.Add(new_product);
            return true;
        }
        //Метод проверки наличия товара
        public bool ExistProduct(Product searh_product)
        {
            foreach(Product cur_product in ProductList)
            {
                if (cur_product == searh_product)
                    return true;
            }
            return false;
        }
        //Метод получения товара
        public Product GetProduct(string product_name)
        {
            foreach (Product cur_product in ProductList)
            {
                if (cur_product.Name == product_name)
                    return cur_product;
            }
            return null;
        }
        //Метод удаления товара
        public bool DeleteProduct(string name)
        {
            foreach (Product product in ProductList)
            {
                if (product.Name == name)
                {
                    return ProductList.Remove(product); ;
                }
            }
            return false;
        }
        //Метод списания товара
        public void BuyProducts(Product _prd)
        {
            if (_prd.Place != this.Name)
                return;
            foreach (Product product in ProductList)
            {
                if (product.Name == _prd.Name)
                {
                    if (product.Count - _prd.Count == 0)
                        ProductList.Remove(product);
                    else if (product.Count - _prd.Count > 0)
                        product.Count -= _prd.Count;
                    else
                        return;
                }
            }
        }
        //Метод получения списка товаров
        public IReadOnlyList<Product> GetProductList()
        {
            return ProductList.AsReadOnly();
        }

        //Конструктор
        public MobilShop()
        {
            ProductList = new List<Product>();
        }
    }
}
