using System.Collections;
using Org.BouncyCastle.Bcpg.Attr;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpUserAttributeSubpacketVectorGenerator
	{
		private IList list;

		public virtual void SetImageAttribute(ImageAttrib.Format imageType, byte[] imageData)
		{
		}

		public virtual PgpUserAttributeSubpacketVector Generate()
		{
			return null;
		}
	}
}
