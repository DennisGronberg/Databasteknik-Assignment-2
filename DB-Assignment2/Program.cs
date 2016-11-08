using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DB_Assignment2
{
    class Program
    {
        #region Connection String
        public static string cns = ConfigurationManager.ConnectionStrings["cns"].ConnectionString;
        #endregion

        #region Menu

        static void Main(string[] args)
        {
            var val = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Add new customer");
                Console.WriteLine("2. Add new product");
                Console.WriteLine("3. Update product price");
                Console.WriteLine("0. Exit");
                Console.WriteLine("------------------------");
                val = Console.ReadLine();
                if (val == "0")
                {
                    Exit();
                    break;
                }
                else if (val == "1")
                {
                    Menu1();
                }
                else if (val == "2")
                {
                    Menu2();
                }
                else if (val == "3")
                {
                    Menu3();
                }
                else
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Not a menu choice!");
                    Console.ReadLine();
                }
            }
        }
        #endregion

        #region Methods

        public static void Exit()
        {
            Console.WriteLine("------------------------\nGoodbye!");
            Console.ReadLine();
        }

        public static void MenuText1()
        {
            Console.Clear();
            Console.WriteLine("1. Add new customer");
            Console.WriteLine("------------------------");
        }

        public static void MenuText2()
        {
            Console.Clear();
            Console.WriteLine("2. Add new product");
            Console.WriteLine("------------------------");
        }

        public static void MenuText3()
        {
            Console.Clear();
            Console.WriteLine("3. Update product price");
            Console.WriteLine("------------------------");
        }

        public static void Menu1()
        {
            #region Connection
            var cn = new SqlConnection(cns);
            #endregion
            #region Variables
            var val = "";
            var companyName = "";
            var customerID = "";
            var contactName = "";
            var contactTitle = "";
            var address = "";
            var city = "";
            var region = "";
            var postalCode = "";
            var phone = "";
            var fax = "";
            var country = "";
            #endregion

            #region CompanyName
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Example: 'Bottom-Dollar Markets'\n\n------------------------");
                Console.Write("Company name: ");
                companyName = Console.ReadLine().Trim();
                if (companyName == "")
                {
                    Console.Write("------------------------\nCan not leave blank!");
                    Console.ReadLine();
                }
                else if (companyName.Length > 40)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region CustomerID
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Max 5 chars\n-> Example: 'BOTTM'\n\n------------------------");
                Console.Write("CustomerID: ");
                customerID = Console.ReadLine().Trim();
                if (customerID == "")
                {
                    Console.Write("------------------------\nCan not leave blank!");
                    Console.ReadLine();
                }
                else if (customerID.Length > 5)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region ContactName
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Example: 'Elizabeth Lincoln'\n\n------------------------");
                Console.Write("Contact name: ");
                contactName = Console.ReadLine().Trim();
                if (contactName == "")
                {
                    Console.Write("------------------------\nCan not leave blank!");
                    Console.ReadLine();
                }
                else if (contactName.Length > 30)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region ContactTitle
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Can be left empty\n-> Example: 'Accounting Manager'\n\n------------------------");
                Console.Write("Contact title: ");
                contactTitle = Console.ReadLine().Trim();
                if (contactTitle == "")
                {
                    contactTitle = null;
                    break;
                }
                else if (contactTitle.Length > 30)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region Address
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Can be left empty\n-> Example: '23 Tsawassen Blvd.'\n\n------------------------");
                Console.Write("Address: ");
                address = Console.ReadLine().Trim();
                if (address == "")
                {
                    address = null;
                    break;
                }
                else if (address.Length > 60)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region City
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Can be left empty\n-> Example: 'Tsawassen'\n\n------------------------");
                Console.Write("City: ");
                city = Console.ReadLine().Trim();
                if (city == "")
                {
                    city = null;
                    break;
                }
                else if (city.Length > 15)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region Region
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Can be left empty\n-> Example: 'BC'\n\n------------------------");
                Console.Write("Region: ");
                region = Console.ReadLine().Trim();
                if (region == "")
                {
                    region = null;
                    break;
                }
                else if (region.Length > 15)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region PostalCode
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Can be left empty\n-> Example: 'T2F 8M4'\n\n------------------------");
                Console.Write("Postal code: ");
                postalCode = Console.ReadLine().Trim();
                if (postalCode == "")
                {
                    postalCode = null;
                    break;
                }
                else if (postalCode.Length > 10)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region Country
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Can be left empty\n-> Example: 'Canada'\n\n------------------------");
                Console.Write("Country: ");
                country = Console.ReadLine().Trim();
                if (country == "")
                {
                    country = null;
                    break;
                }
                else if (country.Length > 15)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region Phone
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Can be left empty\n-> Example: '(604) 555-4729'\n\n------------------------");
                Console.Write("Phone: ");
                phone = Console.ReadLine().Trim();
                if (phone == "")
                {
                    phone = null;
                    break;
                }
                else if (phone.Length > 24)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region Fax
            while (true)
            {
                MenuText1();
                Console.WriteLine("\n-> Can be left empty\n-> Example: '(604) 555-3745'\n\n------------------------");
                Console.Write("Fax: ");
                fax = Console.ReadLine().Trim();
                if (fax == "")
                {
                    fax = null;
                    break;
                }
                else if (fax.Length > 24)
                {
                    Console.WriteLine("------------------------\nToo long!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion

            #region Display Info
            MenuText1();
            Console.WriteLine("\nCompany name: " + companyName);
            Console.WriteLine("CustomerID: " + customerID);
            Console.WriteLine("Contact name: " + contactName);
            Console.WriteLine("Contact title: " + contactTitle);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Region: " + region);
            Console.WriteLine("Postal code: " + postalCode);
            Console.WriteLine("Country: " + country);
            Console.WriteLine("Phone: " + phone);
            Console.WriteLine("Fax: " + fax);
            Console.WriteLine("\n------------------------");
            Console.Write("Is the information correct? (Y/N): ");
            val = Console.ReadLine();
            #endregion
            #region SqlCommand
            if (val == "Y" || val == "y")
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertCustomer";
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@CompanyName", companyName);
                    cmd.Parameters.AddWithValue("@ContactName", contactName);
                    cmd.Parameters.AddWithValue("@ContactTitle", contactTitle);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@City", city);
                    cmd.Parameters.AddWithValue("@Region", region);
                    cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Fax", fax);
                    foreach (SqlParameter parameter in cmd.Parameters)
                    {
                        if (parameter.Value == null)
                        {
                            parameter.Value = DBNull.Value;
                        }
                    }
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    Console.WriteLine("------------------------\n\nCustomer was successfully added.\nReturning to menu.");
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("------------------------\n\nCustomerID already exists!");
                    Console.ReadLine();
                }
                finally
                {
                    cn.Close();
                }
            }
            #endregion
        }

        public static void Menu2()
        {
            #region Connection
            var cn = new SqlConnection(cns);
            #endregion
            #region Variables
            var val = "";
            var productName = "";
            var unitPrice = "";
            var discontinued = "";
            var supplierID = "";
            var categoryID = "";
            var quantityPerUnit = "";
            var unitsInStock = "";
            var unitsOnOrder = "";
            var reorderLevel = "";
            #endregion

            #region ProductName
            while (true)
            {
                MenuText2();
                Console.WriteLine("\n-> Example: 'Chai'\n\n------------------------");
                Console.Write("Product name: ");
                productName = Console.ReadLine().Trim();
                if (productName == "")
                {
                    Console.WriteLine("------------------------\nCan not leave blank!");
                    Console.ReadLine();
                }
                else if (productName.Length > 40)
                {
                    Console.WriteLine("------------------------\nToo long! Max 40 chars.");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region UnitPrice
            while (true)
            {
                try
                {
                    MenuText2();
                    Console.WriteLine("\n-> Example: '17,4196'\n\n------------------------");
                    Console.Write("Unit price: ");
                    unitPrice = Console.ReadLine().Trim();
                    if (unitPrice == "")
                    {
                        Console.WriteLine("------------------------\nCan not leave blank!");
                        Console.ReadLine();
                    }
                    else if (unitPrice.Contains('.'))
                    {
                        Console.Write("------------------------\nNot allowed to use dot, use decimal!");
                        Console.ReadLine();
                    }
                    else
                    {
                        double parseCatch = double.Parse(unitPrice);
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("------------------------\nOnly allowed to write a number!");
                    Console.ReadLine();
                }
            }
            #endregion
            #region Discontinued
            while (true)
            {
                try
                {
                    MenuText2();
                    Console.WriteLine("\n-> Only number 0 or 1\n\n------------------------");
                    Console.Write("Discontinued: ");
                    discontinued = Console.ReadLine().Trim();
                    int parseCatch = int.Parse(discontinued);
                    if (discontinued == "")
                    {
                        Console.WriteLine("------------------------\nCan not leave blank!");
                        Console.ReadLine();
                    }
                    else if (parseCatch < 0 || parseCatch > 1)
                    {
                        Console.WriteLine("------------------------\nOnly 0 or 1 allowed");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("------------------------\nOnly allowed to write integers!");
                    Console.ReadLine();
                }
            }
            #endregion
            #region SupplierID
            while (true)
            {
                try
                {
                    MenuText2();
                    Console.WriteLine("\n-> Can be left empty\n-> Only numbers between 1-29\n\n------------------------");
                    Console.Write("Supplier ID: ");
                    supplierID = Console.ReadLine().Trim();
                    if (supplierID == "")
                    {
                        supplierID = null;
                        break;
                    }
                    else if (int.Parse(supplierID) < 1 || int.Parse(supplierID) > 29)
                    {
                        Console.WriteLine("------------------------\nOnly numbers between 1-29!");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("------------------------\nOnly allowed to write integers!");
                    Console.ReadLine();
                }
            }
            #endregion
            #region CategoryID
            while (true)
            {
                try
                {
                    MenuText2();
                    Console.WriteLine("\n-> Can be left empty\n-> Only numbers between 1-8 or 1010\n\n------------------------");
                    Console.Write("Category ID: ");
                    categoryID = Console.ReadLine().Trim();
                    if (categoryID == "")
                    {
                        categoryID = null;
                        break;
                    }
                    else if (int.Parse(categoryID) == 1010)
                    {
                        break;
                    }
                    else if (int.Parse(categoryID) < 1 || int.Parse(categoryID) > 8)
                    {
                        Console.WriteLine("------------------------\nOnly numbers between 1-8 or 1010!");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("------------------------\nOnly allowed to write integers!");
                    Console.ReadLine();
                }
            }
            #endregion
            #region QuantityPerUnit
            while (true)
            {
                MenuText2();
                Console.WriteLine("\n-> Can be left empty\n-> Example: '10 boxes x 20 bags'\n\n------------------------");
                Console.Write("Quantity per unit: ");
                quantityPerUnit = Console.ReadLine().Trim();
                if (quantityPerUnit == "")
                {
                    quantityPerUnit = null;
                    break;
                }
                else if (quantityPerUnit.Length > 20)
                {
                    Console.WriteLine("------------------------\nToo long! Max 20 chars.");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            #endregion
            #region UnitsInStock
            while (true)
            {
                try
                {
                    MenuText2();
                    Console.WriteLine("\n-> Can be left empty\n-> Only integers.\n\n------------------------");
                    Console.Write("Units in stock: ");
                    unitsInStock = Console.ReadLine().Trim();
                    if (unitsInStock == "")
                    {
                        unitsInStock = null;
                        break;
                    }
                    int parseCatch = int.Parse(unitsInStock);
                    break;
                }
                catch
                {
                    Console.WriteLine("------------------------\nOnly allowed to write integers!");
                    Console.ReadLine();
                }
            }
            #endregion
            #region UnitsOnOrder
            while (true)
            {
                try
                {
                    MenuText2();
                    Console.WriteLine("\n-> Can be left empty\n-> Only integers.\n\n------------------------");
                    Console.Write("Units on order: ");
                    unitsOnOrder = Console.ReadLine().Trim();
                    if (unitsOnOrder == "")
                    {
                        unitsOnOrder = null;
                        break;
                    }
                    int parseCatch = int.Parse(unitsOnOrder);
                    break;
                }
                catch
                {
                    Console.WriteLine("------------------------\nOnly allowed to write integers!");
                    Console.ReadLine();
                }
            }
            #endregion
            #region ReorderLevel
            while (true)
            {
                try
                {
                    MenuText2();
                    Console.WriteLine("\n-> Can be left empty\n-> Only numbers between 0-100\n\n------------------------");
                    Console.Write("Reorder level: ");
                    reorderLevel = Console.ReadLine().Trim();
                    if (reorderLevel == "")
                    {
                        reorderLevel = null;
                        break;
                    }
                    else if (int.Parse(reorderLevel) < 0 || int.Parse(reorderLevel) > 100)
                    {
                        Console.WriteLine("------------------------\nOnly numbers between 0-100!");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("------------------------\nOnly allowed to write integers!");
                    Console.ReadLine();
                }
            }
            #endregion

            #region Display Info
            MenuText2();
            Console.WriteLine("\nProduct name: " + productName);
            Console.WriteLine("Unit price: " + unitPrice);
            Console.WriteLine("Discontinued: " + discontinued);
            Console.WriteLine("Supplier ID: " + supplierID);
            Console.WriteLine("Category ID: " + categoryID);
            Console.WriteLine("Quantity per unit: " + quantityPerUnit);
            Console.WriteLine("Units in stock: " + unitsInStock);
            Console.WriteLine("Units on order: " + unitsOnOrder);
            Console.WriteLine("Reorder level: " + reorderLevel);
            Console.WriteLine("\n------------------------");
            Console.Write("Is the information correct? (Y/N): ");
            val = Console.ReadLine();
            #endregion
            #region SqlCommand
            if (val == "Y" || val == "y")
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertProduct";
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@Discontinued", discontinued);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    cmd.Parameters.AddWithValue("@QuantityPerUnit", quantityPerUnit);
                    cmd.Parameters.AddWithValue("@UnitsInStock", unitsInStock);
                    cmd.Parameters.AddWithValue("@UnitsOnOrder", unitsOnOrder);
                    cmd.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
                    foreach (SqlParameter parameter in cmd.Parameters)
                    {
                        if (parameter.Value == null)
                        {
                            parameter.Value = DBNull.Value;
                        }
                    }
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    Console.WriteLine("------------------------\n\nProduct was successfully added.\nReturning to menu.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("------------------------\n\n" + ex.Message);
                    Console.ReadLine();
                }
                finally
                {
                    cn.Close();
                }
            }
            #endregion
        }

        public static void Menu3()
        {
            #region Connection
            var cn = new SqlConnection(cns);
            #endregion
            #region Variables
            var val = "";
            var productID = "";
            var unitPrice = "";
            #endregion

            #region ProductID
            while (true)
            {
                try
                {
                    MenuText3();
                    Console.WriteLine("\n-> Chooce the ID for the product you want to change.");
                    Console.WriteLine("\n-> The product ID has to be a integer between 1-77 or above 3078\n\n------------------------");
                    Console.Write("Product ID: ");
                    productID = Console.ReadLine().Trim();
                    int parseCatch = int.Parse(productID);
                    if (productID == "")
                    {
                        Console.WriteLine("------------------------\nCan not leave blank!");
                        Console.ReadLine();
                    }
                    else if (int.Parse(productID) >= 3078)
                    {
                        break;
                    }
                    else if (int.Parse(productID) < 1 || int.Parse(productID) > 77)
                    {
                        Console.WriteLine("------------------------\nOnly integers between 1-77 or above 3078!");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("------------------------\nOnly allowed to write integers!");
                    Console.ReadLine();
                }
            }
            #endregion
            #region UnitPrice
            while (true)
            {
                try
                {
                    MenuText3();
                    Console.WriteLine("\n-> Enter the new price of the product.");
                    Console.WriteLine("\n-> Example: '17,4196'\n\n------------------------");
                    Console.WriteLine("Product ID: " + productID);
                    Console.Write("Unit price: ");
                    unitPrice = Console.ReadLine().Trim();
                    if (unitPrice == "")
                    {
                        Console.WriteLine("------------------------\nCan not leave blank!");
                        Console.ReadLine();
                    }
                    else if (unitPrice.Contains('.'))
                    {
                        Console.Write("------------------------\nNot allowed to use dot, use decimal!");
                        Console.ReadLine();
                    }
                    else
                    {
                        double parseCatch = double.Parse(unitPrice);
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("------------------------\nOnly allowed to write a number!");
                    Console.ReadLine();
                }
            }
            #endregion

            #region Display Info
            MenuText3();
            Console.WriteLine("\nProduct ID: " + productID);
            Console.WriteLine("Unit price: " + unitPrice);
            Console.WriteLine("\n------------------------");
            Console.Write("Is the information correct? (Y/N): ");
            val = Console.ReadLine();
            #endregion
            #region SqlCommand
            if (val == "Y" || val == "y")
            {
                try
                {
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateProductPrice";
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    cn.Close();
                    if (rowsAffected == 0)
                    {
                        Console.WriteLine("------------------------\n\nProductID does not exist.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("------------------------\n\nUnit price of specified product was successfully updated.\nReturning to menu.");
                        Console.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("------------------------\n\n" + ex.Message);
                    Console.ReadLine();
                }
                finally
                {
                    cn.Close();
                }
            }
            #endregion
        }

        #endregion
    }
}
