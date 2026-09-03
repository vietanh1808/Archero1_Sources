using System.Collections.Generic;

namespace ThinkingAnalytics
{
	public class TDPresetProperties
	{
		public string AppVersion => null;

		public string BundleId => null;

		public string Carrier => null;

		public string DeviceId => null;

		public string DeviceModel => null;

		public string Manufacturer => null;

		public string NetworkType => null;

		public string OS => null;

		public string OSVersion => null;

		public long ScreenHeight => 0L;

		public long ScreenWidth => 0L;

		public string SystemLanguage => null;

		public double ZoneOffset => 0.0;

		private Dictionary<string, object> PresetProperties { get; set; }

		public TDPresetProperties(Dictionary<string, object> properties)
		{
		}

		public Dictionary<string, object> ToEventPresetProperties()
		{
			return null;
		}
	}
}
