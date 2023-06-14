//using System;
//using System.Collections.Generic;
//using ProductManagementSystem.Models;
//using ProductManagementSystem.Utilities;
//using Excel = Microsoft.Office.Interop.Excel;


//namespace ProductManagementSystem
//{
//    public static class ProductDataAccess
//    {
//        private static string fileName = @"C:\Users\649\source\Pet Projects\ProductManagementSystem\DataBase\database.xlsx";
                
//        public static List<Product> LoadFromExcel()
//        {
//            List<Product> products = new List<Product>();

//            var excelApp = new Excel.Application();

//            excelApp.Quit();
            
//            var workBook = excelApp.Workbooks.Open(fileName);
//            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.Sheets[1];

//            var lastCell = workSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);//последнюю ячейку
                                                                                                
//            int lastColumn = (int)lastCell.Column;
//            int lastRow = (int)lastCell.Row;
            
//            string[,] list = new string[50, 5];
//            try
//            {
//                for (int j = 1; j < lastRow; j++) //по всем строкам
//                {
//                    string[] temp = new string[5];
//                    for (int i = 0; i < 5; i++) // по всем колонкам
//                    {
//                        list[j, i] = workSheet.Cells[j + 1, i + 1].Text.ToString();
//                        temp[i] = list[j, i].ToString();
//                    }
//                    string name = Convert.ToString(temp[0]);
//                    DateTime expirationDateStart = Convert.ToDateTime(temp[1]);
//                    DateTime expirationDateEnd = Convert.ToDateTime(temp[2]);
//                    int expirationDateRemaining = Utilities.Utilities.GetDays(expirationDateEnd);
//                    decimal price = Convert.ToDecimal(temp[3]);
//                    int quantity = Convert.ToInt32(temp[4]);

//                    Product product = new Product();

//                    products.Add(product);


//                }
//                workBook.Close(false /*Type.Missing, Type.Missing*/); //закрыть не сохраняя
//                excelApp.Quit(); // выйти из Excel
//                GC.Collect(); // убрать за собой
                              

//            }
//            catch (Exception ex)
//            {
                
//                workBook.Close(false /*Type.Missing, Type.Missing*/); //закрыть не сохраняя
//                excelApp.Quit(); // выйти из Excel
//                GC.Collect(); // убрать за собой
//            }


//            return products; 
//        }

//        public static void UpdateDatabase(Product product)
//        {
            
//        }

//        public static void AddProduct(Product product)
//        {

//            var excelApp = new Excel.Application();

//            excelApp.Quit();
//            var workBook = excelApp.Workbooks.Open(fileName, Type.Missing, false, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing,
//            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

//            Excel.Worksheet workSheet = workBook.Sheets[1];

//            try
//            {
//                var lastCell = workSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);//последнюю ячейку


//                int lastRow = workSheet.Cells[workSheet.Rows.Count, 1].End[Excel.XlDirection.xlUp].Row;

//                workSheet.Cells[lastRow + 1, 1] = product.Name;
//                //workSheet.Cells[lastRow + 1, 2] = product.ExpirationDateStart;
//                //workSheet.Cells[lastRow + 1, 3] = product.ExpirationDateEnd;
//                //workSheet.Cells[lastRow + 1, 4] = product.Price;
//                workSheet.Cells[lastRow + 1, 5] = product.Quantity;

//                //workBook.Save();



//                workBook.Close(true, Type.Missing, Type.Missing); //закрыть сохраняя
//                excelApp.Quit(); // выйти из Excel
//                GC.Collect(); // убрать за собой

//            }
//            catch (Exception ex)
//            {
//                workBook.Close();
//                excelApp.Quit(); // выйти из Excel
//                GC.Collect(); // убрать за собой
//            }

//        }


//    }
//}
