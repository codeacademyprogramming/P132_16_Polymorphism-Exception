using StoreAppLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreAppLibrary
{
    public class Market : IStore
    {
        private Product[] _products = new Product[0];
        private int _productLimit;
        private double _totalIncome;
        public Product[] Products { get => _products; }
        public int ProductLimit
        {
            get => _productLimit;
            set
            {
                if (value >= _totalCount)
                    _productLimit = value;

            }

        }
        public double TotalIncome { get => _totalIncome; }

        public void AddProduct(Product product)
        {
            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].No == product.No)
                    throw new ProductAlreadyExistsException("Prodcut is already exists");
            }

            if (_totalCount + product.Count > _productLimit)
                throw new ProductLimitOverflowException();


            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public void SellProduct(string no)
        {
            Product product = null;

            for (int i = 0; i < _products.Length; i++)
            {
                if (_products[i].No == no)
                {
                    product = _products[i];
                    break;
                }

            }

            if (product != null)
            {
                product.Count--;
                _totalIncome += product.Price;
            }
        }

        private int _totalCount
        {
            get
            {
                int total = 0;
                for (int i = 0; i < _products.Length; i++)
                {
                    total += _products[i].Count;
                }

                return total;
            }
        }
    }
}
