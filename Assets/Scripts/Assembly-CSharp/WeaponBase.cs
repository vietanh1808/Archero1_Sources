using System;
using Dxx.Util;
using TableTool;
using UnityEngine;

public class WeaponBase
{
	public Action OnAttackStartStartAction;

	public Action OnAttackStartEndAction;

	public Action OnAttackEndStartAction;

	public Action OnAttackEndEndAction;

	public Action OnAttackInterruptAction;

	public Action OnBulletCache;

	public Action Event_EntityAttack_AttackEnd;

	public Action Event_Continue;

	private bool _attack_ani_end;

	private bool _attackend_actionend;

	private Transform createeffectparent;

	private int createeffectid;

	private GameObject createeffect;

	private bool bInit;

	public Weapon_weapon m_Data;

	protected EntityBase m_Entity;

	protected bool pShowDirection;

	protected int BulletID;

	private string prevAttackPrev;

	private string prevAttackEnd;

	protected int ParabolaSize;

	protected ActionBasic action;

	protected SequencePool mSeqPool;

	private WaitForSeconds continue_delay;

	protected bool bClear;

	protected bool bDizzyRemove;

	protected bool bulletLoaded;

	protected float attackRatio;

	protected float finalHitRatio;

	private float bulletSpeed;

	protected float backRatio;

	protected EntityBase Target;

	private float oldAttackRatio;

	private bool runDoAttackEnd;

	private bool addBulletSpeed;

	private bool canReboundBySkill;

	protected EntityBase CustomHatredTarget;

	public string Tag => null;

	protected bool bAttackEndActionEnd
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowDirection
	{
		set
		{
		}
	}

	protected int throughEnemy { get; set; }

	protected float throughRatio { get; set; }

	protected virtual float Forward_Backward_OffsetOne { get; set; }

	public int GetParabolaSize()
	{
		return 0;
	}

	public void Init(EntityBase entity, int weaponid)
	{
	}

	private void loadBulletModel(Action<GameObject> onLoaded)
	{
	}

	public string GetWeaponHandId()
	{
		return null;
	}

	private void onBulletModelLoaded(GameObject res)
	{
	}

	private void onBulletModelLoadedAttacking(GameObject res)
	{
	}

	protected virtual void OnInit()
	{
	}

	public void SetTarget(EntityBase entity)
	{
	}

	public EntityBase GetTarget()
	{
		return null;
	}

	public void SetDizzyCantRemove()
	{
	}

	public void Install()
	{
	}

	public void SetEffectWeakenStatus()
	{
	}

	protected virtual void OnInstall()
	{
	}

	public void UnInstall()
	{
	}

	protected virtual void OnUnInstall()
	{
	}

	private void FlushRemainingContinueShots()
	{
	}

	public void ClearWeaponAction()
	{
	}

	public void OnAttackStart_StartCallback()
	{
	}

	public void OnAttackStart_EndCallback()
	{
	}

	public void OnAttackEnd_StartCallback()
	{
	}

	public void OnAttackEnd_EndCallback()
	{
	}

	private void OnDizzy(bool value)
	{
	}

	protected void SetCreateEffect(int effectid, Transform parent = null)
	{
	}

	private void CreateCreateEffect()
	{
	}

	private void RemoveCreateEffect()
	{
	}

	public static Transform GetWeaponNode(BodyMask body, int weaponnode)
	{
		return null;
	}

	public void SetFlying(bool fly)
	{
	}

	public virtual void AttackJoyTouchDown()
	{
	}

	public virtual void AttackJoyTouchUp()
	{
	}

	private void OnAttackEnd()
	{
	}

	protected void Event2EntityAttack()
	{
	}

	public void Attack(params object[] args)
	{
	}

	protected virtual void OnAttack(params object[] args)
	{
	}

	protected virtual void DoAttack()
	{
	}

	protected virtual float GetBulletContinueDelayTime(int remainCount)
	{
		return 0f;
	}

	public void DoAttackEndWrapper()
	{
	}

	private void doAttackEnd(float oldAttackRatio)
	{
	}

	protected virtual void OnBeforeBulletContinue()
	{
	}

	protected virtual void OnAfterBulletContinue()
	{
	}

	private void updateBulletContinue(string symbol)
	{
	}

	protected virtual void CalChargeRatio()
	{
	}

	public void SetAttackRatio(float value)
	{
	}

	public void SetFinalHitRatio(float value)
	{
	}

	public float GetAttackRatio()
	{
		return 0f;
	}

	private void AddChargeAttr()
	{
	}

	private void ResetChageAttr()
	{
	}

	protected void CreateBullets(bool isFromEntityAutoAttack = false)
	{
	}

	private void CreateBullets_LeftRight(long count, bool isFromEntityAutoAttack = false)
	{
	}

	protected virtual void CreateExtraBullets()
	{
	}

	private void CreateBullets_Side(long count, bool isFromEntityAutoAttack = false)
	{
	}

	private void CreateBullets_SideInternalByAngle(float angle, bool isFromEntityAutoAttack = false)
	{
	}

	protected void CreateBullets_SideInternal(float per, float rotaoffsets, long count, bool isFromEntityAutoAttack = false)
	{
	}

	private void CreateBullets_(long count, float rotaoffset, bool isFromEntityAutoAttack = false)
	{
	}

	private void changeAttackRatio()
	{
	}

	protected void CheckSendArtifactBullet(BulletBase bulletBase, bool isFromEntityAutoAttack)
	{
	}

	protected void CreateBullets_Forward(float rotaoffset, bool isFromEntityAutoAttack = false)
	{
	}

	public void SetCanReboundBySkill(bool value)
	{
	}

	protected virtual void OnAfterSetBulletAttribute(BulletBase b)
	{
	}

	protected Transform CreateBullet(float rota)
	{
		return null;
	}

	protected Transform CreateBullet(Vector3 offsetpos)
	{
		return null;
	}

	public virtual Transform CreateBullet(Vector3 offsetpos, float rota, float customAngleY = -1f)
	{
		return null;
	}

	protected Transform CreateBulletByObject(BulletBase b, Vector3 offsetpos, float rota, float customAngleY = -1f)
	{
		return null;
	}

	protected virtual void OnBulletCreate(BulletBase bullet)
	{
	}

	protected BulletBase CreateBulletOverride()
	{
		return null;
	}

	protected BulletBase CreateBulletOverride(Vector3 offsetpos)
	{
		return null;
	}

	protected BulletBase CreateBulletOverride(float rota)
	{
		return null;
	}

	protected BulletBase CreateBulletOverrideNoAsync(Vector3 offsetpos, float rota)
	{
		return null;
	}

	public BulletBase CreateBulletOverride(Vector3 offsetpos, float rota, Action<BulletBase> onLoaded = null, float customAngle = -1f)
	{
		return null;
	}

	public void SetOrder(int order)
	{
	}

	public void SetCustomHatredTarget(EntityBase value)
	{
	}
}
