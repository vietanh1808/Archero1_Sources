using System.IO;

namespace GameProtocol
{
	public sealed class CShipBattleMultipleEventsConf
	{
		public ushort nStage;

		public ulong nPreTimestamp;

		public ulong nStartTimestamp;

		public ulong nEndTimestamp;

		public ulong nShowTimestamp;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writter)
		{
		}

		public byte[] buildPacket()
		{
			return null;
		}
	}
}
