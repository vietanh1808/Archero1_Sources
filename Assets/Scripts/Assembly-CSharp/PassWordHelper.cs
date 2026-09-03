using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

public static class PassWordHelper
{
	private const string PublicRsaKey = "pubKey";

	private const string PrivateRsaKey = "priKey";

	public static string Md532(this string source)
	{
		return null;
	}

	public static string Md532Salt(this string source, string salt)
	{
		return null;
	}

	public static string Sha1(this string source)
	{
		return null;
	}

	public static string Sha256(this string source)
	{
		return null;
	}

	public static string Sha512(this string source)
	{
		return null;
	}

	public static string HmacSha1(this string source, string keyVal)
	{
		return null;
	}

	public static string HmacSha256(this string source, string keyVal)
	{
		return null;
	}

	public static string HmacSha384(this string source, string keyVal)
	{
		return null;
	}

	public static string HmacSha512(this string source, string keyVal)
	{
		return null;
	}

	public static bool IsEmpty(this string value)
	{
		return false;
	}

	public static string HmacMd5(this string source, string keyVal)
	{
		return null;
	}

	public static string HmacRipeMd160(this string source, string keyVal)
	{
		return null;
	}

	public static string AesStr(this string source, string keyVal, string ivVal)
	{
		return null;
	}

	public static byte[] AesBytes(this byte[] byteArray, string keyVal, string ivVal)
	{
		return null;
	}

	public static string UnAesStr(this string source, string keyVal, string ivVal)
	{
		return null;
	}

	public static byte[] UnAesStr(this byte[] byteArray, string keyVal, string ivVal)
	{
		return null;
	}

	public static byte[] AesByte(this byte[] data, string keyVal, string ivVal)
	{
		return null;
	}

	public static byte[] UnAesByte(this byte[] data, string keyVal, string ivVal)
	{
		return null;
	}

	public static string Rsa(this string source)
	{
		return null;
	}

	public static string UnRsa(this string source)
	{
		return null;
	}

	public static string Des(this string source, string keyVal, string ivVal)
	{
		return null;
	}

	public static string UnDes(this string source, string keyVal, string ivVal)
	{
		return null;
	}

	public static string Des3(this string source, string keyVal)
	{
		return null;
	}

	public static string UnDes3(this string source, string keyVal)
	{
		return null;
	}

	public static string Base64(this string source)
	{
		return null;
	}

	public static string UnBase64(this string source)
	{
		return null;
	}

	private static byte[] Str2Bytes(this string source)
	{
		return null;
	}

	private static string Bytes2Str(this IEnumerable<byte> source, string formatStr = "{0:X2}")
	{
		return null;
	}

	private static byte[] FormatByte(this string strVal, Encoding encoding)
	{
		return null;
	}

	private static string HashAlgorithmBase(HashAlgorithm hashAlgorithmObj, string source, Encoding encoding)
	{
		return null;
	}
}
