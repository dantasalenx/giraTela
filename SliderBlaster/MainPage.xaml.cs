using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SliderBlaster
{
    public partial class MainPage : ContentPage
    {
        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            label_roda.Rotation = slider_roda.Value;
            int valorLabel = Convert.ToInt32(slider_roda.Value);
            label_valorDoSlider.Text = slider_roda.Value.ToString();
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
