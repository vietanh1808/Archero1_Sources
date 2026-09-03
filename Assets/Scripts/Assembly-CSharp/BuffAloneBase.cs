using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class BuffAloneBase
{
	public class BuffData
	{
		public int symbol;

		public float updatetime;

		public float value;

		public int hurtCount;

		public string hittype;

		public float current_time;
	}

	public const string Hit_Fixed = "FixedDamage";

	public const string Hit_AttackPercent = "Attack%";

	public const string Hit_AttackBasePercent = "AttackBase%";

	public const string Hit_HPMaxFrom = "SourceHPMax%";

	public const string Hit_HPFrom = "SourceHP%";

	public const string Hit_HPMaxTo = "TargetHPMax%";

	public const string Hit_HPTo = "TargetHP%";

	public const string RecoverHPPercent = "HPRecover%";

	public const string BodyHitPercent = "BodyHit%";

	public const string RecoverHPBasePercent = "HPRecoverBase%";

	public const string HPRecover = "HPRecover";

	private int _BuffID;

	private bool _bOverlapEffect;

	protected List<Goods_goods.GoodData> attrList;

	protected Buff_alone buff_data;

	protected EntityBase m_Entity;

	protected EntityBase m_Target;

	protected float startTime;

	private float _endTime;

	private float extraTimeToAdd;

	private float m_fDurationRatio;

	protected bool bForever;

	protected bool isEnd;

	private bool bDizzyTrue;

	private bool bCanDizzy;

	protected bool bIsIgnoreDizzyCD;

	private EElementType changeElement;

	protected float[] args;

	protected string[] _attrs;

	private Dictionary<string, float> excutebuff_values;

	public Action<int> RemoveAction;

	private GameObject effect;

	protected List<BuffData> mEffects;

	private bool needEffect;

	private const string VAMPIRE_LOG_TAG = "[元素伤害吸血]";

	public const string BlackAttackPercent = "BlackAttack%";

	public const string BlackRange = "Range";

	public const string BlackSpreadRate = "SpreadRate%";

	private float black_range;

	private float black_hit;

	private float black_spread_rate;

	protected float charm_selfhit;

	private float ice_selfhit;

	private float poison_selfhit;

	public const string SelfAttackPercent = "SelfAttack%";

	public const string SelfFixedDamage = "SelfFixedDamage";

	public const string OtherAttackPercent = "OtherAttack%";

	public const string OtherFixedDamage = "OtherFixedDamage";

	public const string ThunderRange = "Range";

	private const string String_SelfAttackDecayPercent = "SelfAttackDecay%";

	private const string String_SelfAttackMinPercent = "SelfAttackMin%";

	private int m_nSelfAttackDecay;

	private int m_nSelfAttackMin;

	private float thunder_range;

	private float thunder_otherhit;

	private float thunder_selfhit;

	private float damage_selffixedhit;

	protected string Tag => null;

	public int BuffID => 0;

	public EntityBase Entity => null;

	protected virtual float endTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public GameObject EffectObj => null;

	public void AddDuration(float toAdd)
	{
	}

	public void SetExtraTime(float extra)
	{
	}

	public void Init(EntityBase entity, BattleStruct.BuffStruct data, Buff_alone buff_data, bool overlapEffect)
	{
	}

	protected virtual void ParseArgs(float[] args)
	{
	}

	public BattleStruct.BuffStruct GetBuffStruct()
	{
		return default;
	}

	public void InitByCmd(EntityBase entity, BuffCommand data, Buff_alone buff_data, bool overlapEffect)
	{
	}

	protected virtual void OnEnemyDebuffIntervalValueChanged(float value)
	{
	}

	private void CalEnemyDebuffInterval(float value)
	{
	}

	protected virtual void nEnemyDebuffTimeValueChanged(float value)
	{
	}

	private void CalEnemyDebuffTimeValue(float value)
	{
	}

	protected virtual void OnGainBuffTimeValueChanged(float value)
	{
	}

	private void CalGainBuffTimeValue(float value)
	{
	}

	private void CalEndTimeWrapper()
	{
	}

	protected virtual void OnStart()
	{
	}

	public void ResetBuffTime(bool force = false)
	{
	}

	protected virtual void CalStartTime()
	{
	}

	protected virtual void CalEndTime()
	{
	}

	public bool IsDizzyBuff()
	{
		return false;
	}

	protected virtual void OnResetBuffTime()
	{
	}

	protected virtual void onBuffExcuteOnce()
	{
	}

	protected virtual string[] Buff_alone_Effects()
	{
		return null;
	}

	protected virtual string[] Buff_alone_Attributes()
	{
		return null;
	}

	public void OverlapAndResetTime()
	{
	}

	public int GetOverlapTimes()
	{
		return 0;
	}

	private bool ShowEffects()
	{
		return false;
	}

	protected virtual void OnOverlap()
	{
	}

	protected virtual void OnOverlapAndResetTime()
	{
	}

	private void InitEffects()
	{
	}

	protected BuffData GetGoodDataFirst(string str)
	{
		return null;
	}

	private void ExcuteFirstEffects()
	{
	}

	private void ExcuteAttribute()
	{
	}

	public virtual void ExcuteAttributes()
	{
	}

	protected virtual Goods_goods.GoodData OnExcuteAttributes(string attrone)
	{
		return null;
	}

	private void ExcuteEffects()
	{
	}

	protected virtual void OnExcuteEffects()
	{
	}

	protected virtual BuffData GetGoodDataEvery(string str)
	{
		return null;
	}

	public void CreateEffect()
	{
	}

	protected virtual void OnCreateEffect(GameObject effect)
	{
	}

	private void RemoveEffect()
	{
	}

	public virtual bool IsEnd()
	{
		return false;
	}

	private void RemoveAttributes()
	{
	}

	protected virtual void OnRemoveAttribute(Goods_goods.GoodData data)
	{
	}

	public void Remove()
	{
	}

	protected virtual void OnRemove()
	{
	}

	public virtual void OnUpdate(float delta)
	{
	}

	protected virtual float OnValue(float value)
	{
		return 0f;
	}

	private void DealBuffHit()
	{
	}

	protected void update_excutebuff_value(string type, float value)
	{
	}

	private float get_excutebuff_value(string type)
	{
		return 0f;
	}

	protected bool is_excutebuff_value(string type)
	{
		return false;
	}

	protected virtual void ExcuteBuff(BuffData data)
	{
	}

	protected virtual bool ExcuteBuffs(BuffData data)
	{
		return false;
	}

	public void AfterMeadowBattleProcess(ref float value1, BuffData data)
	{
	}

	private void recoverFromElementHit(string elementType, float elementHit)
	{
	}

	private float ExcuteElement(BuffData data, float value)
	{
		return 0f;
	}

	protected bool IsElementBuff()
	{
		return false;
	}

	public int GetSourceEntityGuid()
	{
		return 0;
	}

	private void debug(string value, params object[] args)
	{
	}

	protected void debugerror(string value, params object[] args)
	{
	}

	private void black_init()
	{
	}

	private void Excute_Black()
	{
	}

	protected virtual List<EntityBase> GetTargets(float range)
	{
		return null;
	}

	private void Excute_Black_FirstEffects()
	{
	}

	private void Excute_Charm()
	{
	}

	protected void ExcuteCharmBuff()
	{
	}

	private void Excute_Ice()
	{
	}

	protected virtual float CalcFirstEffectsIceDmg()
	{
		return 0f;
	}

	private void Excute_Poison()
	{
	}

	private void Excute_Thunder()
	{
	}

	private float getThunderPercent(EntityBase target, EntityBase entity)
	{
		return 0f;
	}
}
