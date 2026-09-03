using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkcs
{
	public class Pkcs12Store
	{
		internal class CertId
		{
			private readonly byte[] id;

			internal byte[] Id => null;

			internal CertId(AsymmetricKeyParameter pubKey)
			{
			}

			internal CertId(byte[] id)
			{
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public override bool Equals(object obj)
			{
				return false;
			}
		}

		private class IgnoresCaseHashtable : IEnumerable
		{
			private readonly IDictionary orig;

			private readonly IDictionary keys;

			public ICollection Keys => null;

			public object this[string alias]
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ICollection Values => null;

			public void Clear()
			{
			}

			public IEnumerator GetEnumerator()
			{
				return null;
			}

			public object Remove(string alias)
			{
				return null;
			}
		}

		private readonly IgnoresCaseHashtable keys;

		private readonly IDictionary localIds;

		private readonly IgnoresCaseHashtable certs;

		private readonly IDictionary chainCerts;

		private readonly IDictionary keyCerts;

		private readonly DerObjectIdentifier keyAlgorithm;

		private readonly DerObjectIdentifier certAlgorithm;

		private readonly bool useDerEncoding;

		private AsymmetricKeyEntry unmarkedKeyEntry;

		private const int MinIterations = 1024;

		private const int SaltSize = 20;

		public IEnumerable Aliases => null;

		public int Count => 0;

		private static SubjectKeyIdentifier CreateSubjectKeyID(AsymmetricKeyParameter pubKey)
		{
			return null;
		}

		internal Pkcs12Store(DerObjectIdentifier keyAlgorithm, DerObjectIdentifier certAlgorithm, bool useDerEncoding)
		{
		}

		public Pkcs12Store()
		{
		}

		public Pkcs12Store(Stream input, char[] password)
		{
		}

		protected virtual void LoadKeyBag(PrivateKeyInfo privKeyInfo, Asn1Set bagAttributes)
		{
		}

		protected virtual void LoadPkcs8ShroudedKeyBag(EncryptedPrivateKeyInfo encPrivKeyInfo, Asn1Set bagAttributes, char[] password, bool wrongPkcs12Zero)
		{
		}

		public void Load(Stream input, char[] password)
		{
		}

		public AsymmetricKeyEntry GetKey(string alias)
		{
			return null;
		}

		public bool IsCertificateEntry(string alias)
		{
			return false;
		}

		public bool IsKeyEntry(string alias)
		{
			return false;
		}

		private IDictionary GetAliasesTable()
		{
			return null;
		}

		public bool ContainsAlias(string alias)
		{
			return false;
		}

		public X509CertificateEntry GetCertificate(string alias)
		{
			return null;
		}

		public string GetCertificateAlias(X509Certificate cert)
		{
			return null;
		}

		public X509CertificateEntry[] GetCertificateChain(string alias)
		{
			return null;
		}

		public void SetCertificateEntry(string alias, X509CertificateEntry certEntry)
		{
		}

		public void SetKeyEntry(string alias, AsymmetricKeyEntry keyEntry, X509CertificateEntry[] chain)
		{
		}

		public void DeleteEntry(string alias)
		{
		}

		public bool IsEntryOfType(string alias, Type entryType)
		{
			return false;
		}

		[Obsolete("Use 'Count' property instead")]
		public int Size()
		{
			return 0;
		}

		public void Save(Stream stream, char[] password, SecureRandom random)
		{
		}

		internal static byte[] CalculatePbeMac(DerObjectIdentifier oid, byte[] salt, int itCount, char[] password, bool wrongPkcs12Zero, byte[] data)
		{
			return null;
		}

		private static byte[] CryptPbeData(bool forEncryption, AlgorithmIdentifier algId, char[] password, bool wrongPkcs12Zero, byte[] data)
		{
			return null;
		}
	}
}
