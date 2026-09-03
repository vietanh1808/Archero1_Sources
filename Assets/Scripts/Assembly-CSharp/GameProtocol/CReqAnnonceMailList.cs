using System.IO;

namespace GameProtocol
{
	public sealed class CReqAnnonceMailList : CProtocolBase
	{
		public uint m_nLastMailID;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
