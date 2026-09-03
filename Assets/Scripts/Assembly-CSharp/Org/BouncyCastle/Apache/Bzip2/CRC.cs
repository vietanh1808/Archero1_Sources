namespace Org.BouncyCastle.Apache.Bzip2
{
	internal class CRC
	{
		public static readonly int[] crc32Table;

		internal int globalCrc;

		internal void InitialiseCRC()
		{
		}

		internal int GetFinalCRC()
		{
			return 0;
		}

		internal int GetGlobalCRC()
		{
			return 0;
		}

		internal void SetGlobalCRC(int newCrc)
		{
		}

		internal void UpdateCRC(int inCh)
		{
		}
	}
}
