namespace TableTool
{
	public class PVEseason_giftModel : LocalModel<PVEseason_gift, int>
	{
		private const string _Filename = "PVEseason_gift";

		protected override string Filename => null;

		protected override int GetBeanKey(PVEseason_gift bean)
		{
			return 0;
		}
	}
}
