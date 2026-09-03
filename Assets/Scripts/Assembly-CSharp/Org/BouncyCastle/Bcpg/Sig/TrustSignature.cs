namespace Org.BouncyCastle.Bcpg.Sig
{
	public class TrustSignature : SignatureSubpacket
	{
		public int Depth => 0;

		public int TrustAmount => 0;

		private static byte[] IntToByteArray(int v1, int v2)
		{
			return null;
		}

		public TrustSignature(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public TrustSignature(bool critical, int depth, int trustAmount)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}
	}
}
