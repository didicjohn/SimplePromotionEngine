using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    public class Cart
    {
        Dictionary<string, int> _cartItemsQty;//ProductXQuantity
        Dictionary<string, decimal> _productValues;//ProductXUnitPrice
        public Dictionary<string, int> CartItemsQty { get => _cartItemsQty; set => _cartItemsQty = value; }
        public Dictionary<string, decimal> ProductValues { get => _productValues; set => _productValues = value; }
        public Cart()
        {
            CartItemsQty = new Dictionary<string, int>();
            ProductValues = new Dictionary<string, decimal>();
        }

        public decimal Checkout()
        {
            decimal billAmount = 0;

            foreach (var item in _cartItemsQty)
                billAmount += (item.Value * _productValues[item.Key]); //Qty*Price
            return billAmount;
        }
    }
}
