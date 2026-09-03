namespace Org.BouncyCastle.Bcpg.Sig
{
	public class PrimaryUserId : SignatureSubpacket
	{
		private static byte[] BooleanToByteArray(bool val)
		{
			return null;
		}

		public PrimaryUserId(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public PrimaryUserId(bool critical, bool isPrimaryUserId)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public bool IsPrimaryUserId()
		{
			return false;
		}
	}
}
