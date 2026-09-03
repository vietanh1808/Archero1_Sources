using System.Collections.Generic;
using UnityEngine;

namespace Habby.ContentBox
{
	public class Content : ScriptableObject
	{
		public string Name;

		public ContentView View;

		public List<ContentDllConfig> Codes;

		public List<ContentAsset> Assets;

		private Dictionary<string, ContentAsset> _assets;

		public ContentAsset GetAsset(string name)
		{
			return null;
		}

		public Object GetObject(string name)
		{
			return null;
		}
	}
}
