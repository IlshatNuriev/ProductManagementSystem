using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProductManagementSystem.DataBase;
using DataTable = System.Data.DataTable;

namespace ProductManagementSystem
{
    public partial class MainForm : Form
    {
        private DataTable dataTable;

        public MainForm()
        {
            InitializeComponent();
            dataTable = new DataTable(); // создание экземпляра таблицы
            dataTable.Columns.Add("id"); 
            dataTable.Columns.Add("Наименование товара");
            dataTable.Columns.Add("Код продукта");
            dataTable.Columns.Add("Код места хранения");
            dataTable.Columns.Add("Цена без скидки");
            dataTable.Columns.Add("Цена со скидкой");
            dataTable.Columns.Add("Скидка");
            dataTable.Columns.Add("Количество");
            dataTable.Columns.Add("Ед. измерения");
            dataTable.Columns.Add("Дата изготовления");
            dataTable.Columns.Add("Дата окончания срока годности");
            dataTable.Columns.Add("Кол-во дней до окончания срока годности");
            dataGridView1.DataSource = dataTable; 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable; // отключение сортировки при нажатии на заголовок
            }
        }

        private void MainForm_Load(object sender, EventArgs e) // загрузка данных в главное окно
        {
            var products = DataBaseFromTxt.ReadCurrentProductsFromDB();
            DataBaseFromTxt.LoadDataToDataGridView(products, dataTable, dataGridView1);
        }

