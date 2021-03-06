﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace JanitorSystem.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AssignmentListFrontPage : Page
    {
        public AssignmentListFrontPage()
        {
            this.InitializeComponent();
        }

        //private void FPToAddAssign(object sender, RoutedEventArgs e)
        //{
        //    this.Frame.Navigate(typeof(AddAssignment), null);
        //}

        private void FPToFP(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AssignmentListFrontPage), null);
        }

        //private void FPToAddRegAssign(object sender, RoutedEventArgs e)
        //{
        //    this.Frame.Navigate(typeof(AddRegAssignment), null);
        //}

        private void FPMineOpgaverListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Frame.Navigate(typeof(AssignmentInfo), null);
        }

        private void VTMClick(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LogInPage), null);
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TimeButton_OnClick(object sender, RoutedEventArgs e)
        {
            comboBox.IsDropDownOpen = false;
            comboBox.PlaceholderText = "Tid";
        }

        private void BuildingButton_OnClick(object sender, RoutedEventArgs e)
        {
            comboBox.IsDropDownOpen = false;
            comboBox.PlaceholderText = "Bygning";
        }

        private void CriticalButton_OnClick(object sender, RoutedEventArgs e)
        {
            comboBox.IsDropDownOpen = false;
            comboBox.PlaceholderText = "Akut";
        }
    }
}
