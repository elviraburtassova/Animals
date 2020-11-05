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
	public partial class TabbedPage2 : ContentPage 
	{
        private async void Description_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание лисиц:", "Длина тела 60—90 см, хвоста — 40—60 см, масса — 6—10 кг.", "Закрыть");
        }
    }
}