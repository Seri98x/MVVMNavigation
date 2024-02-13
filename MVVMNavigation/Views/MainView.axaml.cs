using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace MVVMNavigation.Views;

public partial class MainView : UserControl
{
  
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_PointerEntered(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        
       
        

    }

    private void Button_PointerExited(object? sender, Avalonia.Input.PointerEventArgs e)
    {
        Console.WriteLine("test2");

    }
}
