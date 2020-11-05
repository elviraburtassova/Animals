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
	public partial class TabbedPage11 : ContentPage
	{
        public TabbedPage11()
        {
            InitializeComponent();
        }
        private async void Description_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание горностаев:", "Горностай — небольшой зверёк типичного куньего облика с длинным телом на коротких ногах, длинной шеей и треугольной головой с небольшими округлыми ушами. Длина тела самца — 17—38 см (самки примерно вдвое меньше), длина хвоста составляет около 35 % от длины тела — 6—12 см; масса тела — от 70 до 260 г. Похож на обыкновенную ласку, но несколько больше её по размерам и чёрный окрас распушённого кончика более длинного хвоста. Более схожа с длиннохвостой лаской, но мельче её. Окрас меха покровительственный: зимой чисто белый, летом двухцветный — верх тела буровато - рыжий, низ желтовато - белый.Зимний окрас характерен для районов, где минимум 40 дней в году лежит снег.Кончик хвоста чёрный в течение всего года.Географическая изменчивость качества зимнего меха, окраски летнего меха и размеров тела позволяет выделить порядка 26 подвидов горностая","Закрыть");
        }
    }
}