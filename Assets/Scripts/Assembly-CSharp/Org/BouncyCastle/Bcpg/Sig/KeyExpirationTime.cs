namespace Org.BouncyCastle.Bcpg.Sig
{
	public class KeyExpirationTime : SignatureSubpacket
	{
		public long Time => 0L;

		protected static byte[] TimeToBytes(long t)
		{
			return null;
		}

		public KeyExpirationTime(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public KeyExpirationTime(bool critical, long seconds)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}
	}
}
