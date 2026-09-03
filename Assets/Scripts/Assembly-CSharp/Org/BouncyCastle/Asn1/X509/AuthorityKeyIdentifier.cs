using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X509
{
	public class AuthorityKeyIdentifier : Asn1Encodable
	{
		internal readonly Asn1OctetString keyidentifier;

		internal readonly GeneralNames certissuer;

		internal readonly DerInteger certserno;

		public GeneralNames AuthorityCertIssuer => null;

		public BigInteger AuthorityCertSerialNumber => null;

		public static AuthorityKeyIdentifier GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		public static AuthorityKeyIdentifier GetInstance(object obj)
		{
			return null;
		}

		protected internal AuthorityKeyIdentifier(Asn1Sequence seq)
		{
		}

		public AuthorityKeyIdentifier(SubjectPublicKeyInfo spki)
		{
		}

		public AuthorityKeyIdentifier(SubjectPublicKeyInfo spki, GeneralNames name, BigInteger serialNumber)
		{
		}

		public AuthorityKeyIdentifier(GeneralNames name, BigInteger serialNumber)
		{
		}

		public AuthorityKeyIdentifier(byte[] keyIdentifier)
		{
		}

		public AuthorityKeyIdentifier(byte[] keyIdentifier, GeneralNames name, BigInteger serialNumber)
		{
		}

		public byte[] GetKeyIdentifier()
		{
			return null;
		}

		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
