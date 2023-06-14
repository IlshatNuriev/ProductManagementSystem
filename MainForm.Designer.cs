using System;
using System.Linq;
using System.Windows.Forms;


namespace ProductManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cmbSortBy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnExpiratedProducts = new System.Windows.Forms.Button();
            this.btnSetDiscount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExpiratedProductsList = new System.Windows.Forms.Button();
            this.txtAmountOfDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDaysToExpirationDateEnd1 = new System.Windows.Forms.TextBox();
            this.txtDaysToExpirationDateEnd2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateOfCheck = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDifferenceOfTotalCost = new System.Windows.Forms.Button();
            this.btnTotalCostWithoutDiscount = new System.Windows.Forms.Button();
            this.btnTotalCostWithDiscount = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTotalCostOfExpiratedProducts = new System.Windows.Forms.Button();
            this.btnRemoveAllExpiratedProducts = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.listViewOfTotalCost = new System.Windows.Forms.TextBox();
            this.listViewTotalCostOfExpiratedProducts = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1504, 297);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.Location = new System.Drawing.Point(30, 329);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(172, 31);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.Location = new System.Drawing.Point(1323, 329);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(172, 31);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Отсортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Наименование товара",
            "Код продукта",
            "Код места хранения",
            "Цена без скидки",
            "Цена со скидкой",
            "Скидка",
            "Количество",
            "Дата изготовления",
            "Дата окончания срока годности",
            "Кол-во дней до окончания срока годности"});
            this.cmbSortBy.Location = new System.Drawing.Point(954, 333);
            this.cmbSortBy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(352, 24);
            this.cmbSortBy.TabIndex = 1;
            this.cmbSortBy.Text = "Наименование товара";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveProduct.AutoSize = true;
            this.btnRemoveProduct.Location = new System.Drawing.Point(210, 329);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(172, 31);
            this.btnRemoveProduct.TabIndex = 4;
            this.btnRemoveProduct.Text = "Удалить товар";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnExpiratedProducts
            // 
            this.btnExpiratedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpiratedProducts.AutoSize = true;
            this.btnExpiratedProducts.Location = new System.Drawing.Point(1323, 368);
            this.btnExpiratedProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpiratedProducts.Name = "btnExpiratedProducts";
            this.btnExpiratedProducts.Size = new System.Drawing.Size(172, 31);
            this.btnExpiratedProducts.TabIndex = 5;
            this.btnExpiratedProducts.Text = "Показать товары";
            this.btnExpiratedProducts.UseVisualStyleBackColor = true;
            this.btnExpiratedProducts.Click += new System.EventHandler(this.btnExpiratedProducts_Click);
            // 
            // btnSetDiscount
            // 
            this.btnSetDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetDiscount.AutoSize = true;
            this.btnSetDiscount.Location = new System.Drawing.Point(1323, 407);
            this.btnSetDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetDiscount.Name = "btnSetDiscount";
            this.btnSetDiscount.Size = new System.Drawing.Size(172, 32);
            this.btnSetDiscount.TabIndex = 6;
            this.btnSetDiscount.Text = "Установить скидку";
            this.btnSetDiscount.UseVisualStyleBackColor = true;
            this.btnSetDiscount.Click += new System.EventHandler(this.btnSetDiscount_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список товаров, срок годности которых истекает через n-дней:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Установить скидку на товары, срок годности которых истекает через n-дней:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Список товаров с истекшим сроком годности на заданную дату:";
            // 
            // btnExpiratedProductsList
            // 
            this.btnExpiratedProductsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpiratedProductsList.AutoSize = true;
            this.btnExpiratedProductsList.Location = new System.Drawing.Point(1323, 447);
            this.btnExpiratedProductsList.Margin = new System.Windows.Forms.Padding(4);
            this.btnExpiratedProductsList.Name = "btnExpiratedProductsList";
            this.btnExpiratedProductsList.Size = new System.Drawing.Size(172, 32);
            this.btnExpiratedProductsList.TabIndex = 10;
            this.btnExpiratedProductsList.Text = "Показать товары";
            this.btnExpiratedProductsList.UseVisualStyleBackColor = true;
            this.btnExpiratedProductsList.Click += new System.EventHandler(this.btnExpiratedProductsList_Click);
            // 
            // txtAmountOfDiscount
            // 
            this.txtAmountOfDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmountOfDiscount.Location = new System.Drawing.Point(1101, 412);
            this.txtAmountOfDiscount.Name = "txtAmountOfDiscount";
            this.txtAmountOfDiscount.Size = new System.Drawing.Size(70, 22);
            this.txtAmountOfDiscount.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(961, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Размер скидки в %:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1177, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "n-дней:";
            // 
            // txtDaysToExpirationDateEnd1
            // 
            this.txtDaysToExpirationDateEnd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDaysToExpirationDateEnd1.Location = new System.Drawing.Point(1236, 372);
            this.txtDaysToExpirationDateEnd1.Name = "txtDaysToExpirationDateEnd1";
            this.txtDaysToExpirationDateEnd1.Size = new System.Drawing.Size(70, 22);
            this.txtDaysToExpirationDateEnd1.TabIndex = 14;
            // 
            // txtDaysToExpirationDateEnd2
            // 
            this.txtDaysToExpirationDateEnd2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDaysToExpirationDateEnd2.Location = new System.Drawing.Point(1236, 412);
            this.txtDaysToExpirationDateEnd2.Name = "txtDaysToExpirationDateEnd2";
            this.txtDaysToExpirationDateEnd2.Size = new System.Drawing.Size(70, 22);
            this.txtDaysToExpirationDateEnd2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1177, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "n-дней:";
            // 
            // txtDateOfCheck
            // 
            this.txtDateOfCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateOfCheck.Location = new System.Drawing.Point(1180, 452);
            this.txtDateOfCheck.Name = "txtDateOfCheck";
            this.txtDateOfCheck.Size = new System.Drawing.Size(126, 22);
            this.txtDateOfCheck.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1063, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Заданная дата:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Общая стоимость имеющихся товаров:";
            // 
            // btnDifferenceOfTotalCost
            // 
            this.btnDifferenceOfTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDifferenceOfTotalCost.AutoSize = true;
            this.btnDifferenceOfTotalCost.Location = new System.Drawing.Point(1399, 487);
            this.btnDifferenceOfTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.btnDifferenceOfTotalCost.Name = "btnDifferenceOfTotalCost";
            this.btnDifferenceOfTotalCost.Size = new System.Drawing.Size(96, 32);
            this.btnDifferenceOfTotalCost.TabIndex = 20;
            this.btnDifferenceOfTotalCost.Text = "Разница";
            this.btnDifferenceOfTotalCost.UseVisualStyleBackColor = true;
            this.btnDifferenceOfTotalCost.Click += new System.EventHandler(this.btnDifferenceOfTotalCost_Click);
            // 
            // btnTotalCostWithoutDiscount
            // 
            this.btnTotalCostWithoutDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTotalCostWithoutDiscount.AutoSize = true;
            this.btnTotalCostWithoutDiscount.Location = new System.Drawing.Point(1259, 487);
            this.btnTotalCostWithoutDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalCostWithoutDiscount.Name = "btnTotalCostWithoutDiscount";
            this.btnTotalCostWithoutDiscount.Size = new System.Drawing.Size(132, 32);
            this.btnTotalCostWithoutDiscount.TabIndex = 21;
            this.btnTotalCostWithoutDiscount.Text = "Без учета скидок";
            this.btnTotalCostWithoutDiscount.UseVisualStyleBackColor = true;
            this.btnTotalCostWithoutDiscount.Click += new System.EventHandler(this.btnTotalCostWithoutDiscount_Click);
            // 
            // btnTotalCostWithDiscount
            // 
            this.btnTotalCostWithDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTotalCostWithDiscount.AutoSize = true;
            this.btnTotalCostWithDiscount.Location = new System.Drawing.Point(1126, 487);
            this.btnTotalCostWithDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalCostWithDiscount.Name = "btnTotalCostWithDiscount";
            this.btnTotalCostWithDiscount.Size = new System.Drawing.Size(125, 32);
            this.btnTotalCostWithDiscount.TabIndex = 22;
            this.btnTotalCostWithDiscount.Text = "С учетом скидок";
            this.btnTotalCostWithDiscount.UseVisualStyleBackColor = true;
            this.btnTotalCostWithDiscount.Click += new System.EventHandler(this.btnTotalCostWithDiscount_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditProduct.AutoSize = true;
            this.btnEditProduct.Location = new System.Drawing.Point(390, 329);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(172, 31);
            this.btnEditProduct.TabIndex = 23;
            this.btnEditProduct.Text = "Редактировать";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 534);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(370, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Общая стоимость товаров с истекшим сроком годности:";
            // 
            // btnTotalCostOfExpiratedProducts
            // 
            this.btnTotalCostOfExpiratedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTotalCostOfExpiratedProducts.AutoSize = true;
            this.btnTotalCostOfExpiratedProducts.Location = new System.Drawing.Point(1323, 527);
            this.btnTotalCostOfExpiratedProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalCostOfExpiratedProducts.Name = "btnTotalCostOfExpiratedProducts";
            this.btnTotalCostOfExpiratedProducts.Size = new System.Drawing.Size(172, 31);
            this.btnTotalCostOfExpiratedProducts.TabIndex = 26;
            this.btnTotalCostOfExpiratedProducts.Text = "Показать стоимость";
            this.btnTotalCostOfExpiratedProducts.UseVisualStyleBackColor = true;
            this.btnTotalCostOfExpiratedProducts.Click += new System.EventHandler(this.btnTotalCostOfExpiratedProducts_Click);
            // 
            // btnRemoveAllExpiratedProducts
            // 
            this.btnRemoveAllExpiratedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAllExpiratedProducts.AutoSize = true;
            this.btnRemoveAllExpiratedProducts.Location = new System.Drawing.Point(1183, 566);
            this.btnRemoveAllExpiratedProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAllExpiratedProducts.Name = "btnRemoveAllExpiratedProducts";
            this.btnRemoveAllExpiratedProducts.Size = new System.Drawing.Size(312, 31);
            this.btnRemoveAllExpiratedProducts.TabIndex = 27;
            this.btnRemoveAllExpiratedProducts.Text = "Удалить товары с истекшим сроком годности";
            this.btnRemoveAllExpiratedProducts.UseVisualStyleBackColor = true;
            this.btnRemoveAllExpiratedProducts.Click += new System.EventHandler(this.btnRemoveAllExpiratedProducts_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 566);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 29;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.Location = new System.Drawing.Point(1015, 566);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(130, 31);
            this.btnClearAll.TabIndex = 31;
            this.btnClearAll.Text = "Очистить все";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // listViewOfTotalCost
            // 
            this.listViewOfTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOfTotalCost.Location = new System.Drawing.Point(949, 492);
            this.listViewOfTotalCost.Name = "listViewOfTotalCost";
            this.listViewOfTotalCost.ReadOnly = true;
            this.listViewOfTotalCost.Size = new System.Drawing.Size(156, 22);
            this.listViewOfTotalCost.TabIndex = 32;
            // 
            // listViewTotalCostOfExpiratedProducts
            // 
            this.listViewTotalCostOfExpiratedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTotalCostOfExpiratedProducts.Location = new System.Drawing.Point(1126, 531);
            this.listViewTotalCostOfExpiratedProducts.Name = "listViewTotalCostOfExpiratedProducts";
            this.listViewTotalCostOfExpiratedProducts.ReadOnly = true;
            this.listViewTotalCostOfExpiratedProducts.Size = new System.Drawing.Size(156, 22);
            this.listViewTotalCostOfExpiratedProducts.TabIndex = 33;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1533, 609);
            this.Controls.Add(this.listViewTotalCostOfExpiratedProducts);
            this.Controls.Add(this.listViewOfTotalCost);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRemoveAllExpiratedProducts);
            this.Controls.Add(this.btnTotalCostOfExpiratedProducts);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnTotalCostWithDiscount);
            this.Controls.Add(this.btnTotalCostWithoutDiscount);
            this.Controls.Add(this.btnDifferenceOfTotalCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDateOfCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDaysToExpirationDateEnd2);
            this.Controls.Add(this.txtDaysToExpirationDateEnd1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmountOfDiscount);
            this.Controls.Add(this.btnExpiratedProductsList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetDiscount);
            this.Controls.Add(this.btnExpiratedProducts);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизированная система учёта товаров с ограниченным сроком годности";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnExpiratedProducts;
        private Button btnSetDiscount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnExpiratedProductsList;
        private TextBox txtAmountOfDiscount;
        private Label label4;
        private Label label5;
        private TextBox txtDaysToExpirationDateEnd1;
        private TextBox txtDaysToExpirationDateEnd2;
        private Label label6;
        private TextBox txtDateOfCheck;
        private Label label7;
        private Label label8;
        private Button btnDifferenceOfTotalCost;
        private Button btnTotalCostWithoutDiscount;
        private Button btnTotalCostWithDiscount;
        private Button btnEditProduct;
        private Label label9;
        private Button btnTotalCostOfExpiratedProducts;
        private Button btnRemoveAllExpiratedProducts;
        private Label label10;
        private Button btnClearAll;
        private TextBox listViewOfTotalCost;
        private TextBox listViewTotalCostOfExpiratedProducts;
    }
}
