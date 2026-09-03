using System.IO;

namespace GameProtocol
{
	public sealed class STTotemRefineInfo
	{
		public uint m_nRefineTimes;

		public uint m_nLockMask;

		public ushort m_nHasResult;

		public STTotemAttr m_stResultMainAttr;

		public STTotemAttr[] m_vecResultSubAttrs;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
