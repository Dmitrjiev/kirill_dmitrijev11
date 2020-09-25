using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;
using Xamarin.Forms.Xaml;

namespace kirill_dmitrijev11
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        Xamarin.Forms.BoxView golova, akrug, bkrug, asljapa, bsljapa, glaz, glaza, morkovka, apugovka, bpugovka, cpugovka, ruk, ruki;

        private void off_Clicked(object sender, EventArgs e)
        {
        golova= 
        }

        private void on_Clicked(object sender, EventArgs e)
        {
            a
        }

        public Page2()
        {
            AbsoluteLayout abs = new AbsoluteLayout();
            golova = new Xamarin.Forms.BoxView { Color = Color.AliceBlue, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(golova, new Rectangle(0.5, 0.3, 70, 70));
            AbsoluteLayout.SetLayoutFlags(golova, AbsoluteLayoutFlags.PositionProportional);

            akrug = new Xamarin.Forms.BoxView { Color = Color.AliceBlue, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(akrug, new Rectangle(0.5, 0.4, 90, 90));
            AbsoluteLayout.SetLayoutFlags(akrug, AbsoluteLayoutFlags.PositionProportional);

            bkrug = new Xamarin.Forms.BoxView { Color = Color.AliceBlue, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(bkrug, new Rectangle(0.5, 0.5, 110, 110));
            AbsoluteLayout.SetLayoutFlags(bkrug, AbsoluteLayoutFlags.PositionProportional);

            asljapa = new Xamarin.Forms.BoxView { Color = Color.Black };
            AbsoluteLayout.SetLayoutBounds(asljapa, new Rectangle(0.5, 0.21, 40, 45));
            AbsoluteLayout.SetLayoutFlags(asljapa, AbsoluteLayoutFlags.PositionProportional);

            bsljapa = new Xamarin.Forms.BoxView { Color = Color.Black, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(bsljapa, new Rectangle(0.5, 0.26, 60, 8));
            AbsoluteLayout.SetLayoutFlags(bsljapa, AbsoluteLayoutFlags.PositionProportional);

            glaz = new Xamarin.Forms.BoxView { Color = Color.Black, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(glaz, new Rectangle(0.52, 0.3, 8, 8));
            AbsoluteLayout.SetLayoutFlags(glaz, AbsoluteLayoutFlags.PositionProportional);

            glaza = new Xamarin.Forms.BoxView { Color = Color.Black, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(glaza, new Rectangle(0.47, 0.3, 8, 8));
            AbsoluteLayout.SetLayoutFlags(glaza, AbsoluteLayoutFlags.PositionProportional);

            morkovka = new Xamarin.Forms.BoxView { Color = Color.Orange, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(morkovka, new Rectangle(0.5, 0.33, 9, 9));
            AbsoluteLayout.SetLayoutFlags(morkovka, AbsoluteLayoutFlags.PositionProportional);

            apugovka = new Xamarin.Forms.BoxView { Color = Color.Black, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(apugovka, new Rectangle(0.5, 0.38, 9, 9));
            AbsoluteLayout.SetLayoutFlags(apugovka, AbsoluteLayoutFlags.PositionProportional);

            bpugovka = new Xamarin.Forms.BoxView { Color = Color.Black, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(bpugovka, new Rectangle(0.5, 0.41, 9, 9));
            AbsoluteLayout.SetLayoutFlags(bpugovka, AbsoluteLayoutFlags.PositionProportional);

            cpugovka = new Xamarin.Forms.BoxView { Color = Color.Black, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(cpugovka, new Rectangle(0.5, 0.44, 9, 9));
            AbsoluteLayout.SetLayoutFlags(cpugovka, AbsoluteLayoutFlags.PositionProportional);

            ruk = new Xamarin.Forms.BoxView { Color = Color.Brown, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(ruk, new Rectangle(0.22, 0.38, 80, 8));
            AbsoluteLayout.SetLayoutFlags(ruk, AbsoluteLayoutFlags.PositionProportional);

            ruki = new Xamarin.Forms.BoxView { Color = Color.Brown, CornerRadius = 100};
            AbsoluteLayout.SetLayoutBounds(ruki, new Rectangle(0.78, 0.38, 80, 8));
            AbsoluteLayout.SetLayoutFlags(ruki, AbsoluteLayoutFlags.PositionProportional);

            abs.Children.Add(golova);
            abs.Children.Add(akrug);
            abs.Children.Add(bkrug);
            abs.Children.Add(asljapa);
            abs.Children.Add(bsljapa);
            abs.Children.Add(glaz);
            abs.Children.Add(glaza);
            abs.Children.Add(apugovka);
            abs.Children.Add(bpugovka);
            abs.Children.Add(cpugovka);
            abs.Children.Add(ruk);
            abs.Children.Add(ruki);
            abs.Children.Add(morkovka);

            Content = abs;
        }
    }
}