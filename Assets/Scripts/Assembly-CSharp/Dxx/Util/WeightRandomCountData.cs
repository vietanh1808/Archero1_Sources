namespace Dxx.Util
{
	public class WeightRandomCountData : WeightRandomDataBase
	{
		public int randomcount;

		public int lastrandomindex;

		public WeightRandomCountData(int id)
			: base(0)
		{
		}

		public void RandomSelf(int randomindex)
		{
		}

		public bool GetCanRandom(int randomindex, int maxcount)
		{
			return false;
		}
	}
}
