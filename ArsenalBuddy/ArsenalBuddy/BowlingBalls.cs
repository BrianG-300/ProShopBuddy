using System;
using MvvmCross.Core.ViewModels;

namespace ArsenalBuddy
{
    public class BowlingBalls : MvxNotifyPropertyChanged
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int _ID
        {
            get; set;
        }

        private string _serialNumber { get; set; }
        public string SERIALNUMBER
        {
            get { return _serialNumber; }
            set { _serialNumber = value; RaisePropertyChanged(() => SERIALNUMBER); }
        }

        private string _brandName { get; set; }
        public string BRANDNAME
        {
            get { return _brandName; }
            set { _brandName = value; RaisePropertyChanged(() => BRANDNAME); }
        }

        private string _modelName { get; set; }
        public string MODELNAME
        {
            get { return _modelName; }
            set { _modelName = value; RaisePropertyChanged(() => MODELNAME); }
        }

        private string _ballImage { get; set; }
        public string BALLIMAGE
        {
            get { return _ballImage; }
            set { _ballImage = value; RaisePropertyChanged(() => BALLIMAGE); }
        }

        private string _layoutImage { get; set; }
        public string LAYOUTIMAGE
        {
            get { return _layoutImage; }
            set { _layoutImage = value; RaisePropertyChanged(() => LAYOUTIMAGE); }
        }

        private string _layoutNumbers { get; set; }
        public string LAYOUTNUMBERS
        {
            get { return _layoutNumbers; }
            set { _layoutNumbers = value; RaisePropertyChanged(() => LAYOUTNUMBERS); }
        }

        private string _surfaceFinish { get; set; }
        public string SURFACEFINISH
        {
            get { return _surfaceFinish; }
            set { _surfaceFinish = value; RaisePropertyChanged(() => SURFACEFINISH); }
        }

        private string _notes { get; set; }
        public string NOTES
        {
            get { return _notes; }
            set { _notes = value; RaisePropertyChanged(() => NOTES); }
        }
    }
}
