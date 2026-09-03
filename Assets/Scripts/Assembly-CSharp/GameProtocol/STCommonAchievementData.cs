using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STCommonAchievementData : IProtocol
	{
		public uint m_nId;

		public uint m_nTarget;

		public uint[][] m_vecRewards;

		public bool m_bReceived;

		public ushort m_SpecialShow;

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
