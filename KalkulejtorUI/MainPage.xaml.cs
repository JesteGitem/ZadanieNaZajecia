using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace KalkulejtorUI
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPageViewModel : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public MainPageViewModel()
        {
            this.InitializeComponent();
            ViewModel = this;
        }
        public MainPageViewModel ViewModel { get; set; }
        public string expression = "Wprowadz Równanie";
        public string Expression
        {
            get { return expression; }
            set
            {
                expression = value;
                OnPropertyChanged("Expression");
            }
        }

        public void DeleteLastChar(object sender, RoutedEventArgs e)
        {
            if (Expression.Length > 0)
                Expression = Expression.Remove(Expression.Length - 1);
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex RegexInnerBrackets = new Regex(@"([A-Za-z]+)");
            var ContainLetters = RegexInnerBrackets.IsMatch(Expression);
            if (ContainLetters)
                Expression = ((sender as Button).Content).ToString();
            else
                Expression = Expression + (sender as Button).Content;
        }
        private void Solve(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(Expression))
            try
            {
                Expression = Kalkulator.Oblicz(Expression).ToString();
            }
            catch (Exception ex)
            {
                    Expression = ex.Message;
            }
        }
    }
}   