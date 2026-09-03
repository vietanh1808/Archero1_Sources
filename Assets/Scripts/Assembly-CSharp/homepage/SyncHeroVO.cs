using System;
using System.Collections.Generic;

namespace homepage
{
	[Serializable]
	public class SyncHeroVO
	{
		public int hero_id;

		public int skin_id;

		public Dictionary<int, List<ulong>> equips;

		public Dictionary<int, int> weapon_skin;

		public ulong[] dragons;

		public List<int> coop_heros;

		public Dictionary<int, int> wings;

		public List<int> artifacts;

		public Dictionary<int, long> totems;

		public Dictionary<int, int> weapon_skin_Color;

		public override string ToString()
		{
			return null;
		}
	}
}
