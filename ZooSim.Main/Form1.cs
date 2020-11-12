using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooSim.Library.Standard.Interfaces;
using ZooSim.Library.Standard.Models;
using ZooSim.Library.Standard.Services;

namespace ZooSim.Main
{
    public partial class frmMain : Form
    {
        private readonly IRandomNumGenService _randomNumgenService;
        private readonly Timer  _simTimer;


        public DateTime SimTime { get; set; }
        public IZoo Zoo { get; set; }


        public frmMain()
        {
            InitializeComponent();

            // Build any services
            _randomNumgenService = new RandomNumGenService();

            // Initialise defaults
            var animals = InitialiseDefaultZooAnimals();

            // Build the zoo
            Zoo = new Zoo("Dyball Zoo", _randomNumgenService, animals);         

            // Set the sim timer
            _simTimer = new Timer();
            _simTimer.Interval = 5000;
            _simTimer.Tick += UpdateSimLoop;

            // Set the current sim time
            SimTime = DateTime.UtcNow;

            // Update the form
            lblZooName.Text = Zoo.Name;
            lstEnclosures.View = View.Details;
            UpdateTimeDisplay();
            UpdateZooEnclosures();

            // Begin the Sim!
            _simTimer.Start();
        }


        private void UpdateZooEnclosures()
        {
            // Empty the current view
            lstEnclosures.Items.Clear();

            // Loop through the zoo's animals
            foreach(var animalType in Zoo?.Animals)
            {
                var group = new ListViewGroup(animalType.Key);

                lstEnclosures.Groups.Add(group);

                foreach (var animal in animalType.Value)
                {
                    var animalView = new ListViewItem { Group = group, Text = animal.Name };

                    animalView.SubItems.Add(new ListViewItem.ListViewSubItem(animalView, $"Health: {animal.Health}"));
                    animalView.SubItems.Add(new ListViewItem.ListViewSubItem(animalView, $"Mortality: {animal.MortalityDescription()}"));

                    lstEnclosures.Items.Add(animalView);
                }
            }
        }


        private Dictionary<string, List<Animal>> InitialiseDefaultZooAnimals()
        {
            var animals = new Dictionary<string, List<Animal>>();

            animals.Add("Monkeys", new List<Animal>
            {
                new Monkey("Monkey 1"),
                new Monkey("Monkey 2"),
                new Monkey("Monkey 3"),
                new Monkey("Monkey 4"),
                new Monkey("Monkey 5"),
            });

            animals.Add("Giraffes", new List<Animal>
            {
                new Giraffe("Giraffe 1"),
                new Giraffe("Giraffe 2"),
                new Giraffe("Giraffe 3"),
                new Giraffe("Giraffe 4"),
                new Giraffe("Giraffe 5"),
            });

            animals.Add("Elephants", new List<Animal>
            {
                new Elephant("Elephant 1"),
                new Elephant("Elephant 2"),
                new Elephant("Elephant 3"),
                new Elephant("Elephant 4"),
                new Elephant("Elephant 5"),
            });

            return animals;
        }


        private void btnFeedAnimals_Click(object sender, EventArgs e)
        {
            Zoo.FeedAnimals();
            UpdateZooEnclosures();
        }


        private void UpdateSimLoop(object sender, EventArgs e)
        {
            Zoo.Perish();
            UpdateZooEnclosures();
            UpdateTimeDisplay();
        }


        private void UpdateTimeDisplay()
        {
            SimTime = SimTime.AddHours(1);
            lblSimTime.Text = SimTime.ToString();
        }
    }
}
