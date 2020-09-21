using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kirill_dmitrijev11
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        
        public Page1()
        {
            InitializeComponent();
        }
          
        private void off_Clicked(object sender, EventArgs e)
        {
            a.IsVisible = true;
            odin.Opacity = 1;
            dva.Opacity = 1;
            dva.Opacity = 1;
            odin1.Opacity = 1;
            tri1.Opacity = 1;
            tri.Opacity = 1;
            a.IsVisible = false;
        }

        private void on_Clicked(object sender, EventArgs e)
        {
             oni.IsVisible = true;
            odin.Opacity = 0;
            dva.Opacity = 0;
            odin1.Opacity = 0;
            tri1.Opacity = 0;
            tri.Opacity = 0 ;
            oni.IsVisible = false;
        }
        Random rnd = new Random();
        private async void random_Clicked(object sender, EventArgs e)
        {
             s.IsVisible = true;
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            bool vastus = await DisplayAlert("Värvi muutus",
                            "Kas tahad värvi muuta? UUe värvi värtused red:"
                            + r.ToString() + " green:" + g.ToString() + " blue:" + b.ToString(),
                            "Jah", "Ei");
            if (vastus)

            {
                odin.BackgroundColor = Color.FromRgb(r, g, b);
                dva.BackgroundColor = Color.FromRgb(r, g, b);
                odin1.BackgroundColor = Color.FromRgb(r, g, b);
                tri1.BackgroundColor = Color.FromRgb(r, g, b);
                tri.BackgroundColor = Color.FromRgb(r, g, b);
            }
            else
            {
                odin.BackgroundColor = Color.FromRgb(0, 0, 0);
                odin.BackgroundColor = Color.FromRgb(0, 0, 0);
                dva.BackgroundColor = Color.FromRgb(0, 0, 0);
                odin1.BackgroundColor = Color.FromRgb(0, 0, 0);
                tri1.BackgroundColor = Color.FromRgb(0, 0, 0);
                tri.BackgroundColor = Color.FromRgb(0, 0, 0);
            }
            s.IsVisible = false;
        }

        private async void on1_Clicked(object sender, EventArgs e)
        {
             d.IsVisible = true;
            odin.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            dva.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            odin1.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            tri1.Opacity = 0;
            await Task.Run(() => Thread.Sleep(1000));
            tri.Opacity = 0;
            d.IsVisible = false;
        }

        private void lol_Clicked(object sender, EventArgs e)
        {
            f.IsVisible = true;
            odin.CornerRadius = 0;
            dva.CornerRadius = 0;
            tri1.CornerRadius = 0;
            tri.CornerRadius = 0;
            odin1.CornerRadius = 0;
            f.IsVisible = false;

        }
    }
}