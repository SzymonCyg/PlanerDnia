using System;
using System.Collections.ObjectModel;
using System.Linq;
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
        var noweZadanie = new Zadanie
        {
            Nazwa = " ",
            Kategoria = null,
            CzyUkonczone = 
        };
        Podsumowanie.Text = (noweZadanie.Nazwa + noweZadanie.Kategoria + noweZadanie.CzyUkonczone).ToString();
    }


    private void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        TextBlockZad.Text = TextBox.Text;
        ComboBoxZad.SelectedIndex = Kategoria.SelectedIndex;

        var noweZadanie = new Zadanie
        {
            Nazwa = TextBox.Text,
            Kategoria = ((ComboBoxItem)Kategoria.SelectedItem).Content.ToString(),
            CzyUkonczone = CheckBoxZad.IsChecked == true
        };


        Podsumowanie.Text = (noweZadanie.Nazwa + noweZadanie.Kategoria + noweZadanie.CzyUkonczone).ToString();


    }

    public class Zadanie
    {
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public bool CzyUkonczone { get; set; }
    }
}