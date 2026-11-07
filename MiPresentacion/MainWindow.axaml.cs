using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MiPresentacion;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnPresentar_Click(object? sender, RoutedEventArgs e)
    {
        string nombre = txtNombre.Text.Trim();
        string apellido = txtApellido.Text.Trim();

        if (string.IsNullOrWhiteSpace(nombre))
        {
            blResultado.Text = "Por favor, ingresa tu nombre.";
            return;
        }
        if (string.IsNullOrWhiteSpace(apellido))
        {
            blResultado.Text = "Por favor, ingresa tu apellido.";
            return;
        }
        if (!int.TryParse(txtEdad.Text, out int edad))
        {
            blResultado.Text = "Por favor, ingresa una edad numérica valida.";
            return;
        }
        if (edad <= 0)
        {
            blResultado.Text = "La edad no puede ser negativa ni 0.";
            return;
        }
        blResultado.Text = $"¡Hola! Mi nombre es {nombre} {apellido}, tengo {edad} años y estoy aprendiendo a desarrollar interfaces gráficas con C#.";
    }
}