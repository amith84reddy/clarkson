using System;
using System.Collections.Generic;
using CheckoutCart;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckoutCartTests
{
    [TestClass]
    public class RestaurantCartTests
    {
        [TestMethod]
        public void ValidateCartTotalOfAddedItems()
        {
            List<Product> products = new List<Product>
            {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter),
                new Product("Roast Barbecued Pork Spare Ribs", ProductType.Starter),
                new Product("Capital Spare Ribs of Pork", ProductType.Starter),

                new Product("King Prawn Chop Suey", ProductType.MainCourse),
                new Product("Sweet & Sour Chicken", ProductType.MainCourse),
                new Product("Chicken Chow Mein", ProductType.MainCourse),
                new Product("Curried King Prawn", ProductType.MainCourse)
            };

            RestaurantCart cart = new RestaurantCart();
            cart.Add(products);
            var cartTotal = cart.CartTotal();
            Assert.AreEqual(45.60, cartTotal);
        }

        [TestMethod]
        public void ValidateCartTotalAfterRemovingItemsFromCart()
        {
            List<Product> itemsToAdd = new List<Product>() {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter),
                new Product("Roast Barbecued Pork Spare Ribs", ProductType.Starter),
                new Product("Capital Spare Ribs of Pork", ProductType.Starter),
                new Product("King Prawn Chop Suey", ProductType.MainCourse),
                new Product("Sweet & Sour Chicken", ProductType.MainCourse),
                new Product("Chicken Chow Mein", ProductType.MainCourse),
                new Product("Curried King Prawn", ProductType.MainCourse)
            };

            RestaurantCart cart = new RestaurantCart();
            cart.Add(itemsToAdd);

            List<Product> itemsToRemove = new List<Product>() {
                new Product("Roast Barbecued Pork Spare Ribs", ProductType.Starter),
                new Product("Capital Spare Ribs of Pork", ProductType.Starter),
                new Product("King Prawn Chop Suey", ProductType.MainCourse),
                new Product("Sweet & Sour Chicken", ProductType.MainCourse)
            };

            cart.Delete(itemsToRemove);
            var updatedcartTotal = cart.CartTotal();
            Assert.AreEqual(22.8, updatedcartTotal);
        }

        [TestMethod]
        public void ValidateCartTotalAfterUpdatingCartItems()
        {
            List<Product> itemsToAdd = new List<Product>() {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter)
            };
       
            RestaurantCart cart = new RestaurantCart();
            cart.Add(itemsToAdd);
            var cartTotal = cart.CartTotal();

            List<Product> itemsToUpdate = new List<Product>();
            itemsToUpdate.Add(new Product("Salt & Chilli Smoked Chicken", ProductType.MainCourse));
           
            cart.Update(itemsToUpdate);
            var cartTotal2 = cart.CartTotal();
            Assert.AreEqual(11.40, cartTotal2);
        }

        [TestMethod]
        public void ValidateCartItemCountOfAddedItemsByMenuItemType()
        {
            List<Product> products = new List<Product>
            {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter),
                new Product("Roast Barbecued Pork Spare Ribs", ProductType.Starter),
                new Product("Capital Spare Ribs of Pork", ProductType.Starter),

                new Product("King Prawn Chop Suey", ProductType.MainCourse),
                new Product("Sweet & Sour Chicken", ProductType.MainCourse),
                new Product("Chicken Chow Mein", ProductType.MainCourse),
                new Product("Curried King Prawn", ProductType.MainCourse)
            };

            RestaurantCart cart = new RestaurantCart();
            cart.Add(products);
            var cartTotal = cart.GetItemsCountBy(ProductType.Starter);
            Assert.AreEqual(4, cartTotal);
        }

        [TestMethod]
        public void ValidateCartItemCountAfterRemovingItemsFromCartByMenuItemType()
        {
            List<Product> itemsToAdd = new List<Product>() {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter),
                new Product("Roast Barbecued Pork Spare Ribs", ProductType.Starter),
                new Product("Capital Spare Ribs of Pork", ProductType.Starter),
                new Product("King Prawn Chop Suey", ProductType.MainCourse),
                new Product("Sweet & Sour Chicken", ProductType.MainCourse),
                new Product("Chicken Chow Mein", ProductType.MainCourse),
                new Product("Curried King Prawn", ProductType.MainCourse)
            };

            RestaurantCart cart = new RestaurantCart();
            cart.Add(itemsToAdd);

            List<Product> itemsToRemove = new List<Product>() {
                new Product("Roast Barbecued Pork Spare Ribs", ProductType.Starter),
                new Product("Capital Spare Ribs of Pork", ProductType.Starter),
                new Product("King Prawn Chop Suey", ProductType.MainCourse),
                new Product("Sweet & Sour Chicken", ProductType.MainCourse)
            };

            cart.Delete(itemsToRemove);
            var updatedcartTotal = cart.GetItemsCountBy(ProductType.Starter);
            Assert.AreEqual(2, updatedcartTotal);
        }

        [TestMethod]
        public void ValidateCartItemCountAfterUpdatingCartItemsByMenuItemType()
        {
            List<Product> itemsToAdd = new List<Product>() {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter)
            };

            RestaurantCart cart = new RestaurantCart();
            cart.Add(itemsToAdd);
            var cartTotal = cart.CartTotal();

            List<Product> itemsToUpdate = new List<Product>();
            itemsToUpdate.Add(new Product("Salt & Chilli Smoked Chicken", ProductType.MainCourse));

            cart.Update(itemsToUpdate);
            var cartTotal2 = cart.GetItemsCountBy(ProductType.MainCourse);
            Assert.AreEqual(1, cartTotal2);
        }

        [TestMethod]
        public void ValidateCartItemCountOfAddedItems()
        {
            List<Product> products = new List<Product>
            {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter),
                new Product("Roast Barbecued Pork Spare Ribs", ProductType.Starter),
                new Product("Capital Spare Ribs of Pork", ProductType.Starter),

                new Product("King Prawn Chop Suey", ProductType.MainCourse),
                new Product("Sweet & Sour Chicken", ProductType.MainCourse),
                new Product("Chicken Chow Mein", ProductType.MainCourse),
                new Product("Curried King Prawn", ProductType.MainCourse)
            };

            RestaurantCart cart = new RestaurantCart();
            cart.Add(products);
            var cartTotal = cart.GetTotalItemsCount();
            Assert.AreEqual(8, cartTotal);
        }

        [TestMethod]
        public void ValidateCartItemCountAfterRemovingItemsFromCart()
        {
            List<Product> itemsToAdd = new List<Product>() {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter),
                new Product("Roast Barbecued Pork Spare Ribs", ProductType.Starter),
                new Product("Capital Spare Ribs of Pork", ProductType.Starter),
                new Product("King Prawn Chop Suey", ProductType.MainCourse),
                new Product("Sweet & Sour Chicken", ProductType.MainCourse),
                new Product("Chicken Chow Mein", ProductType.MainCourse),
                new Product("Curried King Prawn", ProductType.MainCourse)
            };

            RestaurantCart cart = new RestaurantCart();
            cart.Add(itemsToAdd);

            List<Product> itemsToRemove = new List<Product>() {
                new Product("Roast Barbecued Pork Spare Ribs", ProductType.Starter),
                new Product("Capital Spare Ribs of Pork", ProductType.Starter),
                new Product("King Prawn Chop Suey", ProductType.MainCourse),
                new Product("Sweet & Sour Chicken", ProductType.MainCourse)
            };

            cart.Delete(itemsToRemove);
            var updatedcartTotal = cart.GetTotalItemsCount();
            Assert.AreEqual(4, updatedcartTotal);
        }

        [TestMethod]
        public void ValidateCartItemCountAfterUpdatingCartItems()
        {
            List<Product> itemsToAdd = new List<Product>() {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter)
            };

            RestaurantCart cart = new RestaurantCart();
            cart.Add(itemsToAdd);
            var cartTotal = cart.CartTotal();

            List<Product> itemsToUpdate = new List<Product>();
            itemsToUpdate.Add(new Product("Salt & Chilli Smoked Chicken", ProductType.MainCourse));

            cart.Update(itemsToUpdate);
            var updatedcartTotal = cart.GetTotalItemsCount();
            Assert.AreEqual(2, updatedcartTotal);
        }

        [TestMethod]
        public void DetailedPrintOfAllItemsInCart()
        {
            List<Product> products = new List<Product>
            {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter),
                new Product("Roast Barbecued Pork Spare Ribs", ProductType.Starter),
                new Product("Capital Spare Ribs of Pork", ProductType.Starter),

                new Product("King Prawn Chop Suey", ProductType.MainCourse),
                new Product("Sweet & Sour Chicken", ProductType.MainCourse),
                new Product("Chicken Chow Mein", ProductType.MainCourse),
                new Product("Curried King Prawn", ProductType.MainCourse)
            };

            RestaurantCart cart = new RestaurantCart();
            cart.Add(products);
            var cartTotal = cart.CartTotal();
            var str = cart.PrintDetailedBill();
            Console.WriteLine(str);
        }

        [TestMethod]
        public void AddSameItemTwiceToCart()
        {
            List<Product> products = new List<Product>
            {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter)
            };

            RestaurantCart cart = new RestaurantCart();
            cart.Add(products);
            var cartTotal = cart.CartTotal();
            Assert.AreEqual(8.8, cartTotal);
        }

        [TestMethod]
        public void NoItemsInCart()
        {
            List<Product> products = new List<Product>();            
            RestaurantCart cart = new RestaurantCart();
            cart.Add(products);
            var cartTotal = cart.CartTotal();

            Assert.AreEqual(0, cartTotal);
        }

        [TestMethod]
        public void RemoveItemsFromEmptyCart()
        {
            List<Product> products = new List<Product>
            {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter)
            };
            RestaurantCart cart = new RestaurantCart();
            cart.Delete(products);
            var cartTotal = cart.CartTotal();

            Assert.AreEqual(0, cartTotal);
        }       

        [TestMethod]
        [ExpectedException(typeof(Exception), "No Items To Add To Cart Exception")]
        public void NullItemsAddedToCart()
        {
            List<Product> products = null;
            RestaurantCart cart = new RestaurantCart();
            cart.Add(products);
            var cartTotal = cart.CartTotal();

            Assert.AreEqual(0, cartTotal);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "No Items To Remove from Cart Exception")]
        public void NullItemsRemovedFromCart()
        {
            List<Product> products = null;
            RestaurantCart cart = new RestaurantCart();
            cart.Add(products);
            var cartTotal = cart.CartTotal();

            Assert.AreEqual(0, cartTotal);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "No Items To Update in Cart Exception")]
        public void NullItemsUpdatedToCart()
        {
            List<Product> products = null;
            RestaurantCart cart = new RestaurantCart();
            cart.Add(products);
            var cartTotal = cart.CartTotal();

            Assert.AreEqual(0, cartTotal);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CartNullCheck()
        {
            List<Product> products = new List<Product>
            {
                new Product("Salt & Chilli Smoked Chicken", ProductType.Starter),
                new Product("Spring Pancake Roll", ProductType.Starter),
            };
            RestaurantCart cart = null;
            cart.Add(products);
            var cartTotal = cart.CartTotal();

            Assert.AreEqual(0, cartTotal);
        }
    }
}
