using System.IO;

namespace GameProtocol
{
	public sealed class CTotem
	{
		public ulong m_nRowID;

		public uint m_nTotemID;

		public uint m_nLevel;

		public ushort m_nLock;

		public STTotemAttr m_stMainAttr;

		public STTotemAttr[] m_vecSubAttrs;

		public STTotemRefineInfo m_stRefineInfo;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}
	}
}
