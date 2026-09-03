using System.IO;

namespace GameProtocol
{
	public sealed class CReqManorInfo : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nManorVersion;

		public ulong m_nUserRawId;

		public string m_nSerialKey;

		public ushort m_nStealPersent;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
