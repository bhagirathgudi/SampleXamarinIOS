using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
	public partial class MainPage : ContentPage
	{
		private string text;
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			if (text == null) {
				DisplayAlert("Please enter the text first","", "Ok");
			} else DisplayAlert("Hola, you entered", text, "Ok");
		}

		private void Editor_TextChanged(object sender, TextChangedEventArgs e)
		{
			Editor editor = (Editor)sender;
			text = editor.Text;
		}
	}
}
