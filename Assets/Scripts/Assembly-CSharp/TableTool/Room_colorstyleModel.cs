namespace TableTool
{
	public class Room_colorstyleModel : LocalModel<Room_colorstyle, int>
	{
		private const string _Filename = "Room_colorstyle";

		protected override string Filename => null;

		protected override int GetBeanKey(Room_colorstyle bean)
		{
			return 0;
		}
	}
}
