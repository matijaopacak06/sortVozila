using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortiranje_Vozizila2
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            var vozilo = new Vozilo
            {
                marka1 = textBox1.Text,
                model1 = textBox2.Text,
                godinaProizvodnje1 = int.Parse(textBox3.Text),
                kilometraza1 = int.Parse(textBox4.Text)


            };
            vozila.Add(vozilo);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kriteriji = comboBox1.SelectedItem.ToString();

            if (comboBox1.SelectedItem.ToString() == "Marka") {
                textBoxSort = vozila.OrderBy(x => x.marka1).ToList();
            }
            else if (comboBox1.SelectedItem.ToString() == "Model")
            {
                textBoxSort = vozila.OrderBy(x => x.marka1).ToList();



            }
            else if (comboBox1.SelectedItem.ToString() == "GodinaProizovdnje")
            {
                textBoxSort = vozila.OrderBy(x => x.marka1).ToList();
            }
            else if (comboBox1.SelectedItem.ToString() == "Kilometraza")
            {
                textBoxSort = vozila.OrderBy(x => x.marka1).ToList();
            }

            textBoxSort.Clear();
            foreach (var vozilo in kriteriji) ;

            textBoxSort.AppendText($"{vozilo.Marka} - {vozilo.Model} - {vozilo.GodinaProizvodnje} - {vozilo.Kilometraza}{Environment.NewLine}");

        }
