using System;
using System.IO;
using ArsenalBuddy.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(DLocalFileHelper))]
namespace ArsenalBuddy.Droid
{
    public class DLocalFileHelper : LocalFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            return Path.Combine(path, filename);
        }
    }
}
