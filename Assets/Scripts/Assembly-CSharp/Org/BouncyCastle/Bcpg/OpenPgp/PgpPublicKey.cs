using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpPublicKey
	{
		private static readonly int[] MasterKeyCertificationTypes;

		private long keyId;

		private byte[] fingerprint;

		private int keyStrength;

		internal PublicKeyPacket publicPk;

		internal TrustPacket trustPk;

		internal IList keySigs;

		internal IList ids;

		internal IList idTrusts;

		internal IList idSigs;

		internal IList subSigs;

		public int Version => 0;

		public DateTime CreationTime => default;

		[Obsolete("Use 'GetValidSeconds' instead")]
		public int ValidDays => 0;

		public long KeyId => 0L;

		public bool IsEncryptionKey => false;

		public bool IsMasterKey => false;

		public PublicKeyAlgorithmTag Algorithm => (PublicKeyAlgorithmTag)0;

		public int BitStrength => 0;

		public PublicKeyPacket PublicKeyPacket => null;

		public static byte[] CalculateFingerprint(PublicKeyPacket publicPk)
		{
			return null;
		}

		private static void UpdateDigest(IDigest d, BigInteger b)
		{
		}

		private void Init()
		{
		}

		public PgpPublicKey(PublicKeyAlgorithmTag algorithm, AsymmetricKeyParameter pubKey, DateTime time)
		{
		}

		public PgpPublicKey(PublicKeyPacket publicPk)
		{
		}

		internal PgpPublicKey(PublicKeyPacket publicPk, TrustPacket trustPk, IList sigs)
		{
		}

		internal PgpPublicKey(PgpPublicKey key, TrustPacket trust, IList subSigs)
		{
		}

		internal PgpPublicKey(PgpPublicKey pubKey)
		{
		}

		internal PgpPublicKey(PublicKeyPacket publicPk, TrustPacket trustPk, IList keySigs, IList ids, IList idTrusts, IList idSigs)
		{
		}

		internal PgpPublicKey(PublicKeyPacket publicPk, IList ids, IList idSigs)
		{
		}

		public byte[] GetTrustData()
		{
			return null;
		}

		public long GetValidSeconds()
		{
			return 0L;
		}

		private long GetExpirationTimeFromSig(bool selfSigned, int signatureType)
		{
			return 0L;
		}

		public byte[] GetFingerprint()
		{
			return null;
		}

		public AsymmetricKeyParameter GetKey()
		{
			return null;
		}

		private ECPublicKeyParameters GetECKey(string algorithm)
		{
			return null;
		}

		public IEnumerable GetUserIds()
		{
			return null;
		}

		public IEnumerable GetUserAttributes()
		{
			return null;
		}

		public IEnumerable GetSignaturesForId(string id)
		{
			return null;
		}

		public IEnumerable GetSignaturesForUserAttribute(PgpUserAttributeSubpacketVector userAttributes)
		{
			return null;
		}

		public IEnumerable GetSignaturesOfType(int signatureType)
		{
			return null;
		}

		public IEnumerable GetSignatures()
		{
			return null;
		}

		public IEnumerable GetKeySignatures()
		{
			return null;
		}

		public byte[] GetEncoded()
		{
			return null;
		}

		public void Encode(Stream outStr)
		{
		}

		public bool IsRevoked()
		{
			return false;
		}

		public static PgpPublicKey AddCertification(PgpPublicKey key, string id, PgpSignature certification)
		{
			return null;
		}

		public static PgpPublicKey AddCertification(PgpPublicKey key, PgpUserAttributeSubpacketVector userAttributes, PgpSignature certification)
		{
			return null;
		}

		private static PgpPublicKey AddCert(PgpPublicKey key, object id, PgpSignature certification)
		{
			return null;
		}

		public static PgpPublicKey RemoveCertification(PgpPublicKey key, PgpUserAttributeSubpacketVector userAttributes)
		{
			return null;
		}

		public static PgpPublicKey RemoveCertification(PgpPublicKey key, string id)
		{
			return null;
		}

		private static PgpPublicKey RemoveCert(PgpPublicKey key, object id)
		{
			return null;
		}

		public static PgpPublicKey RemoveCertification(PgpPublicKey key, string id, PgpSignature certification)
		{
			return null;
		}

		public static PgpPublicKey RemoveCertification(PgpPublicKey key, PgpUserAttributeSubpacketVector userAttributes, PgpSignature certification)
		{
			return null;
		}

		private static PgpPublicKey RemoveCert(PgpPublicKey key, object id, PgpSignature certification)
		{
			return null;
		}

		public static PgpPublicKey AddCertification(PgpPublicKey key, PgpSignature certification)
		{
			return null;
		}

		public static PgpPublicKey RemoveCertification(PgpPublicKey key, PgpSignature certification)
		{
			return null;
		}
	}
}
