using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1_B6
{
    public partial class Form1 : Form
    {
        Farm farm;
        List<Animal> allAnimals = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cows = int.Parse(txtCows.Text);
            int sheep = int.Parse(txtSheeps.Text);
            int goats = int.Parse(txtGoats.Text);

            farm = new Farm(cows, sheep, goats);
            allAnimals.Clear();
            AddAnimalsToListView();
            MessageBox.Show("Farm initialized!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddAnimalsToListView()
        {

            int totalMilk = 0;
            int totalOffspringCows = 0, totalOffspringSheep = 0, totalOffspringGoats = 0;
            string sounds = "";

            // Thêm bò
            for (int i = 0; i < farm.Cows.Quantity; i++)
            {
                Cow cow = new Cow(1);
                int milkProduced = cow.Milk();
                int offspring = cow.GiveBirth();
                totalMilk += milkProduced;
                totalOffspringCows += offspring;
                sounds += cow.MakeSound() + " ";
                allAnimals.Add(cow);
            }

            // Thêm cừu
            for (int i = 0; i < farm.Sheep.Quantity; i++)
            {
                Sheep sheep = new Sheep(1);
                int milkProduced = sheep.Milk();
                int offspring = sheep.GiveBirth();
                totalMilk += milkProduced;
                totalOffspringSheep += offspring;
                sounds += sheep.MakeSound() + " ";
                allAnimals.Add(sheep);
            }

            // Thêm dê
            for (int i = 0; i < farm.Goats.Quantity; i++)
            {
                Goat goat = new Goat(1);
                int milkProduced = goat.Milk();
                int offspring = goat.GiveBirth();
                totalMilk += milkProduced;
                totalOffspringGoats += offspring;
                sounds += goat.MakeSound() + " ";
                allAnimals.Add(goat);
            }

            // Cập nhật TextBox cho từng loại
            txtTotalCows.Text = (farm.Cows.Quantity + totalOffspringCows).ToString();
            txtTotalSheeps.Text = (farm.Sheep.Quantity + totalOffspringSheep).ToString();
            txtTotalGoats.Text = (farm.Goats.Quantity + totalOffspringGoats).ToString();
            txtTotalMilk.Text = totalMilk.ToString();
            txtSounds.Text = sounds.Trim();
        }
    }
}
