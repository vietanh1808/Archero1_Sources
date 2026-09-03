using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Weapon_weapon : LocalBean
	{
		private ObscuredInt _WeaponID;

		private ObscuredInt _SpecialAttribute;

		private ObscuredString _ModelID;

		private ObscuredFloat _ModelScale;

		private ObscuredString[] _Attributes;

		private ObscuredString _Element;

		private ObscuredInt _DebuffID;

		private ObscuredInt _LookCamera;

		private ObscuredInt _Attack;

		private ObscuredFloat _Distance;

		private ObscuredFloat _Speed;

		private ObscuredFloat _AttackSpeed;

		private ObscuredFloat _AttackSpeedMax;

		private ObscuredFloat _RandomAngle;

		private ObscuredInt _WeaponNode;

		private ObscuredInt _CreateNode;

		private ObscuredFloat _RotateSpeed;

		private ObscuredString _AttackPrevString;

		private ObscuredString _AttackEndString;

		private ObscuredString _IdleString;

		private ObscuredInt _Ballistic;

		private ObscuredFloat _BackRatio;

		private ObscuredInt _CreateEffectID;

		private ObscuredInt _CreateSoundID;

		private ObscuredInt _DeadSoundID;

		private ObscuredInt _HitWallSoundID;

		private ObscuredInt _HittedEffectID;

		private ObscuredInt _AliveTime;

		private ObscuredInt _DeadDelay;

		private ObscuredInt _DeadDelayMissTrail;

		private ObscuredInt _DeadEffectID;

		private ObscuredInt _DeadNode;

		private ObscuredInt[] _Trickoffskills;

		private ObscuredInt _IfNear;

		private ObscuredString[] _Args;

		private ObscuredInt _IfCommonWeapon;

		private ObscuredInt _IsThrowWeapon;

		private ObscuredInt _DisableDeadDelayInWall;

		private ObscuredFloat _WeaponInterval;

		private bool bInitSpecial;

		private bool bCachep;

		private bool bThroughWallp;

		private bool bThroughEntityp;

		private bool bThroughInsideWallp;

		private bool bMoreHitp;

		private bool bTriggerWater;

		private bool bIgnorMultiBullet;

		private LayerManager.BulletLayer mLayer;

		public int WeaponID => 0;

		public int SpecialAttribute => 0;

		public string ModelID => null;

		public float ModelScale => 0f;

		public string[] Attributes => null;

		public string Element => null;

		public int DebuffID => 0;

		public int LookCamera => 0;

		public int Attack => 0;

		public float Distance => 0f;

		public float Speed => 0f;

		public float AttackSpeed => 0f;

		public float AttackSpeedMax => 0f;

		public float RandomAngle => 0f;

		public int WeaponNode => 0;

		public int CreateNode => 0;

		public float RotateSpeed => 0f;

		public string AttackPrevString => null;

		public string AttackEndString => null;

		public string IdleString => null;

		public int Ballistic => 0;

		public float BackRatio => 0f;

		public int CreateEffectID => 0;

		public int CreateSoundID => 0;

		public int DeadSoundID => 0;

		public int HitWallSoundID => 0;

		public int HittedEffectID => 0;

		public int AliveTime => 0;

		public int DeadDelay => 0;

		public int DeadDelayMissTrail => 0;

		public int DeadEffectID => 0;

		public int DeadNode => 0;

		public int[] Trickoffskills => null;

		public int IfNear => 0;

		public string[] Args => null;

		public int IfCommonWeapon => 0;

		public int IsThrowWeapon => 0;

		public int DisableDeadDelayInWall => 0;

		public float WeaponInterval => 0f;

		public bool bCache => false;

		public bool bThroughWall => false;

		public bool bThroughEntity => false;

		public bool bThroughInsideWall => false;

		public bool bMoreHit => false;

		public bool TriggerWater => false;

		public bool IgnorMultiBullet => false;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Weapon_weapon Copy()
		{
			return null;
		}

		public int GetLayer()
		{
			return 0;
		}

		private void InitSpecial()
		{
		}

		public bool IsThrowWeaponType()
		{
			return false;
		}

		public void resetThroughInsideWall(bool through)
		{
		}
	}
}
