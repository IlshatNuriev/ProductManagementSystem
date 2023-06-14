using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using ProductManagementSystem.Models;
using DataTable = System.Data.DataTable;

namespace ProductManagementSystem.DataBase
{
    public class DataBaseFromTxt
    {
        static string fileDbName = "database.txt"; // название файла, где хранятся данные
        static string location = System.Reflection.Assembly.GetExecutingAssembly().Location; // передача директории, откуда запускается проект
        static readonly string path = Path.GetDirectoryName(location); // получение имени директории, откуда запускается проект
        static string fileFolderPath = Path.Combine(path, fileDbName); // строка с директорией и названием файла, где хранятся данные

        private static void CheckFileFolderPath(string fileFolderPath) // метод проверки на наличие файла по вышеуказанной директории
        {
            if(File.Exists(fileFolderPath) == false) // если файла нет, то он создается
            {
                File.Create(fileFolderPath).Close();
            }
        }

        public static List<Product> ReadAllFromDB() // получение всех данных из БД
        {
            CheckFileFolderPath(fileFolderPath); // проверка на наличие файла
            string json = File.ReadAllText(fileFolderPath); // чтение из файла
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json); // сериализация данных и передача их в список
            products.ForEach(p => p.ExpirationDateRemaining = GetDays(p.ExpirationDate)); // обновление столбца "кол-во дней до окончания срока годности"
            SaveToDB(products); // сохрание обновленных данных в БД
            return products ?? new List<Product>(); // возврат списка товаров либо пустого списка
        }

