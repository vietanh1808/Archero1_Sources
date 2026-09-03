using System.IO;

namespace GameProtocol
{
	public sealed class CReqUseChoiceItem : CProtocolBase
	{
		public uint m_nTransID;

		public uint m_nId;

		public ushort[] arryIndex;

		public ushort[] arrayCount;

		public ushort m_nType;

		public ushort m_nComposeCnt;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
