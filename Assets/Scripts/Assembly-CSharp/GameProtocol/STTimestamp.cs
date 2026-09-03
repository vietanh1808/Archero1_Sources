using System.IO;

namespace GameProtocol
{
	public sealed class STTimestamp
	{
		public bool m_nChange;

		public CTimestampItem[] m_vecTimestampData;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		public ulong GetServerTime()
		{
			return 0uL;
		}

		public ulong GetHarvestTime()
		{
			return 0uL;
		}

		public ulong GetHarvestShortTime()
		{
			return 0uL;
		}

		public ulong GetRegisterTime()
		{
			return 0uL;
		}

		private ulong GetTime(CTimestampItem.EItemIndex type)
		{
			return 0uL;
		}

		public void Excute()
		{
		}
	}
}
