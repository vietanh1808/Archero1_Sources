using System.IO;

namespace GameProtocol
{
	public sealed class CQueryLayerIAPInfoPacket : CProtocolBase
	{
		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
