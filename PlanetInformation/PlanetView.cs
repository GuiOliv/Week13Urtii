namespace PlanetInformation
{
    public partial class PlanetView : Form
    {
        public PlanetView()
        {
            InitializeComponent();
        }

        private void LoadInfo(Planets planet)
        {
            switch (planet)
            {
                case Planets.Mercury:
                    labelGravity.Text = "The gravity in " + planet.ToString() + " is 50.43 m/s"; 
                    break;
                case Planets.Venus:
                    labelGravity.Text = "The gravity in " + planet.ToString() + " is 32.46 m/s";
                    break;
                case Planets.Earth:
                    labelGravity.Text = "The gravity in " + planet.ToString() + " is 1.50 m/s";
                    break;
                case Planets.Mars:
                    labelGravity.Text = "The gravity in " + planet.ToString() + " is 3.10 m/s";
                    break;
                case Planets.Jupiter:
                    labelGravity.Text = "The gravity in " + planet.ToString() + " is 24.79 m/s";
                    break;
            }
        }

        #region Buttons
        private void MercuryBtn_Click(object sender, EventArgs e)
        {
            LoadInfo(Planets.Mercury);
        }

        private void VenusBtn_Click(object sender, EventArgs e)
        {
            LoadInfo(Planets.Venus);
        }

        private void EarthBtn_Click(object sender, EventArgs e)
        {
            LoadInfo(Planets.Earth);
        }

        private void MarsBtn_Click(object sender, EventArgs e)
        {
            LoadInfo(Planets.Mars);
        }

        private void JupiterBtn_Click(object sender, EventArgs e)
        {
            LoadInfo(Planets.Jupiter);
        }
        #endregion
    }
}