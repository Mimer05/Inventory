using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        //declaring variables to use 
        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        private int _Quantity;
        private double _SellPrice;
        private BindingSource showProductList;

        public frmAddProduct()
        {
            InitializeComponent();
            //instantiate the BindingSource class
            showProductList = new BindingSource();
        }
        //The methods in Method.txt that I copy which is the regex and the throw if its not match
        private string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                throw new StringFormatException("Product name should contain only letters.");
                return name;
        }
        private int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
                throw new NumberFormatException("Quantity should be a valid integer.");
                return Convert.ToInt32(qty);
        }

        private double Selling_Price(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                throw new CurrencyFormatException("Selling price should be a valid positive number.");
                return Convert.ToDouble(price);
        }
        private void frmAddProduct_Load(object sender, EventArgs e)
        {//string array that created to show inside comboBox
            string[] ListOfProductCategory = { "Beverages", "Bread / Bakery", "Canned / Jarred Goods", "Dairy", "Frozen Goods", "Meat", "Personal Care", "Other" };

            foreach (string List in ListOfProductCategory)
            {
                cbCategory.Items.Add(List);
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try//trying to inspect if the code has anything error
            {//adding the following code to the button AddProduct to gather info if its right, and show the result
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = Selling_Price(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException ee)//catching the error, navigate and show in messageBox is the error
            {
                MessageBox.Show($"String Format Error: {ee.Message}", "Error");
            }
            catch (NumberFormatException ee)
            {
                MessageBox.Show($"Number Format Error: {ee.Message}", "Error");
            }
            catch (CurrencyFormatException ee)
            {
                MessageBox.Show($"Currency Format Error: {ee.Message}", "Error");
            }
            catch (Exception ee)
            {
                MessageBox.Show($"Unexpected Error: {ee.Message}", "Error");
            }
            finally//having a default last message whatever happens
            {
                MessageBox.Show("Complete operation");
            }
        }
    }
    public class NumberFormatException : Exception //making a custom exception
    {
        public NumberFormatException(string message) : base(message) { }
    }

    public class StringFormatException : Exception
    {
        public StringFormatException(string message) : base(message) { }
    }

    public class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string message) : base(message) { }
    }

    public class ProductClass //the class that has encapsulation
    {
        private int _Quantity;
        private double _SellingPrice;
        private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;
        public ProductClass(string ProductName, string Category, string MfgDate, string ExpDate,
        double Price, int Quantity, string Description)
        {
            this._Quantity = Quantity;
            this._SellingPrice = Price;
            this._ProductName = ProductName;
            this._Category = Category;
            this._ManufacturingDate = MfgDate;
            this._ExpirationDate = ExpDate;
            this._Description = Description;
        }
        public string productName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this._ProductName = value;
            }
        }
        public string category
        {
            get 
            { 
                return this._Category;
            }
            set
            {
                this._Category = value;
            }
        }
        public string manufacturingDate
        {
            get
            {
                return this._ManufacturingDate;
            }
            set
            {
                this._ManufacturingDate = value;
            }
        }
        public string expirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this._ExpirationDate = value;
            }
        }
        public string description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this._Description = value;
            }
        }
        public int quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this._Quantity = value;
            }
        }
        public double sellingPrice
        {
            get
            {
                return this._SellingPrice;
            }
            set
            {
                this._SellingPrice = value;
            }
        }
    }
}
