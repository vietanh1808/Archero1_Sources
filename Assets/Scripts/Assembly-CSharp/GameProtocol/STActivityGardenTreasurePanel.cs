using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityGardenTreasurePanel : IProtocol
	{
		public uint m_nPanelIndex;

		public ushort m_nCircleIndex;

		public uint[][] m_vecCircles;

		public uint[][] m_vecShuffCircles;

		public uint[] m_vecSpecialRewardIndex;

		public uint[] m_vecCircleTurnID;

		public ushort m_nTurnTimes;

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
