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

namespace PracticaAreadefiguras
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calcular1_Click(object sender, RoutedEventArgs e)
        {
            int baset = int.Parse(txtbaset.Text);
            int alltura = int.Parse(txtalturat.Text);
            int resultador = baset * alltura;
            lblarear.Text = resultador.ToString();
        }

        private void Calculartri_Click(object sender, RoutedEventArgs e)
        {
            double basetri = double.Parse(txtbasetri.Text);
            double alturatri = double.Parse(txtalturatri.Text);
            double resultadotri = (basetri * alturatri) / 2;
            areat.Text = resultadotri.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double radioc = double.Parse(txtradio.Text);
            double resultadoc = Math.PI * (radioc * radioc);
            txtresultadoareac.Text = resultadoc.ToString();
        }

        private void Areatra_Click(object sender, RoutedEventArgs e)
        {
            double basemayor = double.Parse(txtbasemayor.Text);
            double basemenor = double.Parse(txtbasemenor.Text);
            double altura = double.Parse(txtalturatra.Text);
            double areatrapecio = ((basemayor + basemenor) * altura) / 2;
            lblresultadotra.Text = areatrapecio.ToString();
        }
    }
}
