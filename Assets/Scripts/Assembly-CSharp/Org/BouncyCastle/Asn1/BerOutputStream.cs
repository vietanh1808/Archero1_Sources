using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	public class BerOutputStream : DerOutputStream
	{
		public BerOutputStream(Stream os)
			: base(null)
		{
		}

		[Obsolete("Use version taking an Asn1Encodable arg instead")]
		public override void WriteObject(object obj)
		{
		}
	}
}
