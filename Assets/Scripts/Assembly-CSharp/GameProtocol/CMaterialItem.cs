using System.IO;

namespace GameProtocol
{
	public sealed class CMaterialItem : IProtocol
	{
		public const ushort MsgType = ushort.MaxValue;

		public uint m_nEquipID;

		public uint m_nMaterial;

		public ushort GetMsgType => 0;

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
