﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FWApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /*   private async void Button_Click(object sender, RoutedEventArgs e)
           {

               if ((Email.Text == "Admin") && (Password.Text == "admin"))
               {

                   this.Frame.Navigate(typeof(FrontPage), null);


               }
               else
               {
                   var dialog = new MessageDialog("Email eller Password er forkert");
                   await dialog.ShowAsync();
               }

           }
           */
        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreateUserPage), null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsUserLoggedIn())
            {
                Frame f = (Frame)Window.Current.Content;
                f.Navigate(typeof(FWApp.FrontPage));
            }
        }

        private bool IsUserLoggedIn()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            var res = localSettings.Values["IsLoggenIn"];
            if (res == null)
            {
                return false;
            }
            return res.ToString() == "true" ? true : false;
        }
    }
}




