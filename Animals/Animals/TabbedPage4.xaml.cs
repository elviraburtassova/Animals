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
	public partial class TabbedPage4 : ContentPage
	{
		public TabbedPage4()
		{
			InitializeComponent();
		}
		private async void Description_Clicked(object sender, EventArgs e)
        {
			await DisplayAlert("Описание зайцев:", "Зайцы живут поодиночке или парами. В отличие от кроликов, зайцы не роют нор, а сооружают гнёзда в небольших ямках. Зайчата рождаются развитыми, с шерстью и открытыми глазами, и мать остаётся с ними всего 5—6 дней, а затем лишь иногда прибегает к ним; вследствие этого много зайчат гибнет от врагов. Зрение у зайцев слабое, обоняние — хорошее, слух — превосходный. Беззащитность по отношению к многочисленным врагам (человек, хищные млекопитающие и птицы) делает их крайне осторожными и скрытными.", "Закрыть");
        }
    }
}