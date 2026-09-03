using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	public sealed class PgpUtilities
	{
		private const int ReadAhead = 60;

		private PgpUtilities()
		{
		}

		public static MPInteger[] DsaSigToMpi(byte[] encoding)
		{
			return null;
		}

		public static MPInteger[] RsaSigToMpi(byte[] encoding)
		{
			return null;
		}

		public static string GetDigestName(HashAlgorithmTag hashAlgorithm)
		{
			return null;
		}

		public static string GetSignatureName(PublicKeyAlgorithmTag keyAlgorithm, HashAlgorithmTag hashAlgorithm)
		{
			return null;
		}

		public static string GetSymmetricCipherName(SymmetricKeyAlgorithmTag algorithm)
		{
			return null;
		}

		public static int GetKeySize(SymmetricKeyAlgorithmTag algorithm)
		{
			return 0;
		}

		public static KeyParameter MakeKey(SymmetricKeyAlgorithmTag algorithm, byte[] keyBytes)
		{
			return null;
		}

		public static KeyParameter MakeRandomKey(SymmetricKeyAlgorithmTag algorithm, SecureRandom random)
		{
			return null;
		}

		internal static byte[] EncodePassPhrase(char[] passPhrase, bool utf8)
		{
			return null;
		}

		public static KeyParameter MakeKeyFromPassPhrase(SymmetricKeyAlgorithmTag algorithm, S2k s2k, char[] passPhrase)
		{
			return null;
		}

		public static KeyParameter MakeKeyFromPassPhraseUtf8(SymmetricKeyAlgorithmTag algorithm, S2k s2k, char[] passPhrase)
		{
			return null;
		}

		public static KeyParameter MakeKeyFromPassPhraseRaw(SymmetricKeyAlgorithmTag algorithm, S2k s2k, byte[] rawPassPhrase)
		{
			return null;
		}

		internal static KeyParameter DoMakeKeyFromPassPhrase(SymmetricKeyAlgorithmTag algorithm, S2k s2k, byte[] rawPassPhrase, bool clearPassPhrase)
		{
			return null;
		}

		public static void WriteFileToLiteralData(Stream output, char fileType, FileInfo file)
		{
		}

		public static void WriteFileToLiteralData(Stream output, char fileType, FileInfo file, byte[] buffer)
		{
		}

		private static void PipeFileContents(FileInfo file, Stream pOut, int bufSize)
		{
		}

		private static bool IsPossiblyBase64(int ch)
		{
			return false;
		}

		public static Stream GetDecoderStream(Stream inputStream)
		{
			return null;
		}

		internal static IWrapper CreateWrapper(SymmetricKeyAlgorithmTag encAlgorithm)
		{
			return null;
		}

		internal static byte[] GenerateIV(int length, SecureRandom random)
		{
			return null;
		}

		internal static S2k GenerateS2k(HashAlgorithmTag hashAlgorithm, int s2kCount, SecureRandom random)
		{
			return null;
		}
	}
}
