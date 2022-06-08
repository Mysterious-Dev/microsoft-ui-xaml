﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SwitcherPrototype
{
    public class MyCollection : ObservableCollection<Object> { }

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Requires using Windows.UI.Xaml.Documents 
            Glyphs glyph = new Glyphs();
            glyph.FontUri = new Uri("ms-appx:///Assets/seguiemj.ttf");
            glyph.FontRenderingEmSize = 30;
            glyph.Indices = "300;301;305;318;500;501;506";
            glyph.Fill = new SolidColorBrush(Windows.UI.Colors.Blue);

            // Add to the visual tree (assumes stackPanel is defined in XAML page).
            stackPanel.Children.Add(glyph);
        }
    }
}
