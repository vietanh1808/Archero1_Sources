using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	public class SignatureCreationTime : SignatureSubpacket
	{
		protected static byte[] TimeToBytes(DateTime time)
		{
			return null;
		}

		public SignatureCreationTime(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public SignatureCreationTime(bool critical, DateTime date)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public DateTime GetTime()
		{
			return default;
		}
	}
}
