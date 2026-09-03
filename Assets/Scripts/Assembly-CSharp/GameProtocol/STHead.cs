using System.IO;

namespace GameProtocol
{
	public sealed class STHead
	{
		public bool m_nChange;

		public STHeadItem[] m_vecSTHeadItemData;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
