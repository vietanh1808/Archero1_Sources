using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	internal class TlsServerContextImpl : AbstractTlsContext, TlsServerContext, TlsContext
	{
		public override bool IsServer => false;

		internal TlsServerContextImpl(SecureRandom secureRandom, SecurityParameters securityParameters)
			: base(null, null)
		{
		}
	}
}
