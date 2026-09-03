namespace TableTool
{
	public class Totem_TotemModel : LocalModel<Totem_Totem, int>
	{
		private const string _Filename = "Totem_Totem";

		protected override string Filename => null;

		protected override int GetBeanKey(Totem_Totem bean)
		{
			return 0;
		}
	}
}
