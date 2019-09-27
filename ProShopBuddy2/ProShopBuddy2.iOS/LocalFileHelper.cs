using System;
using System.IO;
using ProShopBuddy.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocalFileHelper))]

namespace ProShopBuddy.iOS
{
    public class LocalFileHelper : ILocalFileHelper
	{
		public string GetLocalFilePath(string fileName)
		{
			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine(docFolder, "..", "library", "Databases");

			if (!Directory.Exists(libFolder))
			{
				Directory.CreateDirectory(libFolder);
			}
			return Path.Combine(libFolder, fileName);
		}
	}
}
