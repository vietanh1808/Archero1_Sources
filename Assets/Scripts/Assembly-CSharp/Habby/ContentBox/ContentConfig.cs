using System.Collections.Generic;
using UnityEngine;

namespace Habby.ContentBox
{
	public class ContentConfig : ScriptableObject
	{
		private static ContentConfig _instance;

		[HideInInspector]
		public List<ContentDllConfig> CommonDll;

		[HideInInspector]
		public List<string> DllFolder;

		public static ContentConfig Instance => null;
	}
}
