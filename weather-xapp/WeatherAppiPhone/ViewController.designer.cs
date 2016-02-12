// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WeatherAppiPhone
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton GetWeatherButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel HumidityText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel ResultsTitle { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel SunriseText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel SunsetText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel TempText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel VisibilityText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel WindText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField ZipCodeEdit { get; set; }

		[Action ("GetWeatherButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void GetWeatherButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (GetWeatherButton != null) {
				GetWeatherButton.Dispose ();
				GetWeatherButton = null;
			}
			if (HumidityText != null) {
				HumidityText.Dispose ();
				HumidityText = null;
			}
			if (ResultsTitle != null) {
				ResultsTitle.Dispose ();
				ResultsTitle = null;
			}
			if (SunriseText != null) {
				SunriseText.Dispose ();
				SunriseText = null;
			}
			if (SunsetText != null) {
				SunsetText.Dispose ();
				SunsetText = null;
			}
			if (TempText != null) {
				TempText.Dispose ();
				TempText = null;
			}
			if (VisibilityText != null) {
				VisibilityText.Dispose ();
				VisibilityText = null;
			}
			if (WindText != null) {
				WindText.Dispose ();
				WindText = null;
			}
			if (ZipCodeEdit != null) {
				ZipCodeEdit.Dispose ();
				ZipCodeEdit = null;
			}
		}
	}
}
