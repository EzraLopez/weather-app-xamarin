using System;

using UIKit;
using Shared;

namespace WeatherAppiPhone
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void GetWeatherButton_TouchUpInside(UIButton sender)
        {
            Weather weather = Core.GetWeather(ZipCodeEdit.Text).Result;
            if (weather != null)
            {
                ResultsTitle.Text = weather.Title;
                TempText.Text = weather.Temperature;
                WindText.Text = weather.Wind;
                VisibilityText.Text = weather.Visibility;
                HumidityText.Text = weather.Humidity;
                SunriseText.Text = weather.Sunrise;
                SunsetText.Text = weather.Sunset;

                GetWeatherButton.SetTitle("Search again", UIControlState.Normal);
            }
            else
            {
                ResultsTitle.Text = "Couldn't find any results";
            }
        }
    }
}