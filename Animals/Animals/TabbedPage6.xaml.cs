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
	public partial class TabbedPage6 : ContentPage
	{
        public TabbedPage6()
        {
            InitializeComponent();
        }
        private async void Description_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание змей:", "Тело удлинённое, без конечностей. Длина тела от 10 см до почти 7 метров. От безногих ящериц змеи отличаются подвижным соединением левой и правой частей челюстей(что даёт возможность заглатывать добычу целиком), отсутствием подвижных век, барабанной перепонки и плечевого пояса.","Закрыть");
        }
    }
}