        private void btnAddProduct_Click(object sender, EventArgs e) // событие - нажатие на кнопку добавить товар
        {
            AddProductForm addProductForm = new AddProductForm();
            DialogResult result = addProductForm.ShowDialog(); // раскрытие окна добавления товара
            if (result == DialogResult.OK)
            {
                var products = DataBaseFromTxt.ReadCurrentProductsFromDB(); 
                DataBaseFromTxt.LoadDataToDataGridView(products, dataTable, dataGridView1); // вывод на главное окно списка товаров
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e) // событие - нажатие на кнопку редактировать товар
        {
            var id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value); // получение id выделенной строки на главной форме
            EditForm editForm = new EditForm(id);
            DialogResult result = editForm.ShowDialog(); // раскрытие окна редактирования товара
            if (result == DialogResult.OK)
            {
                var products = DataBaseFromTxt.ReadCurrentProductsFromDB();
                DataBaseFromTxt.LoadDataToDataGridView(products, dataTable, dataGridView1); // вывод на главное окно списка товаров
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e) // событие - удаление товара
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранный товар?", "Предупреждение", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); // предупреждение
            if( result == DialogResult.Yes)
            {
                var id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value); // получение id выделенной строки
                DataBaseFromTxt.DeleteFromDB(id); // вызов метода удаления
                var products = DataBaseFromTxt.ReadCurrentProductsFromDB();
                DataBaseFromTxt.LoadDataToDataGridView(products, dataTable, dataGridView1); // вывод на главное окно списка товаров
            }
        }

        private void btnSort_Click(object sender, EventArgs e) // сортировка товаров по выбранным параметрам
        {
            string sortBy = cmbSortBy.SelectedItem.ToString();
            var products = DataBaseFromTxt.ReadCurrentProductsFromDB();
            switch (sortBy)
            {
                case "Наименование товара":
                    products.Sort(new ProductComparer.ProductNameComparer());
                    break;
                case "Код продукта":
                    products.Sort(new ProductComparer.ProductCodeComparer());
                    break;
                case "Код места хранения":
                    products.Sort(new ProductComparer.StorageCodeComparer());
                    break;
                case "Цена без скидки":
                    products.Sort(new ProductComparer.PriceWithoutDiscountComparer());
                    break;
                case "Цена со скидкой":
                    products.Sort(new ProductComparer.PriceWithDiscountComparer());
                    break;
                case "Скидка":
                    products.Sort(new ProductComparer.DiscountComparer());
                    break;
                case "Количество":
                    products.Sort(new ProductComparer.QuantityComparer());
                    break;
                case "Дата изготовления":
                    products.Sort(new ProductComparer.ManufactureDateComparer());
                    break;
                case "Дата окончания срока годности":
                    products.Sort(new ProductComparer.ExpirationDateComparer());
                    break;
                case "Кол-во дней до окончания срока годности":
                    products.Sort(new ProductComparer.ExpirationDateRemainingComparer());
                    break;
                default:
                    break;
            }
            DataBaseFromTxt.LoadDataToDataGridView(products, dataTable, dataGridView1); // вывод на главное окно списка товаров
        }

        private void btnExpiratedProducts_Click(object sender, EventArgs e) // вывод списка товаров, срок годности которых выйдет через n-дней
        {
            try
            {
                var expiratedProducts = DataBaseFromTxt.GetProductsExpiratedAfterNDays(txtDaysToExpirationDateEnd1);
                DataBaseFromTxt.LoadDataToDataGridView(expiratedProducts, dataTable, dataGridView1);
            }
            catch
            {
                MessageBox.Show("Введите корректные данные в поле ввода", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information, 
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSetDiscount_Click(object sender, EventArgs e) // событие - установить скидку на товары, срок годности которых истекает через n-дней
        {
            try
            {
                DataBaseFromTxt.SetDiscount(txtDaysToExpirationDateEnd2, txtAmountOfDiscount);
                var products = DataBaseFromTxt.ReadCurrentProductsFromDB();
                DataBaseFromTxt.LoadDataToDataGridView(products, dataTable, dataGridView1);
            }
            catch
            {
                MessageBox.Show("Введите корректные данные в поле ввода", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            
        }

        private void btnExpiratedProductsList_Click(object sender, EventArgs e) // вывод списка товаров, срок годности которых истечет на выбранную дату
        {
            try
            {
                var date = Convert.ToDateTime(txtDateOfCheck.Text);
                var products = DataBaseFromTxt.ReadAllFromDB().Where(p => p.ExpirationDate == date).ToList();
                DataBaseFromTxt.LoadDataToDataGridView(products, dataTable, dataGridView1);
            }
            catch
            {
                MessageBox.Show("Введите корректные данные в поле ввода", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information, 
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnTotalCostOfExpiratedProducts_Click(object sender, EventArgs e) // общая стоимость товаров (не удаленных), срок годности которых истек
        {
            var products = DataBaseFromTxt.ReadCurrentProductsFromDB().Where(p => p.ExpirationDateRemaining < 0).ToList();
            decimal totalCost = 0.00M;
            foreach (var product in products)
            {
                if(product.PriceWithoutDiscount > product.PriceWithDiscount && product.PriceWithDiscount != 0)
                {
                    var totalCostOfProduct = product.PriceWithDiscount * product.Quantity;
                    totalCost += totalCostOfProduct;
                }
                else
                {
                    var totalCostOfProduct = product.PriceWithoutDiscount * product.Quantity;
                    totalCost += totalCostOfProduct;
                }
            }
            listViewTotalCostOfExpiratedProducts.Text = totalCost.ToString();
        }

        private void btnTotalCostWithDiscount_Click(object sender, EventArgs e) // стоимость товаров со скидкой
        {
            var products = DataBaseFromTxt.ReadCurrentProductsFromDB();
            decimal totalCost = 0.00M;
            foreach (var product in products)
            {
                var totalCostOfProduct = product.PriceWithDiscount * product.Quantity;
                totalCost += totalCostOfProduct;
            }
            listViewOfTotalCost.Text = totalCost.ToString();
        }

        private void btnTotalCostWithoutDiscount_Click(object sender, EventArgs e) // стоимость товаров без скидки
        {
            var products = DataBaseFromTxt.ReadCurrentProductsFromDB();
            decimal totalCost = 0.00M;
            foreach (var product in products)
            {
                var totalCostOfProduct = product.PriceWithoutDiscount * product.Quantity;
                totalCost += totalCostOfProduct;
            }
            listViewOfTotalCost.Text = totalCost.ToString();
        }

        private void btnDifferenceOfTotalCost_Click(object sender, EventArgs e) // разница между стоимостью со скидкой и без скидки
        {
            var products = DataBaseFromTxt.ReadCurrentProductsFromDB();
            decimal totalCostWithoutDiscount = 0.00M;
            decimal totalCostWithDiscount = 0.00M;
            foreach (var product in products)
            {
                var totalCostOfProductWithoutDiscount = product.PriceWithoutDiscount * product.Quantity;
                totalCostWithoutDiscount += totalCostOfProductWithoutDiscount;
                var totalCostOfProductWithDiscount = product.PriceWithDiscount * product.Quantity;
                totalCostWithDiscount += totalCostOfProductWithDiscount;
            }
            listViewOfTotalCost.Clear();
            var totalCostDifference = totalCostWithoutDiscount - totalCostWithDiscount;
            listViewOfTotalCost.Text = totalCostDifference.ToString();
        }

        private void btnRemoveAllExpiratedProducts_Click(object sender, EventArgs e) // удаление всех товаров, выведенных в таблицу, срок годности которых истек
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить товары?", "Предупреждение", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                var products = DataBaseFromTxt.ReadAllFromDB();
                foreach (var product in products.Where(p=>p.ExpirationDateRemaining < 0).Where(p=>p.IsRemoved == false))
                    {
                        product.IsRemoved = true;
                    }
                DataBaseFromTxt.SaveToDB(products);
                var changedProducts = DataBaseFromTxt.ReadCurrentProductsFromDB();
                DataBaseFromTxt.LoadDataToDataGridView(changedProducts, dataTable, dataGridView1);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e) // очистка всез условий на главном окне
        {
            var products = DataBaseFromTxt.ReadCurrentProductsFromDB();
            DataBaseFromTxt.LoadDataToDataGridView(products, dataTable, dataGridView1);
            this.cmbSortBy.Text = "Наименование товара";
            txtDaysToExpirationDateEnd1.Clear();
            txtAmountOfDiscount.Clear();
            txtDaysToExpirationDateEnd2.Clear();
            txtDateOfCheck.Clear();
            listViewOfTotalCost.Clear();
            listViewTotalCostOfExpiratedProducts.Clear();
        }
    }
}