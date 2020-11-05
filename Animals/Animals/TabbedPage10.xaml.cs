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
	public partial class TabbedPage10 : ContentPage
	{

        private async void Description_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание бобров:", "Бобр — крупный грызун, приспособленный к полуводному образу жизни. Длина его тела достигает 1—1,3 м, высота в плече — до 35,5 см, а масса — до 30—32 кг. Половой диморфизм выражен слабо, самки крупнее. Тело у бобра приземистое, с укороченными пятипалыми конечностями; задние значительно сильнее передних. Между пальцами имеются плавательные перепонки, сильно развитые на задних конечностях и слабо — на передних. Когти на лапах сильные, уплощённые. Коготь II пальца задних конечностей раздвоен — им бобр расчёсывает мех. Хвост веслообразный, сильно уплощённый сверху вниз; его длина — до 30 см, ширина — 10—13 см. Волосы на хвосте имеются лишь у его основания.", "Закрыть");
        }
    }
}