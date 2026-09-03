namespace TableTool
{
	public class Farm_SlotModel : LocalModel<Farm_Slot, int>
	{
		private const string _Filename = "Farm_Slot";

		protected override string Filename => null;

		protected override int GetBeanKey(Farm_Slot bean)
		{
			return 0;
		}
	}
}
