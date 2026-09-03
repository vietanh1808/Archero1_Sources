using System.IO;

namespace GameProtocol
{
	public sealed class CRespManorBuilding : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public uint m_nNum;

		public string m_strOrders;

		public ushort m_nLevel;

		public uint m_nExp;

		public ulong m_nAvailableRecoverTime;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
