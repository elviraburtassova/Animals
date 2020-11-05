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
	public partial class TabbedPage5 : ContentPage
	{
        private async void Description_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание сов:", "крупная голова, большие круглые глаза спереди головы, клюв короткий, хищный. Охотится ночью, оперение мягкое, полёт бесшумный, когти длинные и острые, окрас маскирующий.", "Закрыть");
        }
    }
}