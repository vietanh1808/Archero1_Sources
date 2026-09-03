using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Character_Char : LocalBean
	{
		public enum BODYTYPE
		{
			BodyType_Humanoid = 1,
			BodyType_Nonhumanoid = 2,
			BodyType_Animal = 4,
			BodyType_Undead = 8,
			BodyType_Mechanic = 0x10,
			BodyType_Large = 0x20
		}

		private ObscuredInt _CharID;

		private ObscuredInt _TypeID;

		private ObscuredString _ModelID;

		private ObscuredFloat _BodyScale;

		private ObscuredFloat _EffectScale;

		private ObscuredFloat _SoulsScale;

		private ObscuredString _TextureID;

		private ObscuredInt _WeaponID;

		private ObscuredString[] _DeadDivide;

		private ObscuredInt _Attackrangetype;

		private ObscuredInt _BodyType;

		private ObscuredInt _Speed;

		private ObscuredInt _HP;

		private ObscuredInt _RotateSpeed;

		private ObscuredInt _BodyAttack;

		private ObscuredInt _Divide;

		private ObscuredInt[] _Skills;

		private ObscuredFloat[] _ThroughRatio;

		private ObscuredFloat _BackRatio;

		private ObscuredFloat[] _ActionSpeed;

		private ObscuredInt _HittedEffectID;

		private ObscuredInt _DeadSoundID;

		private ObscuredInt _Cache;

		private ObscuredInt[] _ImmunityBuff;

		private ObscuredInt[] _ImmunityBuffTime;

		private ObscuredInt _KillMonsterId;

		private ObscuredInt[] _EffectId;

		private ObscuredFloat _SwordHitRatio;

		private ObscuredInt _CritGetBuff;

		private ObscuredInt _AttackDistance;

		private ObscuredInt _CritRateResist;

		private ObscuredInt _CritValueResist;

		private ObscuredFloat[] _HellMonsterInfo;

		private bool bInit;

		private Dictionary<string, DeadDivideData> mDeadDivide;

		public int CharID => 0;

		public int TypeID => 0;

		public string ModelID => null;

		public float BodyScale => 0f;

		public float EffectScale => 0f;

		public float SoulsScale => 0f;

		public string TextureID => null;

		public int WeaponID => 0;

		public string[] DeadDivide => null;

		public int Attackrangetype => 0;

		public int BodyType => 0;

		public int Speed => 0;

		public int HP => 0;

		public int RotateSpeed => 0;

		public int BodyAttack => 0;

		public int Divide => 0;

		public int[] Skills => null;

		public float[] ThroughRatio => null;

		public float BackRatio => 0f;

		public float[] ActionSpeed => null;

		public int HittedEffectID => 0;

		public int DeadSoundID => 0;

		public int Cache => 0;

		public int[] ImmunityBuff => null;

		public int[] ImmunityBuffTime => null;

		public int KillMonsterId => 0;

		public int[] EffectId => null;

		public float SwordHitRatio => 0f;

		public int CritGetBuff => 0;

		public int AttackDistance => 0;

		public int CritRateResist => 0;

		public int CritValueResist => 0;

		public float[] HellMonsterInfo => null;

		public bool IsHumanoid => false;

		public bool IsNonhumanoid => false;

		public bool IsAnimal => false;

		public bool IsUndead => false;

		public bool IsMechanic => false;

		public bool IsLarge => false;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Character_Char Copy()
		{
			return null;
		}

		private void init_dead_divide()
		{
		}

		public DeadDivideData GetDeadDivide(bool iselite)
		{
			return null;
		}
	}
}
