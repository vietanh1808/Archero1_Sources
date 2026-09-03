using System.Collections.Generic;
using Cooperation.NetData;

namespace TCPPacket
{
	public class PlayerProofreadingAttMessage : BytesTcpPacketBase
	{
		public long playerHp;

		public long playerAttack;

		public long moveSpeed;

		public int integralFactor;

		public PVPPlayerAttInfo attInfo;

		public List<AddAttStringData> addAttlist;

		public List<AddAttStringData> outsideAttlist;

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
