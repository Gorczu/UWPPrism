using Prism.Windows.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Windows.Navigation;
using System.Collections.ObjectModel;

namespace Smart.UWP.Library.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string title = "Countries with code";
        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        private ObservableCollection<Country> countries;
        public ObservableCollection<Country> Countries
        {
            get { return countries; }
            set { countries = value; }
        }


        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);

            Countries = new ObservableCollection<Country>();

            Countries.Add(new Country() { CountryCode = "1", CountryName = "Canada" });
            Countries.Add(new Country() { CountryCode = "1", CountryName = "United States" });
            Countries.Add(new Country() { CountryCode = "44", CountryName = "United Kingdom" });
            Countries.Add(new Country() { CountryCode = "91", CountryName = "India" });
        }
    }
}
