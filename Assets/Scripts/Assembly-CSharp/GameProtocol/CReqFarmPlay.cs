using System.IO;

namespace GameProtocol
{
	public sealed class CReqFarmPlay : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nRequestType;

		public ushort m_nEventUniqueId;

		public ulong m_nSpeedUpHatchId;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
