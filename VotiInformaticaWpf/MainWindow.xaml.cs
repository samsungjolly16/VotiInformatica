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

namespace VotiInformaticaWpf
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

        private void btnMostra_Click(object sender, RoutedEventArgs e)
        {

            if (txtVoto1.Text != "" && txtVoto2.Text != "" && txtVoto3.Text != "" && txtQuartoVoto.Text != "")
            {
                double voto1 = double.Parse(txtVoto1.Text);
                double voto2 = double.Parse(txtVoto2.Text);
                double voto3 = double.Parse(txtVoto3.Text);
                double voto4 = double.Parse(txtQuartoVoto.Text);
                if (voto1 > 10 || voto1 < 2)
                {
                    MessageBox.Show("attenzione inserire un voto da 2 a 10", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtVoto1.Clear();
                    txtVoto1.Focus();
                }
                else if (voto2 > 10 || voto2 < 2)
                {
                    MessageBox.Show("attenzione inserire un voto da 2 a 10", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtVoto2.Clear();
                    txtVoto2.Focus();
                }
                else if (voto3 > 10 || voto3 < 2)
                {
                    MessageBox.Show("attenzione inserire un voto da 2 a 10", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtVoto3.Clear();
                    txtVoto3.Focus();
                }
                else if (voto4 > 10 || voto4 < 2)
                {
                    MessageBox.Show("attenzione inserire un voto da 2 a 10", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                    txtQuartoVoto.Clear();
                    txtQuartoVoto.Focus();
                }
                else
                {
                    try
                    {


                        double media = 0;
                        double totale = 0;
                        totale += voto1 + voto2 + voto3 + voto4;
                        media = totale / 4;
                        txt_RisultatoMedia.Text = media.ToString();
                        if (media >= 6)
                            lblPromossoBocciato.Content = "Promosso";
                        else
                            lblPromossoBocciato.Content = "Bocciato";
                    }
                    catch (Exception ex)
                    {
                        txt_RisultatoMedia.Text = ex.Message;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("inserire tutti i dati richiesti", "attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


        }
    }
}
