namespace TableTool
{
	public class Room_soldierupModel : LocalModel<Room_soldierup, int>
	{
		private const string _Filename = "Room_soldierup";

		protected override string Filename => null;

		protected override int GetBeanKey(Room_soldierup bean)
		{
			return 0;
		}
	}
}
