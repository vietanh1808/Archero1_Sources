using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STLuckyPlinkoHitInfo : IProtocol
	{
		public uint m_nHitCount;

		public uint m_nHitRound;

		public ushort m_nHitGridId;

		public uint m_nPathId;

		public uint[] m_vecNailRewards;

		public CRewardItem[] m_vecNailRewardItem;

		public CRewardItem[] m_vecGridRewardItem;

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
