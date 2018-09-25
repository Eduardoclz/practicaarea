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

namespace practicaArea
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

        private void RButton_Click(object sender, RoutedEventArgs e)
        {
            float rbase = float.Parse(RBase.Text);
            float raltura = float.Parse(RAltura.Text);
            float rarea = rbase * raltura;
            RArea.Text = rarea.ToString();

        }

        private void TButton_Click(object sender, RoutedEventArgs e)
        {
            float tbase = float.Parse(TBase.Text);
            float taltura = float.Parse(TAltura.Text);
            float tarea = (tbase * taltura)/2;
            TArea.Text = tarea.ToString();
        }

        private void CButton_Click(object sender, RoutedEventArgs e)
        {   
            float cradio = float.Parse(CRadio.Text);
            float carea =  (cradio * cradio) * 3.14160f ;
            CArea.Text = carea.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            float Mayor = float.Parse(mayor.Text);
            float Menor = float.Parse(menor.Text);
            float Altura = float.Parse(altura.Text);
            float Area = (Mayor + Menor)/ (Altura/2);
            area.Text = Area.ToString();
        }
    }
}
