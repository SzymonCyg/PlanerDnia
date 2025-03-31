using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Layout;

namespace Planer;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    
    
    public List<ListBoxItem> addedItems = new List<ListBoxItem>();
    public void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        var comboBoxValue = (ComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "No selection";
        var textBoxValue = TextBox.Text;

        
        var newItem = new ListBoxItem();

        
        var checkBox = new CheckBox { Content = "Czy zrobione?", Name = "MyCheckBox"};

        
        var textBlock = new TextBlock { Text = $"{textBoxValue} : {comboBoxValue}"};

        
        newItem.Content = new StackPanel
        {
            Orientation = Orientation.Vertical,
            Children =
            {
                textBlock,
                checkBox
            }
        };

        
        ListBox.Items.Add(newItem);
        
        
        addedItems.Add(newItem);
        
    }

    public void SaveButton_Click(object? sender, RoutedEventArgs e)
    {
        int zadania = ListBox.Items.Count;
        int ukonczoneZad = 0;

        foreach (var item in ListBox.Items)
        {
            if (item is ListBoxItem listBoxItem && listBoxItem.Content is StackPanel panel)
            {
                var checkBox = panel.Children.OfType<CheckBox>().FirstOrDefault();
                if (checkBox != null && checkBox.IsChecked == true)
                {
                    ukonczoneZad++;
                }
            }
        }

        TextBlock.Text = $"Zadania: {zadania}, Ukończone: {ukonczoneZad}";
    }
    public void ClearButton_Click(object? sender, RoutedEventArgs e)
    {
        if (addedItems.Any()) 
        {
            var itemToRemove = addedItems.Last(); 
            ListBox.Items.Remove(itemToRemove);   
            addedItems.Remove(itemToRemove);      
        }
    }
}
