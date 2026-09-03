using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	public class CmsSignedDataGenerator : CmsSignedGenerator
	{
		private class SignerInf
		{
			private readonly CmsSignedGenerator outer;

			private readonly ISignatureFactory sigCalc;

			private readonly SignerIdentifier signerIdentifier;

			private readonly string digestOID;

			private readonly string encOID;

			private readonly CmsAttributeTableGenerator sAttr;

			private readonly CmsAttributeTableGenerator unsAttr;

			private readonly Org.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable;

			internal AlgorithmIdentifier DigestAlgorithmID => null;

			internal CmsAttributeTableGenerator SignedAttributes => null;

			internal CmsAttributeTableGenerator UnsignedAttributes => null;

			internal SignerInf(CmsSignedGenerator outer, AsymmetricKeyParameter key, SignerIdentifier signerIdentifier, string digestOID, string encOID, CmsAttributeTableGenerator sAttr, CmsAttributeTableGenerator unsAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable)
			{
			}

			internal SignerInf(CmsSignedGenerator outer, ISignatureFactory sigCalc, SignerIdentifier signerIdentifier, CmsAttributeTableGenerator sAttr, CmsAttributeTableGenerator unsAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable)
			{
			}

			internal SignerInfo ToSignerInfo(DerObjectIdentifier contentType, CmsProcessable content, SecureRandom random)
			{
				return null;
			}
		}

		private static readonly CmsSignedHelper Helper;

		private readonly IList signerInfs;

		public CmsSignedDataGenerator()
		{
		}

		public CmsSignedDataGenerator(SecureRandom rand)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOID)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOID, string digestOID)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOID)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOID, string digestOID)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOID, Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOID, string digestOID, Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOID, Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOID, string digestOID, Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string digestOID, CmsAttributeTableGenerator signedAttrGen, CmsAttributeTableGenerator unsignedAttrGen)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, X509Certificate cert, string encryptionOID, string digestOID, CmsAttributeTableGenerator signedAttrGen, CmsAttributeTableGenerator unsignedAttrGen)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOID, CmsAttributeTableGenerator signedAttrGen, CmsAttributeTableGenerator unsignedAttrGen)
		{
		}

		public void AddSigner(AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOID, string digestOID, CmsAttributeTableGenerator signedAttrGen, CmsAttributeTableGenerator unsignedAttrGen)
		{
		}

		public void AddSignerInfoGenerator(SignerInfoGenerator signerInfoGenerator)
		{
		}

		private void doAddSigner(AsymmetricKeyParameter privateKey, SignerIdentifier signerIdentifier, string encryptionOID, string digestOID, CmsAttributeTableGenerator signedAttrGen, CmsAttributeTableGenerator unsignedAttrGen, Org.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable)
		{
		}

		public CmsSignedData Generate(CmsProcessable content)
		{
			return null;
		}

		public CmsSignedData Generate(string signedContentType, CmsProcessable content, bool encapsulate)
		{
			return null;
		}

		public CmsSignedData Generate(CmsProcessable content, bool encapsulate)
		{
			return null;
		}

		public SignerInformationStore GenerateCounterSigners(SignerInformation signer)
		{
			return null;
		}
	}
}
