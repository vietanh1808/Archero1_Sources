using System;
using System.Collections;
using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Pkcs
{
	public abstract class Pkcs12Entry
	{
		private readonly IDictionary attributes;

		public Asn1Encodable this[DerObjectIdentifier oid] => null;

		public Asn1Encodable this[string oid] => null;

		public IEnumerable BagAttributeKeys => null;

		protected internal Pkcs12Entry(IDictionary attributes)
		{
		}

		[Obsolete("Use 'object[index]' syntax instead")]
		public Asn1Encodable GetBagAttribute(DerObjectIdentifier oid)
		{
			return null;
		}

		[Obsolete("Use 'object[index]' syntax instead")]
		public Asn1Encodable GetBagAttribute(string oid)
		{
			return null;
		}

		[Obsolete("Use 'BagAttributeKeys' property")]
		public IEnumerator GetBagAttributeKeys()
		{
			return null;
		}
	}
}
