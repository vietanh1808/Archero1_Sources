namespace TCPPacket
{
	public class CreatePartBodyMessage : BytesTcpPacketBase
	{
		public int guid;

		public Vector3Message position;

		public int partId;

		public GoodData[] goodArray;

		public int aliveTime;

		public int[] skillArray;

		public int weaponId;

		public int[] debuffs;

		public string deltaBodyScale;

		public string parentAttackSpeed;

		public int[] parentSkillIds;

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
