namespace Org.BouncyCastle.Bcpg.Sig
{
	public class PreferredAlgorithms : SignatureSubpacket
	{
		private static byte[] IntToByteArray(int[] v)
		{
			return null;
		}

		public PreferredAlgorithms(SignatureSubpacketTag type, bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public PreferredAlgorithms(SignatureSubpacketTag type, bool critical, int[] preferences)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public int[] GetPreferences()
		{
			return null;
		}
	}
}
