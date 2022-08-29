using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    public interface IStore
    {
        Product[] Products { get; }
        int ProductLimit { get; set; }
        double TotalIncome { get; }
        void AddProduct(Product product);
        void SellProduct(string no);
    }
}
