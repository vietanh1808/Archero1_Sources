using System.IO;
using System.Text;

public sealed class BinaryBuffer
{
	public static readonly MemoryStream CacheStream;

	public static readonly BinaryWriter MemoryWriter;

	public const uint Zero = 0u;

	public static readonly UTF8Encoding Encoding;

	public static BinaryWriter Writer => null;
}