        public static List<Product> ReadCurrentProductsFromDB() // получение товаров, свойство IsRemoved которых false
        {
            CheckFileFolderPath(fileFolderPath);
            string json = File.ReadAllText(fileFolderPath);
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);
            products.ForEach(p => p.ExpirationDateRemaining = GetDays(p.ExpirationDate));
            SaveToDB(products);
            var notRemovedProducts = products.Where(p => p.IsRemoved == false).ToList();
            return notRemovedProducts ?? new List<Product>();
        }

        public static void AddToDB(Product product) // метод добавления продукта в БД
        {
            List<Product> products = ReadAllFromDB(); // получение списка товаров
            int lastId = products.Count == 0 ? 0 : products.Last().Id; // чтение последнего id
            product.SetId(lastId+1); // установить id
            product.SetIsRemoved(); // установить IsRemoved == false
            products.Add(product); // добавление товара в список товаров
            string serializedProducts = JsonConvert.SerializeObject(products); // сериализация данных
            File.WriteAllText(fileFolderPath, serializedProducts); // сохранение данных в файл
        }

        public static void SaveToDB(List<Product> products) // сохранение списка товаров в файл
        {
            string serializedProducts = JsonConvert.SerializeObject(products); // сериализация данных
            File.WriteAllText(fileFolderPath, serializedProducts); // сохранение данных в файл
        }

        public static void UpdateToDB(int id, TextBox txtName, TextBox txtProductCode, TextBox txtStorageCode, TextBox txtPriceWithoutDiscount, TextBox txtPriceWithDiscount, TextBox txtDiscount,
            TextBox txtQuantity, TextBox txtUnitOfMeasure, TextBox txtManufactureDate, TextBox txtExpirationDate) // обновление данных в БД
        {
            List<Product> products = ReadAllFromDB(); // получение всех товаров
            Product productForUpdate = products.FirstOrDefault(p => p.Id == id); // поиск по id
            if (productForUpdate != null)
            {
                if (string.IsNullOrEmpty(txtName.Text)) // проверка на пустую строку
                {
                    productForUpdate.Name = productForUpdate.Name; // если пустая, то оставляем данные
                }
                else
                {
                    productForUpdate.Name = txtName.Text; // если нет, то передаем введенные данные
                }
                if (string.IsNullOrEmpty(txtProductCode.Text))
                {
                    productForUpdate.ProductCode = productForUpdate.ProductCode;
                }
                else
                {
                    productForUpdate.ProductCode = Convert.ToInt32(txtProductCode.Text);
                }
                if (string.IsNullOrEmpty(txtStorageCode.Text))
                {
                    productForUpdate.StorageCode = productForUpdate.StorageCode;
                }
                else
                {
                    productForUpdate.StorageCode = Convert.ToInt32(txtStorageCode.Text);
                }
                if (string.IsNullOrEmpty(txtPriceWithoutDiscount.Text))
                {
                    productForUpdate.PriceWithoutDiscount = productForUpdate.PriceWithoutDiscount;
                }
                else
                {
                    productForUpdate.PriceWithoutDiscount = Convert.ToDecimal(txtPriceWithoutDiscount.Text);
                }
                if (string.IsNullOrEmpty(txtPriceWithDiscount.Text))
                {
                    productForUpdate.PriceWithDiscount = productForUpdate.PriceWithoutDiscount;
                }
                else
                {
                    productForUpdate.PriceWithDiscount = Convert.ToDecimal(txtPriceWithoutDiscount.Text) - (Convert.ToDecimal(txtPriceWithoutDiscount.Text) * Convert.ToDecimal(txtDiscount.Text) / 100);
                }
                if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    productForUpdate.Discount = productForUpdate.Discount;
                }
                else
                {
                    productForUpdate.Discount = Convert.ToDecimal(txtDiscount.Text);
                }

                if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    productForUpdate.Quantity = productForUpdate.Quantity;
                }
                else
                {
                    productForUpdate.Quantity = Convert.ToInt32(txtQuantity.Text);
                }
                if (string.IsNullOrEmpty(txtUnitOfMeasure.Text))
                {
                    productForUpdate.UnitOfMeasure = productForUpdate.UnitOfMeasure;
                }
                else
                {
                    productForUpdate.UnitOfMeasure = txtUnitOfMeasure.Text;
                }
                if (string.IsNullOrEmpty(txtManufactureDate.Text))
                {
                    productForUpdate.ManufactureDate = productForUpdate.ManufactureDate;
                }
                else
                {
                    productForUpdate.ManufactureDate = Convert.ToDateTime(txtManufactureDate.Text);
                }
                if (string.IsNullOrEmpty(txtExpirationDate.Text))
                {
                    productForUpdate.ExpirationDate = productForUpdate.ExpirationDate;
                    productForUpdate.ExpirationDateRemaining = DataBaseFromTxt.GetDays(Convert.ToDateTime(productForUpdate.ExpirationDate));
                }
                else
                {
                    productForUpdate.ExpirationDate = Convert.ToDateTime(txtExpirationDate.Text);
                    productForUpdate.ExpirationDateRemaining = DataBaseFromTxt.GetDays(Convert.ToDateTime(txtExpirationDate.Text));
                }
                productForUpdate.IsRemoved = false;
                SaveToDB(products);
            }
        }

        public static void DeleteFromDB(int id) // метод удаления товара из БД 
        {
            List<Product> products = ReadAllFromDB(); // получение списка товаров
            Product productForDelete = products.FirstOrDefault(p => p.Id == id); // поиск по id
            if(productForDelete != null) 
            {
                productForDelete.IsRemoved = true; // установка свойства IsRemoved == true
                SaveToDB(products); // сохранение
            }
        }

        
        public static void LoadDataToDataGridView(List<Product> products, DataTable dataTable, DataGridView dataGridView1) // загрузка списка товаров в таблицу
        { // на главном экране
            dataTable.Rows.Clear(); // очистка предыдущих данных
            foreach (Product product in products) // цикл по списку продуктов 
            {
                dataTable.Rows.Add(product.Id, product.Name, product.ProductCode, product.StorageCode, // добавление строк с продуктами
                    product.PriceWithoutDiscount, product.PriceWithDiscount, product.Discount, product.Quantity, product.UnitOfMeasure,
                    product.ManufactureDate, product.ExpirationDate, product.ExpirationDateRemaining);
                if (product.ExpirationDateRemaining < 7 && product.ExpirationDateRemaining > 0) // если срок годности от 1 до 6 то строка желтого цвета
                {
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    rowColor.BackColor = Color.Yellow;
                    dataGridView1.Rows[products.IndexOf(product)].DefaultCellStyle = rowColor; // желтый цвет строки
                }
                else if (product.ExpirationDateRemaining <= 0) // если срок годности меньше 1 дня, то строка карсная
                {
                    DataGridViewCellStyle rowColor = new DataGridViewCellStyle();
                    rowColor.BackColor = Color.Red;
                    dataGridView1.Rows[products.IndexOf(product)].DefaultCellStyle = rowColor; // красный цвет строки
                }
            }
        }

        public static int GetDays(DateTime end) // метод получения кол-ва дней между сегодняшней датой и датой окончания срока годности
        {
            DateTime now = DateTime.Today.Date;
            return (end - now).Days;
        }

        public static List<Product> GetProductsExpiratedAfterNDays(TextBox txtDaysToExpirationDateEnd1) // метод получения товаров, срок годности которых
        {                                                                                               // истекает через n-дней
            var products = ReadCurrentProductsFromDB(); // получение списка товаров, выведенных в главное окно
            var days = Convert.ToInt32(txtDaysToExpirationDateEnd1.Text); // n-дней, введенные в окно
            var result = products.Where(r => r.ExpirationDateRemaining <= days /*&& r.ExpirationDateRemaining >= 0*/).ToList();
            return result;
        }

        public static List<Product> SetDiscount(TextBox txtDaysToExpirationDateEnd2, TextBox txtAmountOfDiscount) // метод установления скидки
        {
            var products = ReadAllFromDB(); // получение списка всех товаров
            var days = Convert.ToInt32(txtDaysToExpirationDateEnd2.Text); // кол-во дней, введенных в окно
            var discount = Convert.ToDecimal(txtAmountOfDiscount.Text); // размер скидки, введенных в окно
            var sortedProducts = products.Where(s => s.ExpirationDateRemaining <= days && s.ExpirationDateRemaining >= 1).Where(p => p.IsRemoved == false).ToList();
            // вывод товаров, срок годности которых истекает в течение 1 и до n-дней
            sortedProducts.ForEach(p => p.Discount = discount); // установление размера скидки
            sortedProducts.ForEach(p => p.PriceWithDiscount = p.PriceWithoutDiscount - (p.PriceWithoutDiscount * discount / 100)); // установление цены со скидкой
            SaveToDB(products); // сохранение данных
            return sortedProducts;
        }

        public static Product GetProduct(int id) // получение товара по id
        {
            var product = ReadAllFromDB().FirstOrDefault(p =>p.Id == id); // поиск по id
            return product;
        }
    }
}
