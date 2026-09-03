using System.IO;

namespace GameProtocol
{
	public sealed class CFarmSlot : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public ushort[] m_vecIndex;

		public ushort m_nItemRatio;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
