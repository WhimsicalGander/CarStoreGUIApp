using CarClassLibrary;

namespace CarStoreGUIApp
{
    //class for front end and event handlers
    public partial class CarForm : Form
    {
        Store store = new Store();

        BindingSource bindingSourceInventory = new BindingSource();
        BindingSource bindingSourceShoppingList = new BindingSource();

        public CarForm()
        {
            InitializeComponent();

            //turns the lists into binding data sources
            bindingSourceInventory.DataSource = store.carList;
            bindingSourceShoppingList.DataSource = store.shoppingList;

            listStoreInventory.DataSource = bindingSourceInventory;
            listShoppingCart.DataSource = bindingSourceShoppingList;

            lblTotal.Visible = false;



        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //processes new car properties into new car 
        private void btnCreate_Click(object sender, EventArgs e)
        {

            string make = txtMake.Text;
            string model = txtModel.Text;
            string color = txtColor.Text;
            int year = int.Parse(txtYear.Text);
            int miles = int.Parse(txtMiles.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            Car car = new Car(make, model, color, miles, year, price);


            store.carList.Add(car);

            MessageBox.Show(car + " has been added to inventory which now has " + store.carList.Count() + " cars total.");

            txtMake.Clear();
            txtModel.Clear();
            txtColor.Clear();
            txtYear.Clear();
            txtMiles.Clear();
            txtPrice.Clear();

            bindingSourceInventory.ResetBindings(false); //refreshes list

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            store.shoppingList.Add((Car)listStoreInventory.SelectedItem);

            bindingSourceShoppingList.ResetBindings(false); //refreshes list
        }

        private void listStoreInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //finds checkout amount and prints to label
        private void btnCheckout_Click(object sender, EventArgs e)
        {

            //stores total from store checkout method in variable
            decimal total = store.Checkout();

            //Prints total to label
            lblTotal.Text = total.ToString("C");
            lblTotal.Visible = true;

        }

        //sends highlighted object to delete method and refreshes list
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Dialog result form
            Form dResult = new Form();

            //dialog result buttons
            Button btnOk = new Button();
            Button btnCancel = new Button();

            btnOk.Text = "Ok";
            btnCancel.Text = "Cancel";
            dResult.Text = "You are about to delete a car.";

            //button locations on the box
            btnOk.Location = new Point(15, 15);
            btnCancel.Location = new Point(100, 15);

            //makes buttons proceed or cancel
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            //adds buttons to form
            dResult.AcceptButton = btnOk;
            dResult.CancelButton = btnCancel;
            dResult.Controls.Add(btnOk);
            dResult.Controls.Add(btnCancel);

            dResult.StartPosition = FormStartPosition.CenterScreen;

            //brings up form
            dResult.ShowDialog();


            //sends item over to delete item method if Ok button pressed
            if (dResult.DialogResult == DialogResult.OK)
            {
                store.DeleteItem((Car)listShoppingCart.SelectedItem);

                bindingSourceShoppingList.ResetBindings(false); //refreshes list
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text;

            List<Car> tempList = store.SearchItem(key);

            bindingSourceInventory.DataSource = tempList;
           
            listStoreInventory.DataSource = bindingSourceInventory;

            bindingSourceInventory.ResetBindings(false); //refreshes list
        }
    }
}
