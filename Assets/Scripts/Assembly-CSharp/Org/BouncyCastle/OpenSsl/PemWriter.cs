using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO.Pem;

namespace Org.BouncyCastle.OpenSsl
{
	public class PemWriter : Org.BouncyCastle.Utilities.IO.Pem.PemWriter
	{
		public PemWriter(TextWriter writer)
			: base(null)
		{
		}

		public void WriteObject(object obj)
		{
		}

		public void WriteObject(object obj, string algorithm, char[] password, SecureRandom random)
		{
		}
	}
}
