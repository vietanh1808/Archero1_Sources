using System.IO;

public class RC4Stream : FileStream
{
	public RC4Stream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
		: base(null, (FileMode)0)
	{
	}

	public RC4Stream(string path, FileMode mode)
		: base(null, (FileMode)0)
	{
	}

	public override int Read(byte[] array, int offset, int count)
	{
		return 0;
	}

	public override void Write(byte[] array, int offset, int count)
	{
	}
}
