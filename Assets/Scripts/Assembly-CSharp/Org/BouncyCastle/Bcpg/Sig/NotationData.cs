namespace Org.BouncyCastle.Bcpg.Sig
{
	public class NotationData : SignatureSubpacket
	{
		public const int HeaderFlagLength = 4;

		public const int HeaderNameLength = 2;

		public const int HeaderValueLength = 2;

		public bool IsHumanReadable => false;

		public NotationData(bool critical, bool isLongLength, byte[] data)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		public NotationData(bool critical, bool humanReadable, string notationName, string notationValue)
			: base((SignatureSubpacketTag)0, critical: false, isLongLength: false, null)
		{
		}

		private static byte[] CreateData(bool humanReadable, string notationName, string notationValue)
		{
			return null;
		}

		public string GetNotationName()
		{
			return null;
		}

		public string GetNotationValue()
		{
			return null;
		}

		public byte[] GetNotationValueBytes()
		{
			return null;
		}
	}
}
