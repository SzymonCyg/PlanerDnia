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
        ClearButton.Click += ClearButton_Click;
    }

    private void ClearButton_Click(object? sender, RoutedEventArgs e)
    {
       CheckBoxZad.IsChecked = false;
        TextBlockZad.Text = null;
        ComboBoxZad = null;
    }


    private void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        var Checkbox= CheckBoxZad.IsChecked == true ? "Ukończono zadanie" : "Nie ukończono zadania";
        TextBlockZad.Text = TextBox.Text;
        ComboBoxZad.SelectedItem = Kategoria.SelectedItem;









    }
}