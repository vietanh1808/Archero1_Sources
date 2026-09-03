using System;

namespace Dxx.Util
{
	public class DeadCallData : WeightRandomDataBase
	{
		public Action<EntityBase> OnDead;

		public DeadCallData(int id, Action<EntityBase> OnDead, int weight)
			: base(0)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
