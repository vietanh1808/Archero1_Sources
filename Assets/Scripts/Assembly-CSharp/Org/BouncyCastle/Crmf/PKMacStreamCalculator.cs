using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;

namespace Org.BouncyCastle.Crmf
{
	internal class PKMacStreamCalculator : IStreamCalculator
	{
		private readonly MacSink _stream;

		public Stream Stream => null;

		public PKMacStreamCalculator(IMac mac)
		{
		}

		public object GetResult()
		{
			return null;
		}
	}
}
