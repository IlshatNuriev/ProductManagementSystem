using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ProductManagementSystem.DataBase;

namespace ProductManagementSystem
{
    public partial class EditForm : Form
    {
        public int Id { get; set; } // свойство id которое будет передаваться для поиска из БД и дальнейшего редактирования
        public EditForm(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            var id = Id;
            var product = DataBaseFromTxt.GetProduct(id); // получение конкретного товара для редактирования
            txtEdProductName.Text = product.Name.ToString(); // передача данных в свойства продукта
            txtEdProductCode.Text = product.ProductCode.ToString();
            txtEdStorageCode.Text = product.StorageCode.ToString();
            txtEdPriceWithoutDiscount.Text = product.PriceWithoutDiscount.ToString();
            txtEdPriceWithDiscount.Text = product.PriceWithDiscount.ToString();
            txtEdDiscount.Text = product.Discount.ToString();
            txtEdQuantity.Text = product.Quantity.ToString();
            txtEdUnitOfMeasure.Text = product.UnitOfMeasure.ToString();
            txtEdManufactureDate.Text = product.ManufactureDate.Date.ToString();
            txtEdExpirationDate.Text = product.ExpirationDate.Date.ToString();
        }

        private void btnEdEdit_Click_1(object sender, EventArgs e) // событие - отредактировать товар
        {
            EditForm editForm = new EditForm(Id);
            if (ValidateInput(txtEdProductName, txtEdProductCode, txtEdStorageCode, txtEdPriceWithoutDiscount, txtEdPriceWithDiscount,
                    txtEdDiscount, txtEdQuantity, txtEdUnitOfMeasure, txtEdManufactureDate, txtEdExpirationDate)) // валидация данных
            {
                DialogResult = DialogResult.OK;
                DataBaseFromTxt.UpdateToDB(editForm.Id, txtEdProductName, txtEdProductCode, txtEdStorageCode, txtEdPriceWithoutDiscount, txtEdPriceWithDiscount,
                txtEdDiscount, txtEdQuantity, txtEdUnitOfMeasure, txtEdManufactureDate, txtEdExpirationDate); // обновление данных в БД
                Close();
            }
        }

        private void btnEdCancel_Click(object sender, EventArgs e) // событие - отмена редактирования
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private bool ValidateInput(TextBox txtName, TextBox txtProductCode, TextBox txtStorageCode, TextBox txtPriceWithoutDiscount,
            TextBox txtPriceWithDiscount, TextBox txtDiscount, TextBox txtQuantity, TextBox txtUnitOfMeasure, 
            TextBox txtManufactureDate, TextBox txtExpirationDate) // валидация - проверка вводимых данных
        {
            string expressionForString = @"[0-9]"; // регулярное выражение от 0 до 9
            string expressionForInt = @"[a-zA-Z а-яА-Я]"; // регулярное выражение все буквы кириллица и латиница

            if (StringComparer(txtName, expressionForString) & StringComparer(txtProductCode, expressionForInt) & // проверка на наличие регулярных выражений 
                StringComparer(txtStorageCode, expressionForInt) & StringComparer(txtPriceWithoutDiscount, expressionForInt) & // в введенных данных
                StringComparer(txtPriceWithDiscount, expressionForInt) & StringComparer(txtDiscount, expressionForInt) &
                StringComparer(txtQuantity, expressionForInt) & StringComparer(txtUnitOfMeasure, expressionForString))
                //&
                //StringComparer(txtManufactureDate, expressionForInt) & StringComparer(txtExpirationDate, expressionForInt))
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

        private bool StringComparer(TextBox ob, string expression) // метод проверка введенных данных
        {
            if (Regex.IsMatch(ob.Text, expression) || string.IsNullOrEmpty(ob.Text))
            {
                ob.ForeColor = Color.Red;
                return false;
            }
            ob.ForeColor = Color.Black;
            return true;
        }
    }
}
