using System.IO;

namespace GameProtocol
{
	public sealed class STHellMap
	{
		public bool m_nChange;

		public ushort m_nMaxHellLayer;

		public ushort m_nHellLayerBoxID;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
