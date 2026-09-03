using System;

namespace Dxx.Util
{
	public class AttackCallData : WeightRandomDataBase
	{
		public float hitratio;

		public float dropRadius;

		public float outRadius;

		public float innerRadius;

		public float innerhitratio;

		public float outhitratio;

		public Action<BulletBase> onCreateBullet;

		public AttackCallData(int bulletid, int weight, float dropRadius, float outRadius, float innerRadius, float outhitratio, float innerhitratio)
			: base(0)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
