using System;

namespace MeadowBattle
{
	[Serializable]
	public class MonsterLocationData
	{
		public int CharID;

		public CustomVector2Int Anchor;

		public int TempLevel;

		public MonsterLocationData Clone()
		{
			return null;
		}
	}
}
