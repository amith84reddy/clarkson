using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckoutCart
{
    public class RestaurantCart : ICart
    {
        public List<Product> productsInCart;

        public RestaurantCart()
        {
            productsInCart = new List<Product>();
        }

        public void Add(List<Product> products) {
            if (products != null){
                products.ForEach(p => productsInCart.Add(p));
            }
            else{
                throw new Exception("No Items To Add To Cart Exception");
            }
        }

        public void Delete(List<Product> products) {
            if (products != null){
                foreach (var product in products)
                {
                    var p = productsInCart.Where(a => a.Name == product.Name).FirstOrDefault();
                    productsInCart.Remove(p);
                }
            }
            else{
                throw new Exception("No Items To Remove From Cart Exception");
            }
    }

        public void Update(List<Product> products)
        {
            if (products != null){
                foreach (var product in products){
                    var p = productsInCart.Where(a => a.Name == product.Name).FirstOrDefault();
                    productsInCart.Remove(p);
                    productsInCart.Add(product);
                }
            }
            else{
                throw new Exception("No Items To Update From Cart Exception");
            }
        }

        public double CartTotal()
        {
            double _total = 0;
            foreach (Product item in productsInCart)
            {
                _total += item.GetPrice();
            }
            return _total;
        }

        public string PrintDetailedBill()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"---------------------Receipt----------------------");
            sb.AppendLine();
            var groupedItems = productsInCart.GroupBy(a => a.MenuItemType).ToList();
            foreach (var groupedItem in groupedItems){
                sb.AppendLine($"----------{groupedItem.Key.ToString()}--------------");
                foreach (var item in groupedItem){
                    sb.AppendLine($"{item.Name}  ................................   £ {item.GetPrice()}");
                }
                sb.AppendLine();
            }
            sb.AppendLine();
            sb.AppendLine("------------------------------------------------------");
            sb.AppendLine($"Total  -----------------------------------   £ {CartTotal()}");
            sb.AppendLine("------------------------------------------------------");
            return sb.ToString();
        }

        public int GetItemsCountBy(ProductType itemType)
        {
            return productsInCart.Where(a => a.MenuItemType == itemType).Count();
        }

        public int GetTotalItemsCount()
        {
            return productsInCart.Count();
        }
    }
}
