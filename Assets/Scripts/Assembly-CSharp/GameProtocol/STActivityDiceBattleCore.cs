using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityDiceBattleCore : IProtocol
	{
		public ushort m_nBossStage;

		public ushort m_nBossHpId;

		public uint m_nDamage;

		public Dictionary<ushort, ushort> m_mapWheelRewardRecord;

		public Dictionary<ushort, ushort> m_mapWheelRewardIndex;

		public ushort m_nPlayerWheelRewardPos;

		public ushort m_nPlayerDiceIndex;

		public ushort m_nBossDiceIndex;

		public ushort m_nEnterBossHpIdTimes;

		[JsonIgnore]
		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
