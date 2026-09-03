using System.IO;

namespace Org.BouncyCastle.Bcpg
{
	public class SignatureSubpacket
	{
		private readonly SignatureSubpacketTag type;

		private readonly bool critical;

		private readonly bool isLongLength;

		internal byte[] data;

		public SignatureSubpacketTag SubpacketType => (SignatureSubpacketTag)0;

		protected internal SignatureSubpacket(SignatureSubpacketTag type, bool critical, bool isLongLength, byte[] data)
		{
		}

		public bool IsCritical()
		{
			return false;
		}

		public bool IsLongLength()
		{
			return false;
		}

		public byte[] GetData()
		{
			return null;
		}

		public void Encode(Stream os)
		{
		}
	}
}
