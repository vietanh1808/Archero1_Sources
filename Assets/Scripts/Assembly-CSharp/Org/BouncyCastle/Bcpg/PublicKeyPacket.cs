using System;

namespace Org.BouncyCastle.Bcpg
{
	public class PublicKeyPacket : ContainedPacket
	{
		private int version;

		private long time;

		private int validDays;

		private PublicKeyAlgorithmTag algorithm;

		private IBcpgKey key;

		public virtual int Version => 0;

		public virtual PublicKeyAlgorithmTag Algorithm => (PublicKeyAlgorithmTag)0;

		public virtual int ValidDays => 0;

		public virtual IBcpgKey Key => null;

		internal PublicKeyPacket(BcpgInputStream bcpgIn)
		{
		}

		public PublicKeyPacket(PublicKeyAlgorithmTag algorithm, DateTime time, IBcpgKey key)
		{
		}

		public virtual DateTime GetTime()
		{
			return default;
		}

		public virtual byte[] GetEncodedContents()
		{
			return null;
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}
