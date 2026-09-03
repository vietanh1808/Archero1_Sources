namespace TableTool
{
	public class Manor_MaterialModel : LocalModel<Manor_Material, int>
	{
		private const string _Filename = "Manor_Material";

		protected override string Filename => null;

		protected override int GetBeanKey(Manor_Material bean)
		{
			return 0;
		}
	}
}
