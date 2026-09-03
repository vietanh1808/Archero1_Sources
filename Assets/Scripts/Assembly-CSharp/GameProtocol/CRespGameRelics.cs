using System.IO;

namespace GameProtocol
{
	public sealed class CRespGameRelics : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ushort m_nType;

		public STRelicsItem[] arrayRelicsItem;

		public ulong m_nRowId;

		public uint m_nLevel;

		public uint m_nStar;

		public string m_strAttrCounts;

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
