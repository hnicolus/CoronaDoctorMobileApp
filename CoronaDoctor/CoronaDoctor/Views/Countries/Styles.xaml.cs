﻿using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace CoronaDoctor.Views.Countries
{
    /// <summary>
    /// Class helps to reduce repetitive markup and allows to change the appearance of apps more easily.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Styles
    {
        public Styles()
        {
            InitializeComponent();
        }
    }
}