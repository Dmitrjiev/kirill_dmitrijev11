using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Threading;
using Xamarin.Forms.Internals;
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;
using Xamarin.Forms.Xaml;

namespace kirill_dmitrijev11
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        Xamarin.Forms.BoxView golova, akrug, bkrug, asljapa, bsljapa, glaz, glaza, morkovka, apugovka, bpugovka, cpugovka, ruk, ruki;
        Xamarin.Forms.Button btn1, btn2, btn3, btn4;

<<<<<<< HEAD
        public Page2()
        {

=======
        Random rnd = new Random();
        private async void colorii_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            bool vastus = await DisplayAlert("Värvi muutus",
                            "зочешь изменить на цвет? красный:"
                            + r.ToString() + " зелный:" + g.ToString() + " синий:" + b.ToString(),
                            "Jah", "Ei");
            if (vastus)

            {
                golova.BackgroundColor = Color.FromRgb(r, g, b);
                akrug.BackgroundColor = Color.FromRgb(r, g, b);
                bkrug.BackgroundColor = Color.FromRgb(r, g, b);
            }
            else
            {
                golova.BackgroundColor = Color.FromRgb(0, 0, 0);
                akrug.BackgroundColor = Color.FromRgb(0, 0, 0);
                bkrug.BackgroundColor = Color.FromRgb(0, 0, 0);
            }
        }

        private void off_Clicked(object sender, EventArgs e)
        {
            golova.Opacity = 0;
            akrug.Opacity = 0;
            bkrug.Opacity = 0;
            asljapa.Opacity = 0;
            bsljapa.Opacity = 0;
            glaza.Opacity = 0;
            morkovka.Opacity = 0;
            apugovka.Opacity = 0;
            bpugovka.Opacity = 0;
            cpugovka.Opacity = 0;
            ruk.Opacity = 0;
            ruki.Opacity = 0;
        }

        private void on_Clicked(object sender, EventArgs e)
        {
            golova.Opacity = 1;
            akrug.Opacity = 1;
            bkrug.Opacity = 1;
            asljapa.Opacity = 1;
            bsljapa.Opacity = 1;
            glaza.Opacity = 1;
            morkovka.Opacity = 1;
            apugovka.Opacity = 1;
            bpugovka.Opacity = 1;
            cpugovka.Opacity = 1;
            ruk.Opacity = 1;
            ruki.Opacity = 1;
        }
>>>>>>> 1ab4cb49e4129ae519d66b16a14cae433c2c8701

            AbsoluteLayout abs = new AbsoluteLayout();
            btn1 = new Button() { Text = "расстаять" };
            btn1.Clicked += Btn1_Clicked1;
            AbsoluteLayout.SetLayoutBounds(btn1, new Rectangle(0.1, 0.7, 110, 50));
            AbsoluteLayout.SetLayoutFlags(btn1, AbsoluteLayoutFlags.PositionProportional);

            btn2 = new Button() { Text = "слепить" };
            btn2.Clicked += Btn2_Clicked;
            AbsoluteLayout.SetLayoutBounds(btn2, new Rectangle(0.1, 0.8, 110, 50));
            AbsoluteLayout.SetLayoutFlags(btn2, AbsoluteLayoutFlags.PositionProportional);

            btn3 = new Button() { Text = "random" };
            btn3.Clicked += Btn3_Clicked;
            AbsoluteLayout.SetLayoutBounds(btn3, new Rectangle(0.1, 0.9, 110, 50));
            AbsoluteLayout.SetLayoutFlags(btn3, AbsoluteLayoutFlags.PositionProportional);

            btn4 = new Button() { Text = "красио растаять" };
            btn4.Clicked += Btn4_Clicked;
            AbsoluteLayout.SetLayoutBounds(btn4, new Rectangle(0.1, 0.6, 110, 60));
            AbsoluteLayout.SetLayoutFlags(btn4, AbsoluteLayoutFlags.PositionProportional);


            golova = new Xamarin.Forms.BoxView { Color = Color.AliceBlue, CornerRadius = 100 };
            AbsoluteLayout.SetLayoutBounds(golova, new Rectangle(0.5, 0.31, 70, 70));
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

            ruki = new Xamarin.Forms.BoxView { Color = Color.Brown, CornerRadius = 100 };
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
            abs.Children.Add(btn1);
            abs.Children.Add(btn2);
            abs.Children.Add(btn3);
            abs.Children.Add(btn4);

            Content = abs;
        }
        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            golova.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            glaz.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            glaza.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            morkovka.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            apugovka.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            bpugovka.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            cpugovka.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            akrug.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            bkrug.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
        }

        Random rnd = new Random();
        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            bool vastus = await DisplayAlert("изменить цвет",
                            "зочешь изменить на цвет? красный:"
                            + r.ToString() + " зелный:" + g.ToString() + " синий:" + b.ToString(),
                            "нет", "да");
            if (vastus)

            {
                golova.BackgroundColor = Color.FromRgb(r, g, b);
                akrug.BackgroundColor = Color.FromRgb(r, g, b);
                bkrug.BackgroundColor = Color.FromRgb(r, g, b);
            }
            else
            {
                golova.BackgroundColor = Color.FromRgb(0, 0, 0);
                akrug.BackgroundColor = Color.FromRgb(0, 0, 0);
                bkrug.BackgroundColor = Color.FromRgb(0, 0, 0);
            }
        }

        bool flag = true;
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            if (flag = true)
            {
                golova.Opacity = 1;
                akrug.Opacity = 1;
                bkrug.Opacity = 1;
                asljapa.Opacity = 1;
                bsljapa.Opacity = 1;
                glaza.Opacity = 1;
                glaz.Opacity = 1;
                morkovka.Opacity = 1;
                apugovka.Opacity = 1;
                bpugovka.Opacity = 1;
                cpugovka.Opacity = 1;
                ruk.Opacity = 1;
                ruki.Opacity = 1;
            }
        }

        private void Btn1_Clicked1(object sender, EventArgs e)
        {
            if (flag)
            {
                golova.Opacity = 0;
                akrug.Opacity = 0;
                bkrug.Opacity = 0;
                asljapa.Opacity = 0;
                bsljapa.Opacity = 0;
                glaza.Opacity = 0;
                glaz.Opacity = 0;
                morkovka.Opacity = 0;
                apugovka.Opacity = 0;
                bpugovka.Opacity = 0;
                cpugovka.Opacity = 0;
                ruk.Opacity = 0;
                ruki.Opacity = 0;
                flag = false;
            }
        }
    }
}