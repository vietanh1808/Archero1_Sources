namespace TableTool
{
	public class Goods_goodsModel : LocalModel<Goods_goods, int>
	{
		private const string _Filename = "Goods_goods";

		protected override string Filename => null;

		protected override int GetBeanKey(Goods_goods bean)
		{
			return 0;
		}
	}
}
