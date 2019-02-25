using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThingSlider
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SliderBehavior : ContentPage
	{
		public SliderBehavior ()
		{
			InitializeComponent ();
            //Content = new Label
            //{
            //    Text = "Hello"
            //};
            localImage.Source = ImageSource.FromFile("background.jpg");
            //label.FontSize = 18;
            //label.Text = "Hello";
            //slider.Value = 0;   
 		}
         
        
        //void slideMode()
        //{
             
        //    //Slider slider = new Slider()
        //    //{
        //    //    Maximum = 360
        //    //};
            
        //}
        
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //slideMode();
            if (e.NewValue > 0)
            {
                //colorChange.BackgroundColor = "Black";
                localImage.Source = ImageSource.FromFile("background_2.jpg"); 
            }
             
             
        }
    }
}