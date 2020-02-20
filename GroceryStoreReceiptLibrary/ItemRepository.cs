﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GroceryStoreReceiptLibrary
{
    public class ItemRepository
    {
        public int Count { get; set; }


        private List<Item> Items = new List<Item>();


        
        public void Add(string itemName, double price, int perUnit)
        {
            throw new NotImplementedException();
        }

        public void Add(string itemName, double price)
        {
            if(!Items.Any(x=>x.Name == itemName))
            {
                Items.Add(new Item(itemName, price));
                Count = Items.Count;
            }else
            {
                Items.Where(x => x.Name == itemName).FirstOrDefault().Price = price;
            }
            
        }

        public double PriceCheck(string itemName)
        {

            return Items.Where(x => x.Name == itemName).Select(x => x.Price-x.PriceMarkDown).FirstOrDefault();
        }

        public void Markdown(string itemName, double priceToMarkdownInDollars)
        {
            Items.Where(x => x.Name == itemName).FirstOrDefault().PriceMarkDown = priceToMarkdownInDollars;
        }

        public void BuyNumberGetNumberFreeLimitNumber(string itemName, int numberNeedToBuy, int numberReceivedFree, int LimitOnDealTotalItems)
        {
            throw new NotImplementedException();
        }

        

        public void BuyNumberGetNumberAtDiscountPercentLimitNumber(string itemName, int numberNeedToBuy, int numberToReceiveDiscount, double discountInPercentage, int LimitOnDealTotalItems)
        {
            throw new NotImplementedException();
        }

        public void BuyNumberGetDiscountPercentOnEqualOrLesser(string itemName, int numberNeedToBuy, double discountPercentageOnNextItem )
        {
            throw new NotImplementedException();
        }
    }
}
