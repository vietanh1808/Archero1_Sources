namespace TableTool
{
	public class Drop_DropActivitySEquipModel : LocalModel<Drop_DropActivitySEquip, int>
	{
		private const string _Filename = "Drop_DropActivitySEquip";

		protected override string Filename => null;

		protected override int GetBeanKey(Drop_DropActivitySEquip bean)
		{
			return 0;
		}
	}
}
