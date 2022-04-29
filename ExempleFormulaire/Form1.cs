namespace ExempleFormulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MessagemButton_Click(object sender, EventArgs e)
        {
            String prenom;
            int age;
            String courriel;

            prenom = PrenomTextBox.Text.ToUpper();
            age = Convert.ToInt32(AgeTextBox.Text);
            courriel = CourrielTextBox.Text.ToLower();

            MessageBox.Show($"Bienvenue {prenom}, tu as {age} courriel {courriel}");

        }
    }
    
}