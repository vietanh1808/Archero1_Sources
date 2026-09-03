using System.Collections.Generic;
using System.IO;

namespace GameProtocol
{
	public sealed class CRespEquipImprint : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public CImprintInfo[] arrayImprintData;

		public ushort m_nBeliefLevel;

		public uint m_nBeliefPoint;

		public uint m_nBeliefTalentPoint;

		public Dictionary<uint, ushort> m_mapBelifeTalent;

		public uint[] m_arrayBelifePos;

		public ulong m_nRowId;

		public ushort m_nLevel;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private byte[] buildPacket()
		{
			return null;
		}
	}
}
