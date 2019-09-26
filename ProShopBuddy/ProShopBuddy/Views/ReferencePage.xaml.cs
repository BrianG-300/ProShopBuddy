using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProShopBuddy.Views
{
    public partial class ReferencePage : ContentPage
    {
        public ReferencePage()
        {
            InitializeComponent();
            var image = this.FindByName<Image>("ImgRef1");
            image.Source = ImageSource.FromResource("ProShopBuddy.Resources.WeightRemovalChart.png");

            var image2 = this.FindByName<Image>("ImgRef2");
            image2.Source = ImageSource.FromResource("ProShopBuddy.Resources.Ovalthumbdrillingguide.png");

            var image3 = this.FindByName<Image>("ImgRef3");
            image3.Source = ImageSource.FromResource("ProShopBuddy.Resources.pitchGuide.png");
        }
    }
}
