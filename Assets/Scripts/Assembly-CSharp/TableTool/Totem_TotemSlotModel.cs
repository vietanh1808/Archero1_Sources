namespace TableTool
{
	public class Totem_TotemSlotModel : LocalModel<Totem_TotemSlot, int>
	{
		private const string _Filename = "Totem_TotemSlot";

		protected override string Filename => null;

		protected override int GetBeanKey(Totem_TotemSlot bean)
		{
			return 0;
		}
	}
}
