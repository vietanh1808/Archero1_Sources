namespace TCPPacket
{
	public class PlayerDataMessage : BytesTcpPacketBase
	{
		public uint characterId;

		public int skinId;

		public int colorId;

		public int weaponSkinId;

		public int weaponSkinLv;

		public EquipItemMessage[] equipArray;

		public CardItemMessage[] cardArray;

		public ulong playerServerId;

		public uint totalIapCash;

		public override ushort GetMessageId()
		{
			return 0;
		}

		public override void Read()
		{
		}

		public override void Write()
		{
		}
	}
}
