namespace Org.BouncyCastle.Bcpg.Sig
{
	public class Features : SignatureSubpacket
	{
		public static readonly byte FEATURE_MODIFICATION_DETECTION;

		public bool SupportsModificationDetection => false;

		private static byte[] FeatureToByteArray(byte feature)
		{
			return null;
		}

		public Features(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public Features(bool critical, byte feature)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public bool SupportsFeature(byte feature)
		{
			return false;
		}

		private void SetSupportsFeature(byte feature, bool support)
		{
		}
	}
}
