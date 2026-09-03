using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	public class PskTlsServer : AbstractTlsServer
	{
		protected TlsPskIdentityManager mPskIdentityManager;

		public PskTlsServer(TlsPskIdentityManager pskIdentityManager)
		{
		}

		public PskTlsServer(TlsCipherFactory cipherFactory, TlsPskIdentityManager pskIdentityManager)
		{
		}

		protected virtual TlsEncryptionCredentials GetRsaEncryptionCredentials()
		{
			return null;
		}

		protected virtual DHParameters GetDHParameters()
		{
			return null;
		}

		protected override int[] GetCipherSuites()
		{
			return null;
		}

		public override TlsCredentials GetCredentials()
		{
			return null;
		}

		public override TlsKeyExchange GetKeyExchange()
		{
			return null;
		}

		protected virtual TlsKeyExchange CreatePskKeyExchange(int keyExchange)
		{
			return null;
		}
	}
}
