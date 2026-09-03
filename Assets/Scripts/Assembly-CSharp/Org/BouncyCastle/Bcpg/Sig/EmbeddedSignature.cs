namespace Org.BouncyCastle.Bcpg.Sig
{
	public class EmbeddedSignature : SignatureSubpacket
	{
		public EmbeddedSignature(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}
	}
}
