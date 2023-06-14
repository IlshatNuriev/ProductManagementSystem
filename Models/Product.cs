using System;

namespace ProductManagementSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductCode { get; set; }
        public int StorageCode { get; set; }
        public decimal PriceWithoutDiscount { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int ExpirationDateRemaining { get; set; }
        public bool IsRemoved { get; set; }

        public void SetId(int id) // метод, чтобы установить свойство id автоматически при создании товара
        {
            Id = id;
        }

        public void SetIsRemoved() // метод, чтобы установить поле IsRemoved в состояние false при создании товара
        {
            IsRemoved = false;
        }

    }
}
