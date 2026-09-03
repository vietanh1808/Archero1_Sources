using System.IO;
using Org.BouncyCastle.Asn1.Cms;

namespace Org.BouncyCastle.Cms
{
	public class CmsContentInfoParser
	{
		protected ContentInfoParser contentInfo;

		protected Stream data;

		protected CmsContentInfoParser(Stream data)
		{
		}

		public void Close()
		{
		}
	}
}
