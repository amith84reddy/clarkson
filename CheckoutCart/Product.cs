using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutCart
{
    public enum ProductType
    {
        Starter,
        MainCourse
    }


    public class Product
    {
        private double Price;
        public string Name;
        public ProductType MenuItemType;

        public Product(string name, ProductType menuItemType)
        {
            this.Name = name;
            this.MenuItemType = menuItemType;
        }

        public double GetPrice()
        {
            if (MenuItemType == ProductType.Starter)
                return 4.40;
            else if (MenuItemType == ProductType.MainCourse)
            {
                return 7.00;
            }
            else
            {
                throw new Exception("Incorrect MenuItem Type");
            }
        }

        public override string ToString()
        {
            return Name + "   " + Price;
        }
    }

}
