using System.Collections.Generic;

namespace DamageTool
{
	public class DamageReCount
	{
		public class KillCountMap
		{
			private Dictionary<ulong, KillObject> map;

			public KillObject GetByKey(ulong pKey)
			{
				return null;
			}

			public KillObject AddNew(ulong pKey, int pGuid)
			{
				return null;
			}

			public void Clear()
			{
			}
		}

		public class DamageObjectMap
		{
			private Dictionary<ulong, DamageObject> map;

			public DamageObject GetByKey(ulong pKey)
			{
				return null;
			}

			public DamageObject AddNew(ulong pKey, int pGuid)
			{
				return null;
			}

			public void Clear()
			{
			}
		}

		public class DamageObjectBase
		{
			public int Guid;

			public ulong entityIndex;

			public DamageObjectBase(ulong index)
			{
			}
		}

		public class KillObject : DamageObjectBase
		{
			public int killCount { get; private set; }

			public int killScore { get; private set; }

			public KillObject(ulong index)
				: base(0uL)
			{
			}

			public void AddOne(EntityBase entity, int score)
			{
			}
		}

		public class DamageObject : DamageObjectBase
		{
			public ulong dmgNumber { get; protected set; }

			public ulong hpNumber { get; protected set; }

			public ulong overHP { get; protected set; }

			public DamageObject(ulong index)
				: base(0uL)
			{
			}

			public void AddDamage(EntityBase target, long gotdmg)
			{
			}
		}

		private static DamageReCount sins;

		private DamageObjectMap dmgObjectMap;

		private DamageObjectMap hurtMap;

		private KillCountMap killMap;

		public static DamageReCount Ins => null;

		public static bool IsNotPartAndBaby(EntityBase entity)
		{
			return false;
		}

		public static EntityBase GetRealEntity(EntityBase entity)
		{
			return null;
		}

		private void OnDamage(EntityBase damager, long gotdmg)
		{
		}

		private void OnHurt(EntityBase hurter, long gotdmg)
		{
		}

		private void OnKill(EntityBase form, EntityBase target, int score)
		{
		}

		public void AddDamage(EntityBase form, EntityBase to, long gotdmg)
		{
		}

		public void AddDamage(ulong formIndex, ulong targetIndex, long gotdmg)
		{
		}

		public void AddKill(EntityBase form, EntityBase target, int score)
		{
		}

		public DamageObject GetDamage(EntityBase whomake)
		{
			return null;
		}

		public DamageObject GetHurt(EntityBase whomake)
		{
			return null;
		}

		public KillObject GetKill(EntityBase whomake)
		{
			return null;
		}

		public void Rest()
		{
		}

		private void Update()
		{
		}
	}
}
