using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    public partial class MainPage : ContentPage
    {
        private StringBuilder _morse;
        private StringBuilder _displayString;
        public MainPage()
        {
            _morse = new StringBuilder();
            _displayString = new StringBuilder();
            InitializeComponent();
        }

        public void AddToMorse(char m) => _morse.Append(m);

        public char GetLetterForMorseCode() => Morse.MorseCoder(_morse.ToString());

        public void OnDotButtonClicked(object sender, System.EventArgs e) => AddToMorse('.');

        public void OnDashButtonClicked(object sender, System.EventArgs e) => AddToMorse('-');

        public void OnSpaceButtonClicked(object sender, System.EventArgs e)
        {
            if (_morse.Length == 0) _displayString.Append(' ');
            else _displayString.Append(GetLetterForMorseCode());

            MorseDisplay.Text = _displayString.ToString();
        }
    }
}