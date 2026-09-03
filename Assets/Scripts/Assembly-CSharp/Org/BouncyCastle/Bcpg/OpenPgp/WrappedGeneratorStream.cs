using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class WrappedGeneratorStream : FilterStream
	{
		private readonly IStreamGenerator gen;

		public WrappedGeneratorStream(IStreamGenerator gen, Stream str)
			: base(null)
		{
		}

		public override void Close()
		{
		}
	}
}
