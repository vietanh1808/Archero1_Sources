using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1.X509
{
	public class AttributeTable
	{
		private readonly IDictionary attributes;

		public AttributeTable(IDictionary attrs)
		{
		}

		[Obsolete]
		public AttributeTable(Hashtable attrs)
		{
		}

		public AttributeTable(Asn1EncodableVector v)
		{
		}

		public AttributeTable(Asn1Set s)
		{
		}

		public AttributeX509 Get(DerObjectIdentifier oid)
		{
			return null;
		}

		[Obsolete("Use 'ToDictionary' instead")]
		public Hashtable ToHashtable()
		{
			return null;
		}

		public IDictionary ToDictionary()
		{
			return null;
		}
	}
}
