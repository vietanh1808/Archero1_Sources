namespace Org.BouncyCastle.Bcpg
{
	public class RevocationReason : SignatureSubpacket
	{
		public RevocationReason(bool isCritical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public RevocationReason(bool isCritical, RevocationReasonTag reason, string description)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		private static byte[] CreateData(RevocationReasonTag reason, string description)
		{
			return null;
		}

		public virtual RevocationReasonTag GetRevocationReason()
		{
			return RevocationReasonTag.NoReason;
		}

		public virtual string GetRevocationDescription()
		{
			return null;
		}
	}
}
