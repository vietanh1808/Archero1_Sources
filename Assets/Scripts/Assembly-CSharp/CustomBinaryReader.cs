using System.IO;

public class CustomBinaryReader : BinaryReader
{
	public CustomBinaryReader(Stream stream)
		: base(null)
	{
	}

	public override string ReadString()
	{
		return null;
	}
}
