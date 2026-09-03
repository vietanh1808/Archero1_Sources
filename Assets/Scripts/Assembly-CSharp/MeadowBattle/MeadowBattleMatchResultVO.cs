using System;
using UnityEngine;

namespace MeadowBattle
{
	[Serializable]
	public class MeadowBattleMatchResultVO : LocalSave.ICloneable<MeadowBattleMatchResultVO>
	{
		public uint cacheTransId;

		[SerializeField]
		public SendMatchResultVO matchResultVO;

		public void Clone(MeadowBattleMatchResultVO source)
		{
		}
	}
}
