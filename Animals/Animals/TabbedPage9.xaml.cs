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
	public partial class TabbedPage9 : ContentPage
	{
        public TabbedPage9()
        {
            InitializeComponent();
        }
        private async void Description_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание лосей:", "Длина тела самца до 3 м, высота в холке до 2,3 м, длина хвоста 12—13 см[5]; масса 360—600 кг; на Дальнем Востоке России и в Канаде — до 655 кг. Самки меньше. По внешнему облику лось заметно отличается от других оленевых. Туловище и шея у него короткие, холка высокая, в виде горба. Ноги сильно вытянутые, поэтому, чтобы напиться, лось вынужден заходить глубоко в воду или становиться на запястья. Голова крупная, горбоносая, с нависающей мясистой верхней губой.Под горлом мягкий кожистый вырост(«серьга»), достигающий 25—40 см.Шерсть грубая, буровато - чёрная; ноги светло-серые, почти белые. Копыта на передних ногах заострены, что позволяет лосю использовать их как оружие в стычках с хищниками вроде волков или медведей(но не в брачных поединках с соперниками, чтобы не нанести им увечий).Всего одного удара таким копытом достаточно для того, чтобы пробить врагу череп или распороть живот.","Закрыть");
        }
    }
}