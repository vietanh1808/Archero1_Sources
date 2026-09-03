namespace Org.BouncyCastle.Bcpg.Sig
{
	public class SignatureExpirationTime : SignatureSubpacket
	{
		public long Time => 0L;

		protected static byte[] TimeToBytes(long t)
		{
			return null;
		}

		public SignatureExpirationTime(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public SignatureExpirationTime(bool critical, long seconds)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}
	}
}
