using System.Collections.Generic;

namespace Habby.ContentBox
{
	public class AssetManager
	{
		private Dictionary<string, Content> _contents;

		public static AssetManager Instance => null;

		public bool Exists(string content)
		{
			return false;
		}

		public Content Get(string content)
		{
			return null;
		}

		public Content Load(string content)
		{
			return null;
		}

		public void Release(string content)
		{
		}

		public void ReleaseAll()
		{
		}

		public void Add(string content, Content asset)
		{
		}

		public void Destroy()
		{
		}
	}
}
