using System;
using System.Collections.Generic;

namespace MeadowBattle
{
	[Serializable]
	public class FormationVO
	{
		public bool isBuy;

		public List<ServerMonsterVO> layout;

		public Dictionary<int, int[]> dict;
	}
}
