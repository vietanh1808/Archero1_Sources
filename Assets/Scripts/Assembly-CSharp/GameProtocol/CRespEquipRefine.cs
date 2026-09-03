using System.IO;

namespace GameProtocol
{
	public sealed class CRespEquipRefine : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public string m_strEquipRefined;

		public STCarvingItem[] arrayCarvingItem;

		public ushort m_nType;

		public ushort m_nPosId;

		public uint m_nRefineId;

		public uint m_nExtractCnt;

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
