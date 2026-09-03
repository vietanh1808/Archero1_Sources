namespace Org.BouncyCastle.Bcpg.Sig
{
	public class IssuerKeyId : SignatureSubpacket
	{
		public long KeyId => 0L;

		protected static byte[] KeyIdToBytes(long keyId)
		{
			return null;
		}

		public IssuerKeyId(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public IssuerKeyId(bool critical, long keyId)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}
	}
}
