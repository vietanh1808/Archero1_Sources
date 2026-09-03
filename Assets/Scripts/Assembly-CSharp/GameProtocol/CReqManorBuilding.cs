using System.IO;

namespace GameProtocol
{
	public sealed class CReqManorBuilding : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public uint m_nId;

		public ushort m_nNum;

		public ulong m_nVisitURawId;

		public string m_nSerialKey;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
