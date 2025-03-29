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

namespace WpfAppDiaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Persona> personas = new List<Persona>();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Profesor> profesors = new List<Profesor>();
            profesors.Add(new Profesor { Apellidos = "Gomez", Nombres = "Jaime" });
            profesors.Add(new Profesor { Apellidos = "Torrico", Nombres = "Hugo" });
            dgProfesores.ItemsSource = profesors;
            MessageBox.Show("Arriba la AL");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Curso> curso = new List<Curso>();
            curso.Add(new Curso { NombreCurso = "t", Descripcion = "tutoria de tesis" , Nota=15});
            curso.Add(new Curso { NombreCurso = "base de datos", Descripcion = "bd en oracle", Nota = 16 });
            dgCursos.ItemsSource = curso;
            MessageBox.Show("Tetracampeon");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            personas.Add(new Persona { Nombre = nombreIn.Text, Apellido= apellidoIn.Text });
            dgNombresIngresados.ItemsSource = null;
            dgNombresIngresados.ItemsSource = personas;
            
        }
    }
}
