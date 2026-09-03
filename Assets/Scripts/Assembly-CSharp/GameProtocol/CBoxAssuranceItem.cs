using System.IO;

namespace GameProtocol
{
	public sealed class CBoxAssuranceItem
	{
		public enum EBoxIndex
		{
			EImprintIndex = 0,
			EInvalidItemIndex = 1
		}

		public ushort m_nBoxCountLow;

		public ushort m_nBoxCountMid;

		public ushort m_nBoxCountHigh;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
