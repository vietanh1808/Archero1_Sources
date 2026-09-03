using System.Collections.Generic;

namespace U2
{
	public class NameGeneratorManager
	{
		public static string EquipKey;

		private static NameGeneratorManager _Instance;

		private Dictionary<string, NameGenerator> _NameGeneratorMap;

		private object _Lock;

		public static NameGeneratorManager Instance => null;

		private NameGeneratorManager()
		{
		}

		public void RegisterNameGenerator(string prefix)
		{
		}

		public void UnregisterNameGenerator(string prefix)
		{
		}

		public string Generator(string prefix)
		{
			return null;
		}

		public NameGenerator GetNameGenerator(string prefix)
		{
			return null;
		}
	}
}
