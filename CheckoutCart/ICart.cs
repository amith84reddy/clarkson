using System.Collections.Generic;

namespace CheckoutCart
{
    interface ICart
    {        
        void Add(List<Product> products);

        void Delete(List<Product> products);

        void Update(List<Product> products);

        double CartTotal();
    }
}
