using System.IO;

namespace GameProtocol
{
	public sealed class CReqGameFishing : CProtocolBase
	{
		public ushort m_nType;

		public uint m_nTransID;

		public ushort m_nNum;

		public uint m_nFishingRodId;

		public uint m_nAreaId;

		public uint m_nSerialNum;

		public ushort m_nAccuracy;

		public ushort m_nCount;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
