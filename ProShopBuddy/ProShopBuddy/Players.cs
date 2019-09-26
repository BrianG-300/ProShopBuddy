using System;
using MvvmCross.ViewModels;

namespace ProShopBuddy
{
	public class Players : MvxNotifyPropertyChanged
	{
		[SQLite.PrimaryKey, SQLite.AutoIncrement]
		public int _ID
		{
			get; set;
		}

		private string _textName { get; set; }
		public string TEXTNAME
		{
			get { return _textName; }
			set { _textName = value; RaisePropertyChanged(() => TEXTNAME); }
		}

		private string _LfinRev { get; set; }
		public string LFINREV
		{
			get { return _LfinRev; }
			set { _LfinRev = value; RaisePropertyChanged(() => LFINREV); }
		}

		private string _LfinLat { get; set; }
		public string LFINLAT
		{
			get { return _LfinLat; }
			set { _LfinLat = value; RaisePropertyChanged(() => LFINLAT); }
		}

		private string _LfinFor { get; set; }
		public string LFINFOR
		{
			get { return _LfinFor; }
			set { _LfinFor = value; RaisePropertyChanged(() => LFINFOR); }
		}

		private string _LDrill { get; set; }
		public string LDRILL
		{
			get { return _LDrill; }
			set { _LDrill = value; RaisePropertyChanged(() => LDRILL); }
		}

		private string _RfinRev { get; set; }
		public string RFINREV
		{
			get { return _RfinRev; }
			set { _RfinRev = value; RaisePropertyChanged(() => RFINREV); }
		}

		private string _RfinLat { get; set; }
		public string RFINLAT
		{
			get { return _RfinLat; }
			set { _RfinLat = value; RaisePropertyChanged(() => RFINLAT); }
		}

		private string _RfinFor { get; set; }
		public string RFINFOR
		{
			get { return _RfinFor; }
			set { _RfinFor = value; RaisePropertyChanged(() => RFINFOR); }
		}

		private string _RDrill { get; set; }
		public string RDRILL
		{
			get { return _RDrill; }
			set { _RDrill = value; RaisePropertyChanged(() => RDRILL); }
		}

		private string _MidInsert { get; set; }
		public string MIDINSERT
		{
			get { return _MidInsert; }
			set { _MidInsert = value; RaisePropertyChanged(() => MIDINSERT); }
		}

		private string _RingInsert { get; set; }
		public string RINGINSERT
		{
			get { return _RingInsert; }
			set { _RingInsert = value; RaisePropertyChanged(() => RINGINSERT); }
		}

		private string _LSpan { get; set; }
		public string LSPAN
		{
			get { return _LSpan; }
			set { _LSpan = value; RaisePropertyChanged(() => LSPAN); }
		}

		private string _RSpan { get; set; }
		public string RSPAN
		{
			get { return _RSpan; }
			set { _RSpan = value; RaisePropertyChanged(() => RSPAN); }
		}

		private string _ThumbRev { get; set; }
		public string THUMBREV
		{
			get { return _ThumbRev; }
			set { _ThumbRev = value; RaisePropertyChanged(() => THUMBREV); }
		}

		private string _ThumbRLat { get; set; }
		public string THUMBRLAT
		{
			get { return _ThumbRLat; }
			set { _ThumbRLat = value; RaisePropertyChanged(() => THUMBRLAT); }
		}

		private string _ThumbLLat { get; set; }
		public string THUMBLLAT
		{
			get { return _ThumbLLat; }
			set { _ThumbLLat = value; RaisePropertyChanged(() => THUMBLLAT); }
		}

		private string _ThumbFor { get; set; }
		public string THUMBFOR
		{
			get { return _ThumbFor; }
			set { _ThumbFor = value; RaisePropertyChanged(() => THUMBFOR); }

		}

		private string _ThumbDrill { get; set; }
		public string THUMBDRILL
		{
			get { return _ThumbDrill; }
			set { _ThumbDrill = value; RaisePropertyChanged(() => THUMBDRILL); }
		}

		private string _pap { get; set; }
		public string PAP
		{
			get { return _pap; }
			set { _pap = value; RaisePropertyChanged(() => PAP); }
		}

		private string _bridge { get; set; }
		public string BRIDGE
		{
			get { return _bridge; }
			set { _bridge = value; RaisePropertyChanged(() => BRIDGE); }
		}

		private string _notes { get; set; }
		public string NOTES
		{
			get { return _notes; }
			set { _notes = value; RaisePropertyChanged(() => NOTES); }
		}

		private string _Email { get; set; }
		public string EMAIL
		{
			get { return _Email; }
			set { _Email = value; RaisePropertyChanged(() => EMAIL); }
		}

		private string _ballspeed { get; set; }
		public string BALLSPEED
		{
            get { return _ballspeed; }
            set { _ballspeed = value; RaisePropertyChanged(() => BALLSPEED); }
		}

		private string _revrate { get; set; }
		public string REVRATE
		{
            get { return _revrate; }
            set { _revrate = value; RaisePropertyChanged(() => REVRATE); }
		}

		private string _axistilt { get; set; }
		public string AXISTILT
		{
            get { return _axistilt; }
            set { _axistilt = value; RaisePropertyChanged(() => AXISTILT); }
		}

		private string _axisrotation { get; set; }
		public string AXISROTATION
		{
            get { return _axisrotation; }
            set { _axisrotation = value; RaisePropertyChanged(() => AXISROTATION); }
		}
	}
}
