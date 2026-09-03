namespace Org.BouncyCastle.Bcpg.Sig
{
	public class SignerUserId : SignatureSubpacket
	{
		private static byte[] UserIdToBytes(string id)
		{
			return null;
		}

		public SignerUserId(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public SignerUserId(bool critical, string userId)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public string GetId()
		{
			return null;
		}
	}
}
