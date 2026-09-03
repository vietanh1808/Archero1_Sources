using System;

namespace Org.BouncyCastle.Asn1
{
	public class DerUtcTime : Asn1Object
	{
		private readonly string time;

		public string TimeString => null;

		[Obsolete("Use 'AdjustedTimeString' property instead")]
		public string AdjustedTime => null;

		public string AdjustedTimeString => null;

		public static DerUtcTime GetInstance(object obj)
		{
			return null;
		}

		public static DerUtcTime GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		public DerUtcTime(string time)
		{
		}

		public DerUtcTime(DateTime time)
		{
		}

		internal DerUtcTime(byte[] bytes)
		{
		}

		public DateTime ToDateTime()
		{
			return default;
		}

		public DateTime ToAdjustedDateTime()
		{
			return default;
		}

		private DateTime ParseDateString(string dateStr, string formatStr)
		{
			return default;
		}

		private byte[] GetOctets()
		{
			return null;
		}

		internal override void Encode(DerOutputStream derOut)
		{
		}

		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return false;
		}

		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
