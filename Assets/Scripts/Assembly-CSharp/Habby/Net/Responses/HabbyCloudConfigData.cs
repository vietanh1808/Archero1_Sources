using System;

namespace Habby.Net.Responses
{
	[Serializable]
	public class HabbyCloudConfigData
	{
		public bool isOpenHabbyIM;

		public static HabbyCloudConfigData FromJson(string jsonStr)
		{
			return null;
		}

		public string ToJson()
		{
			return null;
		}

		public void SaveToLocal()
		{
		}
	}
}
