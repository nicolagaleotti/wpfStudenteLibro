using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ScuolaLibrary;

namespace Scuola
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Studente> studenti = new List<Studente>();
        List<Libro> libri = new List<Libro>();

        int matricola = 1;
        int i = 1;

        private void btnCaricaStudente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtNome.Text == "" || txtCognome.Text == "")
                {
                    MessageBox.Show("Inserire tutti i valori", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    txtNome.Text = "";
                    txtCognome.Text = "";
                    txtNome.Focus();
                }
                else
                {
                    string nome = txtNome.Text;
                    string cognome = txtCognome.Text;
                    Studente s = new Studente(nome, cognome, matricola);
                    studenti.Add(s);
                    cmbStudenti.Items.Add(s.GetDescrizione());
                    matricola++;
                    txtNome.Text = "";
                    txtCognome.Text = "";
                    txtNome.Focus();
                    cmbStudenti.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtNome.Text = "";
                txtCognome.Text = "";
                txtNome.Focus();
            }
        }

        private void btnCaricaLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtMateria.Text == "" || txtPrezzo.Text == "")
                {
                    MessageBox.Show("Inserire tutti i valori", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    txtMateria.Text = "";
                    txtPrezzo.Text = "";
                    txtMateria.Focus();
                }
                else
                {
                    string materia = txtMateria.Text;
                    double prezzo = double.Parse(txtPrezzo.Text);
                    string isbn = "libr2020" + i.ToString();
                    i++;
                    Libro l = new Libro(materia, prezzo, isbn);
                    libri.Add(l);
                    cmbLibri.Items.Add(l.GetDescrizioneBreve());
                    txtMateria.Text = "";
                    txtPrezzo.Text = "";
                    txtMateria.Focus();
                    cmbLibri.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtMateria.Text = "";
                txtPrezzo.Text = "";
                txtMateria.Focus();
            }
        }
    }
}
