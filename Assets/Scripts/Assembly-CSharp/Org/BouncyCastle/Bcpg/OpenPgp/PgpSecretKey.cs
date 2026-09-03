using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public class PgpSecretKey
	{
		private readonly SecretKeyPacket secret;

		private readonly PgpPublicKey pub;

		public bool IsSigningKey => false;

		public bool IsMasterKey => false;

		public bool IsPrivateKeyEmpty => false;

		public SymmetricKeyAlgorithmTag KeyEncryptionAlgorithm => SymmetricKeyAlgorithmTag.Null;

		public long KeyId => 0L;

		public int S2kUsage => 0;

		public S2k S2k => null;

		public PgpPublicKey PublicKey => null;

		public IEnumerable UserIds => null;

		public IEnumerable UserAttributes => null;

		internal PgpSecretKey(SecretKeyPacket secret, PgpPublicKey pub)
		{
		}

		internal PgpSecretKey(PgpPrivateKey privKey, PgpPublicKey pubKey, SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, bool useSha1, SecureRandom rand, bool isMasterKey)
		{
		}

		[Obsolete("Use the constructor taking an explicit 'useSha1' parameter instead")]
		public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, bool utf8PassPhrase, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		internal PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, bool utf8PassPhrase, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		public PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		internal PgpSecretKey(int certificationLevel, PgpKeyPair keyPair, string id, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		private static PgpPublicKey CertifiedPublicKey(int certificationLevel, PgpKeyPair keyPair, string id, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets)
		{
			return null;
		}

		private static PgpPublicKey CertifiedPublicKey(int certificationLevel, PgpKeyPair keyPair, string id, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, HashAlgorithmTag hashAlgorithm)
		{
			return null;
		}

		public PgpSecretKey(int certificationLevel, PublicKeyAlgorithmTag algorithm, AsymmetricKeyParameter pubKey, AsymmetricKeyParameter privKey, DateTime time, string id, SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		public PgpSecretKey(int certificationLevel, PublicKeyAlgorithmTag algorithm, AsymmetricKeyParameter pubKey, AsymmetricKeyParameter privKey, DateTime time, string id, SymmetricKeyAlgorithmTag encAlgorithm, char[] passPhrase, bool useSha1, PgpSignatureSubpacketVector hashedPackets, PgpSignatureSubpacketVector unhashedPackets, SecureRandom rand)
		{
		}

		private byte[] ExtractKeyData(byte[] rawPassPhrase, bool clearPassPhrase)
		{
			return null;
		}

		private static byte[] RecoverKeyData(SymmetricKeyAlgorithmTag encAlgorithm, string modeAndPadding, KeyParameter key, byte[] iv, byte[] keyData, int keyOff, int keyLen)
		{
			return null;
		}

		public PgpPrivateKey ExtractPrivateKey(char[] passPhrase)
		{
			return null;
		}

		public PgpPrivateKey ExtractPrivateKeyUtf8(char[] passPhrase)
		{
			return null;
		}

		public PgpPrivateKey ExtractPrivateKeyRaw(byte[] rawPassPhrase)
		{
			return null;
		}

		internal PgpPrivateKey DoExtractPrivateKey(byte[] rawPassPhrase, bool clearPassPhrase)
		{
			return null;
		}

		private ECPrivateKeyParameters GetECKey(string algorithm, BcpgInputStream bcpgIn)
		{
			return null;
		}

		private static byte[] Checksum(bool useSha1, byte[] bytes, int length)
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

		public static PgpSecretKey CopyWithNewPassword(PgpSecretKey key, char[] oldPassPhrase, char[] newPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
		{
			return null;
		}

		public static PgpSecretKey CopyWithNewPasswordUtf8(PgpSecretKey key, char[] oldPassPhrase, char[] newPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
		{
			return null;
		}

		public static PgpSecretKey CopyWithNewPasswordRaw(PgpSecretKey key, byte[] rawOldPassPhrase, byte[] rawNewPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
		{
			return null;
		}

		internal static PgpSecretKey DoCopyWithNewPassword(PgpSecretKey key, byte[] rawOldPassPhrase, byte[] rawNewPassPhrase, bool clearPassPhrase, SymmetricKeyAlgorithmTag newEncAlgorithm, SecureRandom rand)
		{
			return null;
		}

		public static PgpSecretKey ReplacePublicKey(PgpSecretKey secretKey, PgpPublicKey publicKey)
		{
			return null;
		}

		private static byte[] EncryptKeyDataV3(byte[] rawKeyData, SymmetricKeyAlgorithmTag encAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, SecureRandom random, out S2k s2k, out byte[] iv)
		{
			s2k = null;
			iv = null;
			return null;
		}

		private static byte[] EncryptKeyDataV4(byte[] rawKeyData, SymmetricKeyAlgorithmTag encAlgorithm, HashAlgorithmTag hashAlgorithm, byte[] rawPassPhrase, bool clearPassPhrase, SecureRandom random, out S2k s2k, out byte[] iv)
		{
			s2k = null;
			iv = null;
			return null;
		}

		private static byte[] EncryptData(SymmetricKeyAlgorithmTag encAlgorithm, KeyParameter key, byte[] data, int dataOff, int dataLen, SecureRandom random, ref byte[] iv)
		{
			return null;
		}

		public static PgpSecretKey ParseSecretKeyFromSExpr(Stream inputStream, char[] passPhrase, PgpPublicKey pubKey)
		{
			return null;
		}

		public static PgpSecretKey ParseSecretKeyFromSExprUtf8(Stream inputStream, char[] passPhrase, PgpPublicKey pubKey)
		{
			return null;
		}

		public static PgpSecretKey ParseSecretKeyFromSExprRaw(Stream inputStream, byte[] rawPassPhrase, PgpPublicKey pubKey)
		{
			return null;
		}

		internal static PgpSecretKey DoParseSecretKeyFromSExpr(Stream inputStream, byte[] rawPassPhrase, bool clearPassPhrase, PgpPublicKey pubKey)
		{
			return null;
		}

		public static PgpSecretKey ParseSecretKeyFromSExpr(Stream inputStream, char[] passPhrase)
		{
			return null;
		}

		public static PgpSecretKey ParseSecretKeyFromSExprUtf8(Stream inputStream, char[] passPhrase)
		{
			return null;
		}

		public static PgpSecretKey ParseSecretKeyFromSExprRaw(Stream inputStream, byte[] rawPassPhrase)
		{
			return null;
		}

		internal static PgpSecretKey DoParseSecretKeyFromSExpr(Stream inputStream, byte[] rawPassPhrase, bool clearPassPhrase)
		{
			return null;
		}

		private static byte[] GetDValue(Stream inputStream, byte[] rawPassPhrase, bool clearPassPhrase, string curveName)
		{
			return null;
		}
	}
}
