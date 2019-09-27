using System.IO;
using System;
using Xamarin.Forms;
using ProShopBuddy.Droid;

[assembly: Dependency(typeof(DLocalFileHelper))]
namespace ProShopBuddy.Droid
{
    public class DLocalFileHelper : ILocalFileHelper
	{
		public string GetLocalFilePath(string filename)
		{
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

			return Path.Combine(path, filename);
		}
	}
}
