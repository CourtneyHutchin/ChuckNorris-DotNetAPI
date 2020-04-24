using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckJokeForm
{
    public partial class JokeForm : Form
    {
        public JokeForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        /// <summary>
        /// Get one joke per button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void GetJoke_Click(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            JokeLbl.Text = joke.JokeText;
        }

        /// <summary>
        /// Populate the Combo Box with the joke categories
        /// </summary>
        private async void PopulateComboBox()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();

            foreach (string category in categories)
            {
                CategoryCBox.Items.Add(category);
            }
        }
    }
}
