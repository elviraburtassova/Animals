﻿using System;
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
	public partial class TabbedPage7 : ContentPage
	{
        public TabbedPage7()
        {
            InitializeComponent();
        }
        private async void Description_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Описание лошадей:", "Голова лошади — вытянутая, сухая, с большими живыми глазами, широкими ноздрями и большими или средней величины заострёнными и весьма подвижными ушами. У домашней лошади уши умеренной величины (гораздо меньше половины головы), грива длинная, свешивающаяся, шея длинная мускулистая, туловище округленное, хвост покрыт длинными волосами от основания; масти чрезвычайно различны: вороная, рыжая, гнедая, серая и т.д., часто с белыми пятнами на голове и ногах; в виде исключения встречаются полосы на плечах, спине и ногах. Ноги высокие, умеренной толщины, стройные; первого и пятого пальца нет вовсе, от 2 и 4 существуют лишь зачатки (рудименты) в виде палочкообразных костей пясти и плюсны (так наз. грифельных), прилегающих к толстой пястной или плюсневой кости сильно развитого среднего пальца; копыто одевает лишь конец среднего пальца (на них и покоится поэтому вся тяжесть тела);", "Закрыть");
        }
    }
}