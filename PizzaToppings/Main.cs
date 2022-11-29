namespace PizzaToppings
{
    public partial class Main : Form
    {
        List<Toppings> Toppings = new List<Toppings>();
        const double PRICE_TOPPINGS = 0.50;

        double PizzaPrice = 5;
        public Main()
        {
            InitializeComponent();
            toppings.DataSource = Enum.GetValues(typeof(Toppings));
        }
        private void LoadPizzaSummary()
        {
            pizzaSummary.Text = "Pizza with: ";

            foreach (var topping in Toppings)
            {
                pizzaSummary.Text += topping.ToString() + ", ";
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            Toppings.Add((Toppings)toppings.SelectedItem);
            LoadPizzaSummary();
            pizzaPrice.Text = "Price: " + (PizzaPrice += PRICE_TOPPINGS);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (Toppings.Remove((Toppings)toppings.SelectedItem))
            {
                LoadPizzaSummary();
                pizzaPrice.Text = "Price: " + (PizzaPrice -= PRICE_TOPPINGS);
            }
        }
    }
}