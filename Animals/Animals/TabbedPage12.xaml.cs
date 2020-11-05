using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Animals
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedPage12 : ContentPage
	{
        private async void Description_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание енотов:", "Енот-полоскун ростом с кошку. Длина тела 45—60 см, хвоста 20—25 см; масса 5—9 кг. Лапы короткие, с настолько развитыми пальцами, что следы похожи на отпечаток человеческой ладони. Енот может передними лапами захватывать и удерживать предметы, в том числе и мыть еду. Мех у енота густой, коричневато-серый.", "Закрыть");
        }
    }
}