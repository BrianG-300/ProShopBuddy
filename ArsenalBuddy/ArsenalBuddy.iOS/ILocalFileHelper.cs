using System;
using System.IO;
using ArsenalBuddy.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(ILocalFileHelper))]
namespace ArsenalBuddy.iOS
{
    public class ILocalFileHelper : LocalFileHelper
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
