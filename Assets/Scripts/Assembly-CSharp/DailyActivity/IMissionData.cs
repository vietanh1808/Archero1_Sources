namespace DailyActivity
{
	public interface IMissionData
	{
		int MissionId { get; }

		string[] Attributes { get; }

		string[] MapAttributes { get; }

		long StandardDefence { get; }

		string[] RoomIds { get; }

		string[] RoomIds1 { get; }

		string[] WaveIDs { get; }

		string[] WaveIDs1 { get; }

		int[] Several { get; }

		int[] Nest { get; }

		int[] NestNum { get; }

		string[] GetRoomIds(int count);

		string[] GetRoomIds(int line, int count);
	}
}
