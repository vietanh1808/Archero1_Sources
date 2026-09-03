using System.IO;

namespace GameProtocol
{
	public sealed class CQueryIAPInfo : CProtocolBase
	{
		public ushort m_nPlatformIndex;

		public string m_strProductID;

		private byte[] m_arrSHA256;

		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
