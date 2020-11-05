using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Animals
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedPage3 : ContentPage
	{
        private async void Description_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание медведей:", "Белые медведи достигают длины тела 3 метра при массе до 725 и даже 890 кг; малайский медведь — самый мелкий представитель медвежьих: в длину он не превышает 1,5 метров, высота в холке составляет всего 50—70 см; масса — 27—65 кг. Самцы на 10—20 % крупнее самок.У белых медведей разница самцов и самок в размерах и весе достигает 1, 5—2 раза.","Закрыть");
        }
    }
}