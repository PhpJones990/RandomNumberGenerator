using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

// Input Error Handling (Algorithms(No Input), Length(No Input, Max), Seed(No Input, Max))
// Seed Resetting
// Add New Algorithms

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public string? algorithm = null;
        public uint? length;
        public static Dictionary<string, RNG> algorithms_pair = new Dictionary<string, RNG>();

        public Form1()
        {
            InitializeComponent();
            algorithms_pair["Xorshift"] = Algorithms.xorshift;
        }

        private void algorithm_choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            algorithm = algorithm_choice.SelectedItem?.ToString();
            Algorithms.seed = 0;
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            number_show.Text = "";
            length = Convert.ToUInt32(length_of_number.Text);
            Algorithms.seed = Convert.ToInt32(seed_input.Text);
            for (int i = 0; i < length; i++)
            {
                number_show.Text += Algorithms.wrapper_func(algorithms_pair[algorithm!]);
                Debug.WriteLine(Algorithms.state);
            }
        }
    }
}
