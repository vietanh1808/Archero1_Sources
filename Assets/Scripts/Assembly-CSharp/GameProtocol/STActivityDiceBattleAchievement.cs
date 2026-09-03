using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityDiceBattleAchievement : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public STCommonAchievementData[] m_vecAchievementData;

		public STCommonAchievementData[] m_vecAchievementDataLoop;

		public ushort m_nRemainReceiveTimes;

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
