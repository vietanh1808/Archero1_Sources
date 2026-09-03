using TableTool;

namespace DailyActivity
{
	public sealed class DailyMissionData : IMissionData
	{
		public int MissionId { get; private set; }

		public string[] Attributes { get; private set; }

		public string[] MapAttributes { get; private set; }

		public long StandardDefence { get; private set; }

		public string[] RoomIds { get; private set; }

		public string[] RoomIds1 { get; private set; }

		public string[] Room1 { get; private set; }

		public string[] Room2 { get; private set; }

		public string[] Room3 { get; private set; }

		public string[] Room4 { get; private set; }

		public string[] Room5 { get; private set; }

		public string[] Room6 { get; private set; }

		public string[] Room7 { get; private set; }

		public string[] Room8 { get; private set; }

		public string[] WaveIDs { get; private set; }

		public string[] WaveIDs1 { get; private set; }

		public int[] Several { get; private set; }

		public int[] Nest { get; private set; }

		public int[] NestNum { get; private set; }

		public string[] GetRoomIds(int count)
		{
			return null;
		}

		public string[] GetRoomIds(int line, int count)
		{
			return null;
		}

		public DailyMissionData(Daily_DailyMission bean)
		{
		}

		public DailyMissionData(ShipStage_BagMission bean)
		{
		}

		public DailyMissionData(int missionId, string[] atts, string[] mapAtts, long defence, string[] roomids, string[] roomids1, string[] waveIDs, string[] waveIDs1, int[] several, int[] nest, int[] nestNum)
		{
		}
	}
}
