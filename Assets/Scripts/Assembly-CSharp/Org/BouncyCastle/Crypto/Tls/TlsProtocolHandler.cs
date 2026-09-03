using System;
using System.IO;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	[Obsolete("Use 'TlsClientProtocol' instead")]
	public class TlsProtocolHandler : TlsClientProtocol
	{
		public TlsProtocolHandler(Stream stream, SecureRandom secureRandom)
			: base(null, null)
		{
		}

		public TlsProtocolHandler(Stream input, Stream output, SecureRandom secureRandom)
			: base(null, null)
		{
		}
	}
}
