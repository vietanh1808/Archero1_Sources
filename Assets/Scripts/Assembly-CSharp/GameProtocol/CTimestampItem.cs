using System.IO;

namespace GameProtocol
{
	public sealed class CTimestampItem
	{
		public enum EItemIndex
		{
			ECurSrvItemIndex = 0,
			EHarvestItemIndex = 1,
			EUserRegIndex = 2,
			EQuickHarvestItemIndex = 3,
			EInvalidItemIndex = 4
		}

		public ulong m_i64Timestamp;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
