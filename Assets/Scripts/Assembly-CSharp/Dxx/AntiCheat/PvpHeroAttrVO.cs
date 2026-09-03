using CodeStage.AntiCheat.ObscuredTypes;

namespace Dxx.AntiCheat
{
	public class PvpHeroAttrVO
	{
		private ObscuredLong attack;

		private ObscuredLong hp;

		private ObscuredFloat attackSpeed;

		private ObscuredLong moveSpeed;

		private ObscuredFloat critRate;

		private ObscuredFloat critValue;

		private ObscuredFloat hitReduce;

		private ObscuredFloat bulletHitReduce;

		public ObscuredLong Attack
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		private bool isValidAttack => false;

		private bool isCertainInvalidAttack => false;

		public ObscuredLong Hp
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		private bool isValidHp => false;

		private bool isCertainInvalidHp => false;

		public ObscuredFloat AttackSpeed
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		private bool isValidAttackSpeed => false;

		private bool isCertainInvalidAttackSpeed => false;

		public ObscuredLong MoveSpeed
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		private bool isValidMoveSpeed => false;

		private bool isCertainInvalidMoveSpeed => false;

		public ObscuredFloat CritRate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		private bool isValidCritRate => false;

		private bool isCertainInvalidCritRate => false;

		public ObscuredFloat CritValue
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		private bool isValidCritValue => false;

		private bool isCertainInvalidCritValue => false;

		public ObscuredFloat HitReduce
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		private bool isValidHitReduce => false;

		private bool isCertainInvalidHitReduce => false;

		public ObscuredFloat BulletHitReduce
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		private bool isValidBulletHitReduce => false;

		private bool isCertainInvalidBulletHitReduce => false;

		public bool IsValid => false;

		public bool IsCertainInvalid => false;

		public void RefreshAttributes(EntityAttributeBase attribute)
		{
		}

		public string getInvalidInfo()
		{
			return null;
		}

		public string getAllInfo()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
