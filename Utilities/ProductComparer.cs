using System;
using System.Collections.Generic;
using ProductManagementSystem.Models;

namespace ProductManagementSystem
{
    public class ProductComparer
    {
        public class ProductNameComparer : IComparer<Product> // класс содержащий метод для сортировки данных
        {
            public int Compare(Product x, Product y) // метод сортировки данных
            {
                return string.Compare(x.Name, y.Name);
            }
        }

        public class ProductCodeComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return x.ProductCode.CompareTo(y.ProductCode);
            }
        }

        public class StorageCodeComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return x.StorageCode.CompareTo(y.StorageCode);
            }
        }

        public class PriceWithoutDiscountComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return x.PriceWithoutDiscount.CompareTo(y.PriceWithoutDiscount);
            }
        }

        public class PriceWithDiscountComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return x.PriceWithDiscount.CompareTo(y.PriceWithDiscount);
            }
        }

        public class DiscountComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return x.Discount.CompareTo(y.Discount);
            }
        }

        public class QuantityComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return x.Quantity.CompareTo(y.Quantity);
            }
        }

        public class ManufactureDateComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return DateTime.Compare(x.ManufactureDate, y.ManufactureDate);
            }
        }

        public class ExpirationDateComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return DateTime.Compare(x.ExpirationDate, y.ExpirationDate);
            }
        }

        public class ExpirationDateRemainingComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                return x.ExpirationDateRemaining.CompareTo(y.ExpirationDateRemaining);
            }
        }
    }
}
