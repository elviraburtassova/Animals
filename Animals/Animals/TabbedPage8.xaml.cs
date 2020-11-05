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
	public partial class TabbedPage8 : ContentPage
	{
        public TabbedPage8()
        {
            InitializeComponent();
        }
        private async void Description_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание белок:", "Имеет удлинённое тело с пушистым длинным хвостом, длинные уши, тёмно-бурый цвет с белым брюшком, иногда серый (особенно зимой). Водятся повсюду, кроме Австралии. Белка является источником ценного меха", "Закрыть");
        }
    }
}