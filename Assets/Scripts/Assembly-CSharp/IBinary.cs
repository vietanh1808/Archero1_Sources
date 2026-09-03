public interface IBinary
{
	void ReadFromStream(byte[] bytes);

	void WriteToStream(CustomBinaryWriter writer);

	byte[] Build();
}
