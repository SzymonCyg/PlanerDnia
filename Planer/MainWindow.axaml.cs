using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Planer;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        SubmitButton.Click += SubmitButton_Click;
    }
    private void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        try
        {
            var checkBoxValue = CheckBox.IsChecked == true ? "Ukończono zadanie" : "Nie ukończono zadania";
            var textBoxValue = TextBox.Text;
            var 

        }
        catch (Exception ex)
        {
            Podsumowanie.Text = ex.Message;
        }
        
      
    }
}