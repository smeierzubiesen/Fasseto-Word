﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginPage.xaml.cs" company="mitos[dash]kalandiel">
//   2017 by AngelSix - modified by mitos[dash]kalandiel
// </copyright>
// <summary>
//   Interaction logic for LoginPage.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Fasetto.Word
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public partial class LoginPage : BasePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginPage"/> class.
        /// </summary>
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            await this.SlideAndFadeInFromRight(0.3f);
        }

        private async void ButtonBase2_OnClick(object sender, RoutedEventArgs e)
        {
            await this.SlideAndFadeOutToLeft(0.3f);
        }
    }
}
