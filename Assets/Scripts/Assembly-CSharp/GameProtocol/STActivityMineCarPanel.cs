using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class STActivityMineCarPanel : IProtocol
	{
		public uint m_nPanelIndex;

		public uint[] m_vecCards;

		public ushort m_nSpecialRewardIndex;

		public uint[] m_vecCardOpenIndex;

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
