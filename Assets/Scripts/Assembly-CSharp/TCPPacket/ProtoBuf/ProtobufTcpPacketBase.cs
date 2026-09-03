using Google.Protobuf;

namespace TCPPacket.ProtoBuf
{
	public abstract class ProtobufTcpPacketBase<T> : TcpPacketBase where T : IMessage<T>, new()
	{
		public T data;

		public override byte[] ToByteArray()
		{
			return null;
		}

		public override void Serialize(byte[] array)
		{
		}
	}
}
