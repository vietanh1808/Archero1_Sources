using System;

namespace Org.BouncyCastle.Bcpg
{
	public class Crc24
	{
		private const int Crc24Init = 11994318;

		private const int Crc24Poly = 25578747;

		private int crc;

		public int Value => 0;

		public void Update(int b)
		{
		}

		[Obsolete("Use 'Value' property instead")]
		public int GetValue()
		{
			return 0;
		}

		public void Reset()
		{
		}
	}
}
