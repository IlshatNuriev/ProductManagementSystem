using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ProductManagementSystem.DataBase;
using ProductManagementSystem.Models;

namespace ProductManagementSystem
{
    public partial class AddProductForm : Form
    {
        private TextBox txtName;
        private TextBox txtDiscount;
        private TextBox txtQuantity;
        private Button btnAdd;
        private Button btnEdit;
        private Label nameOfProduct;
        private Label manufactureDateOfProduct;
        private Label expirationDateOfProduct;
        private Label priceWithoutDiscountOfProduct;
        private Label quantityOfProduct;
        private TextBox txtProductCode;
        private TextBox txtStorageCode;
        private TextBox txtPriceWithoutDiscount;
        private TextBox txtUnitOfMeasure;
        private TextBox txtManufactureDate;
        private TextBox txtExpirationDate;
        private Label ProductCodeOfProduct;
        private Label StorageCodeOfProduct;
        private Label DiscountOfProduct;
        private Label unitOfMeasureOfProduct;
        private TextBox txtPriceWithDiscount;
        private Label priceWithDiscountOfProduct;
        private Button btnCancel;
        
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.nameOfProduct = new System.Windows.Forms.Label();
            this.manufactureDateOfProduct = new System.Windows.Forms.Label();
            this.expirationDateOfProduct = new System.Windows.Forms.Label();
            this.priceWithoutDiscountOfProduct = new System.Windows.Forms.Label();
            this.quantityOfProduct = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtStorageCode = new System.Windows.Forms.TextBox();
            this.txtPriceWithoutDiscount = new System.Windows.Forms.TextBox();
            this.txtUnitOfMeasure = new System.Windows.Forms.TextBox();
            this.txtManufactureDate = new System.Windows.Forms.TextBox();
            this.txtExpirationDate = new System.Windows.Forms.TextBox();
            this.ProductCodeOfProduct = new System.Windows.Forms.Label();
            this.StorageCodeOfProduct = new System.Windows.Forms.Label();
            this.DiscountOfProduct = new System.Windows.Forms.Label();
            this.unitOfMeasureOfProduct = new System.Windows.Forms.Label();
            this.txtPriceWithDiscount = new System.Windows.Forms.TextBox();
            this.priceWithDiscountOfProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(334, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(334, 182);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(298, 22);
            this.txtDiscount.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(334, 216);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(298, 22);
            this.txtQuantity.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(373, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(125, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить товар";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            // 
            // nameOfProduct
            // 
            this.nameOfProduct.AutoSize = true;
            this.nameOfProduct.Location = new System.Drawing.Point(31, 15);
            this.nameOfProduct.Name = "nameOfProduct";
            this.nameOfProduct.Size = new System.Drawing.Size(156, 16);
            this.nameOfProduct.TabIndex = 12;
            this.nameOfProduct.Text = "Наименование товара\r\n";
            // 
            // manufactureDateOfProduct
            // 
            this.manufactureDateOfProduct.AutoSize = true;
            this.manufactureDateOfProduct.Location = new System.Drawing.Point(31, 287);
            this.manufactureDateOfProduct.Name = "manufactureDateOfProduct";
            this.manufactureDateOfProduct.Size = new System.Drawing.Size(134, 16);
            this.manufactureDateOfProduct.TabIndex = 20;
            this.manufactureDateOfProduct.Text = "Дата изготовления";
            // 
            // expirationDateOfProduct
            // 
            this.expirationDateOfProduct.AutoSize = true;
            this.expirationDateOfProduct.Location = new System.Drawing.Point(31, 321);
            this.expirationDateOfProduct.Name = "expirationDateOfProduct";
            this.expirationDateOfProduct.Size = new System.Drawing.Size(216, 16);
            this.expirationDateOfProduct.TabIndex = 21;
            this.expirationDateOfProduct.Text = "Дата окончания срока годности";
            // 
            // priceWithoutDiscountOfProduct
            // 
            this.priceWithoutDiscountOfProduct.AutoSize = true;
            this.priceWithoutDiscountOfProduct.Location = new System.Drawing.Point(31, 117);
            this.priceWithoutDiscountOfProduct.Name = "priceWithoutDiscountOfProduct";
            this.priceWithoutDiscountOfProduct.Size = new System.Drawing.Size(115, 16);
            this.priceWithoutDiscountOfProduct.TabIndex = 15;
            this.priceWithoutDiscountOfProduct.Text = "Цена без скидки";
            // 
            // quantityOfProduct
            // 
            this.quantityOfProduct.AutoSize = true;
            this.quantityOfProduct.Location = new System.Drawing.Point(31, 219);
            this.quantityOfProduct.Name = "quantityOfProduct";
            this.quantityOfProduct.Size = new System.Drawing.Size(85, 16);
            this.quantityOfProduct.TabIndex = 18;
            this.quantityOfProduct.Text = "Количество";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(334, 46);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(298, 22);
            this.txtProductCode.TabIndex = 1;
            // 
            // txtStorageCode
            // 
            this.txtStorageCode.Location = new System.Drawing.Point(334, 80);
            this.txtStorageCode.Name = "txtStorageCode";
            this.txtStorageCode.Size = new System.Drawing.Size(298, 22);
            this.txtStorageCode.TabIndex = 2;
            // 
            // txtPriceWithoutDiscount
            // 
            this.txtPriceWithoutDiscount.Location = new System.Drawing.Point(334, 114);
            this.txtPriceWithoutDiscount.Name = "txtPriceWithoutDiscount";
            this.txtPriceWithoutDiscount.Size = new System.Drawing.Size(298, 22);
            this.txtPriceWithoutDiscount.TabIndex = 3;
            // 
            // txtUnitOfMeasure
            // 
            this.txtUnitOfMeasure.Location = new System.Drawing.Point(334, 250);
            this.txtUnitOfMeasure.Name = "txtUnitOfMeasure";
            this.txtUnitOfMeasure.Size = new System.Drawing.Size(298, 22);
            this.txtUnitOfMeasure.TabIndex = 7;
            // 
            // txtManufactureDate
            // 
            this.txtManufactureDate.Location = new System.Drawing.Point(334, 284);
            this.txtManufactureDate.Name = "txtManufactureDate";
            this.txtManufactureDate.Size = new System.Drawing.Size(298, 22);
            this.txtManufactureDate.TabIndex = 8;
            // 
            // txtExpirationDate
            // 
            this.txtExpirationDate.Location = new System.Drawing.Point(334, 318);
            this.txtExpirationDate.Name = "txtExpirationDate";
            this.txtExpirationDate.Size = new System.Drawing.Size(298, 22);
            this.txtExpirationDate.TabIndex = 9;
            // 
            // ProductCodeOfProduct
            // 
            this.ProductCodeOfProduct.AutoSize = true;
            this.ProductCodeOfProduct.Location = new System.Drawing.Point(31, 49);
            this.ProductCodeOfProduct.Name = "ProductCodeOfProduct";
            this.ProductCodeOfProduct.Size = new System.Drawing.Size(81, 16);
            this.ProductCodeOfProduct.TabIndex = 13;
            this.ProductCodeOfProduct.Text = "Код товара";
            // 
            // StorageCodeOfProduct
            // 
            this.StorageCodeOfProduct.AutoSize = true;
            this.StorageCodeOfProduct.Location = new System.Drawing.Point(31, 83);
            this.StorageCodeOfProduct.Name = "StorageCodeOfProduct";
            this.StorageCodeOfProduct.Size = new System.Drawing.Size(137, 16);
            this.StorageCodeOfProduct.TabIndex = 14;
            this.StorageCodeOfProduct.Text = "Код места хранения";
            // 
            // DiscountOfProduct
            // 
            this.DiscountOfProduct.AutoSize = true;
            this.DiscountOfProduct.Location = new System.Drawing.Point(31, 185);
            this.DiscountOfProduct.Name = "DiscountOfProduct";
            this.DiscountOfProduct.Size = new System.Drawing.Size(54, 16);
            this.DiscountOfProduct.TabIndex = 17;
            this.DiscountOfProduct.Text = "Скидка";
            // 
            // unitOfMeasureOfProduct
            // 
            this.unitOfMeasureOfProduct.AutoSize = true;
            this.unitOfMeasureOfProduct.Location = new System.Drawing.Point(31, 253);
            this.unitOfMeasureOfProduct.Name = "unitOfMeasureOfProduct";
            this.unitOfMeasureOfProduct.Size = new System.Drawing.Size(104, 16);
            this.unitOfMeasureOfProduct.TabIndex = 19;
            this.unitOfMeasureOfProduct.Text = "Ед. измерения";
            // 
            // txtPriceWithDiscount
            // 
            this.txtPriceWithDiscount.Location = new System.Drawing.Point(334, 148);
            this.txtPriceWithDiscount.Name = "txtPriceWithDiscount";
            this.txtPriceWithDiscount.ReadOnly = true;
            this.txtPriceWithDiscount.Size = new System.Drawing.Size(298, 22);
            this.txtPriceWithDiscount.TabIndex = 4;
            // 
            // priceWithDiscountOfProduct
            // 
            this.priceWithDiscountOfProduct.AutoSize = true;
            this.priceWithDiscountOfProduct.Location = new System.Drawing.Point(31, 151);
            this.priceWithDiscountOfProduct.Name = "priceWithDiscountOfProduct";
            this.priceWithDiscountOfProduct.Size = new System.Drawing.Size(114, 16);
            this.priceWithDiscountOfProduct.TabIndex = 16;
            this.priceWithDiscountOfProduct.Text = "Цена со скидкой";
            // 
            // AddProductForm
            // 
            this.ClientSize = new System.Drawing.Size(691, 441);
            this.Controls.Add(this.priceWithDiscountOfProduct);
            this.Controls.Add(this.txtPriceWithDiscount);
            this.Controls.Add(this.unitOfMeasureOfProduct);
            this.Controls.Add(this.DiscountOfProduct);
            this.Controls.Add(this.StorageCodeOfProduct);
            this.Controls.Add(this.ProductCodeOfProduct);
            this.Controls.Add(this.txtExpirationDate);
            this.Controls.Add(this.txtManufactureDate);
            this.Controls.Add(this.txtUnitOfMeasure);
            this.Controls.Add(this.txtPriceWithoutDiscount);
            this.Controls.Add(this.txtStorageCode);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.quantityOfProduct);
            this.Controls.Add(this.priceWithoutDiscountOfProduct);
            this.Controls.Add(this.expirationDateOfProduct);
            this.Controls.Add(this.manufactureDateOfProduct);
            this.Controls.Add(this.nameOfProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtName);
            this.Name = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        private void btnAdd_Click(object sender, EventArgs e) // событие - добавить товар
        {
            if(ValidateInput(txtName, txtProductCode, txtStorageCode, txtPriceWithoutDiscount, txtPriceWithDiscount, txtDiscount, txtQuantity,
                    txtUnitOfMeasure, txtManufactureDate, txtExpirationDate)) // проверка данных
            {
                DialogResult = DialogResult.OK;
                Product product = new Product(); // создание экземпляра товара
                product.Name = txtName.Text; // передача введенных данных в свойства экземпляра товара
                product.ProductCode = Convert.ToInt32(txtProductCode.Text);
                product.StorageCode = Convert.ToInt32(txtStorageCode.Text);
                product.PriceWithoutDiscount = Convert.ToDecimal(txtPriceWithoutDiscount.Text);
                if (string.IsNullOrEmpty(txtDiscount.Text) || Convert.ToDecimal(txtDiscount.Text) == 0)
                {
                    product.PriceWithDiscount = product.PriceWithoutDiscount;
                }
                else
                {
                    product.PriceWithDiscount = product.PriceWithoutDiscount - (product.PriceWithoutDiscount * Convert.ToDecimal(txtDiscount.Text) / 100);
                }
                if (string.IsNullOrEmpty(txtDiscount.Text))
                {
                    product.Discount = 0.00M;
                }
                else
                {
                    product.Discount = Convert.ToDecimal(txtDiscount.Text);
                }
                product.Quantity = Convert.ToInt32(txtQuantity.Text);
                product.UnitOfMeasure = txtUnitOfMeasure.Text;
                DateTime date = Convert.ToDateTime(txtManufactureDate.Text);
                product.ManufactureDate = date.Date;
                product.ExpirationDate = Convert.ToDateTime(txtExpirationDate.Text);
                product.ExpirationDateRemaining = DataBaseFromTxt.GetDays(Convert.ToDateTime(txtExpirationDate.Text));
                product.IsRemoved = false;
                DataBaseFromTxt.AddToDB(product);
                Close();
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e) // событие - отмена добавленя товара
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInput(TextBox txtName, TextBox txtProductCode, TextBox txtStorageCode, TextBox txtPriceWithoutDiscount,
            TextBox txtPriceWithDiscount, TextBox txtDiscount, TextBox txtQuantity, TextBox txtUnitOfMeasure, 
            TextBox txtManufactureDate, TextBox txtExpirationDate) // проверка введенных данных
        {
            string expressionForString = @"[0-9""]"; // регулярное выражение от 0 до 9
            string expressionForInt = @"[a-zA-Z а-яА-Я""]"; // регулярное выражение буквы кириллица и латиница

            if (StringComparer(txtName, expressionForString) & StringComparer(txtProductCode, expressionForInt) &
                StringComparer(txtStorageCode, expressionForInt) & StringComparer(txtPriceWithoutDiscount, expressionForInt) &
                /*StringComparer(txtPriceWithDiscount, expressionForInt) &*/ StringComparer(txtDiscount, expressionForInt) &
                StringComparer(txtQuantity, expressionForInt) & StringComparer(txtUnitOfMeasure, expressionForString) &
                StringComparer(txtManufactureDate, expressionForInt) & StringComparer(txtExpirationDate, expressionForInt))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Введите корректные данные в поле ввода", "Предупреждение", 
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return false; 
            }
        }

        private bool StringComparer(TextBox ob, string expression) // метод проверки на поиск регулярных выражений
        {
            if(Regex.IsMatch(ob.Text, expression) || string.IsNullOrEmpty(ob.Text))
            {
                ob.ForeColor = Color.Red;
                return false;
            }
            ob.ForeColor = Color.Black;
            return true;
        }
    }
}
