public class BinaryBase : IBinary
{
	public byte[] Build()
	{
		return null;
	}

	public void ReadFromStream(byte[] bytes)
	{
	}

	protected virtual void OnReadFromStream(CustomBinaryReader reader)
	{
	}

	public void WriteToStream(CustomBinaryWriter writer)
	{
	}

	protected virtual void OnWriteToStream(CustomBinaryWriter writer)
	{
	}
}
