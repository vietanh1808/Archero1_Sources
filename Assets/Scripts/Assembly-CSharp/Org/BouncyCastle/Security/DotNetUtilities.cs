using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Security
{
	public sealed class DotNetUtilities
	{
		private DotNetUtilities()
		{
		}

		public static System.Security.Cryptography.X509Certificates.X509Certificate ToX509Certificate(X509CertificateStructure x509Struct)
		{
			return null;
		}

		public static System.Security.Cryptography.X509Certificates.X509Certificate ToX509Certificate(Org.BouncyCastle.X509.X509Certificate x509Cert)
		{
			return null;
		}

		public static Org.BouncyCastle.X509.X509Certificate FromX509Certificate(System.Security.Cryptography.X509Certificates.X509Certificate x509Cert)
		{
			return null;
		}

		public static AsymmetricCipherKeyPair GetDsaKeyPair(DSA dsa)
		{
			return null;
		}

		public static AsymmetricCipherKeyPair GetDsaKeyPair(DSAParameters dp)
		{
			return null;
		}

		public static DsaPublicKeyParameters GetDsaPublicKey(DSA dsa)
		{
			return null;
		}

		public static DsaPublicKeyParameters GetDsaPublicKey(DSAParameters dp)
		{
			return null;
		}

		public static AsymmetricCipherKeyPair GetRsaKeyPair(RSA rsa)
		{
			return null;
		}

		public static AsymmetricCipherKeyPair GetRsaKeyPair(RSAParameters rp)
		{
			return null;
		}

		public static RsaKeyParameters GetRsaPublicKey(RSA rsa)
		{
			return null;
		}

		public static RsaKeyParameters GetRsaPublicKey(RSAParameters rp)
		{
			return null;
		}

		public static AsymmetricCipherKeyPair GetKeyPair(AsymmetricAlgorithm privateKey)
		{
			return null;
		}

		public static RSA ToRSA(RsaKeyParameters rsaKey)
		{
			return null;
		}

		public static RSA ToRSA(RsaKeyParameters rsaKey, CspParameters csp)
		{
			return null;
		}

		public static RSA ToRSA(RsaPrivateCrtKeyParameters privKey)
		{
			return null;
		}

		public static RSA ToRSA(RsaPrivateCrtKeyParameters privKey, CspParameters csp)
		{
			return null;
		}

		public static RSA ToRSA(RsaPrivateKeyStructure privKey)
		{
			return null;
		}

		public static RSA ToRSA(RsaPrivateKeyStructure privKey, CspParameters csp)
		{
			return null;
		}

		public static RSAParameters ToRSAParameters(RsaKeyParameters rsaKey)
		{
			return default;
		}

		public static RSAParameters ToRSAParameters(RsaPrivateCrtKeyParameters privKey)
		{
			return default;
		}

		public static RSAParameters ToRSAParameters(RsaPrivateKeyStructure privKey)
		{
			return default;
		}

		private static byte[] ConvertRSAParametersField(BigInteger n, int size)
		{
			return null;
		}

		private static RSA CreateRSAProvider(RSAParameters rp)
		{
			return null;
		}

		private static RSA CreateRSAProvider(RSAParameters rp, CspParameters csp)
		{
			return null;
		}
	}
}
