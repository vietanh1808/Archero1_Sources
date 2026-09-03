using System;

namespace Org.BouncyCastle.Bcpg
{
	public class PublicSubkeyPacket : PublicKeyPacket
	{
		internal PublicSubkeyPacket(BcpgInputStream bcpgIn)
			: base(null)
		{
		}

		public PublicSubkeyPacket(PublicKeyAlgorithmTag algorithm, DateTime time, IBcpgKey key)
			: base(null)
		{
		}

		public override void Encode(BcpgOutputStream bcpgOut)
		{
		}
	}
}
