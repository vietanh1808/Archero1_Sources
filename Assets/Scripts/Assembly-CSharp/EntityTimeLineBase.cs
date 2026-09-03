using System;
using TableTool;
using UnityEngine;

public class EntityTimeLineBase : MonoBehaviour
{
	public enum EntityType
	{
		none = 0,
		hero = 1,
		monster = 2
	}

	public bool isDead;

	public Action<string> OnAnimationComplete;

	public Action<EntityTimeLineBase> OnBeingHit;

	protected GameObject child;

	private string _modelid;

	protected bool bHittedColor;

	protected float mHittedTime;

	public Character_Char cData { get; protected set; }

	public int ClassID { get; protected set; }

	public BodyMask Body { get; protected set; }

	public Animation animationBase { get; protected set; }

	public AnimationTimeLineCtrlBase aniCtrl { get; protected set; }

	public WeaponTimeLineBase weapon { get; protected set; }

	public EntityType eType { get; protected set; }

	public BodyShaderTimeLine BodyShader { get; protected set; }

	public bool isHero => false;

	public bool IsElite { get; set; }

	public EntityTimeLineBase Target { get; protected set; }

	public virtual string modelid
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	public virtual void InitHero(int nSkinId, int nWeaponId)
	{
	}

	protected virtual void CreateHeroModel(int nSkinId, int nWeaponId)
	{
	}

	public virtual void Init(int id)
	{
	}

	protected virtual void CreateModel(int nWeaponId = 0)
	{
	}

	protected virtual void InitAnimation()
	{
	}

	protected virtual void DeInitAnimations()
	{
	}

	protected virtual void LoadNode()
	{
	}

	protected virtual GameObject GetModelRes()
	{
		return null;
	}

	public virtual void InitWeapon(int WeaponID)
	{
	}

	public Transform GetBulletCreateNode(Weapon_weapon data)
	{
		return null;
	}

	protected string GetBodyString(string value)
	{
		return null;
	}

	public void SetTarget(EntityTimeLineBase pTarget)
	{
	}

	public virtual void BeingHit(EntityTimeLineBase pFrom)
	{
	}

	public virtual void ShowDeadEffect()
	{
	}

	public void PlayAni(string pAniName)
	{
	}

	public void CrossFadeMode(string animation, float fadeLength, PlayMode mode)
	{
	}

	public void CrossFade(string animation)
	{
	}

	public void PlayAttack()
	{
	}

	public virtual void CallAnimationComplete(string pKey)
	{
	}

	public virtual void StopAllAnimation()
	{
	}

	public virtual void RunState(Action pOnComplete = null)
	{
	}

	public virtual void NormalState(Action pOnComplete = null)
	{
	}

	public virtual void HitState(Action pOnComplete = null)
	{
	}

	public virtual float DeadState(Action pOnComplete = null)
	{
		return 0f;
	}

	public virtual void StartAttack(Action pOnComplete = null)
	{
	}

	public virtual void EndAttack(Action pOnComplete = null)
	{
	}

	public virtual void Hitted()
	{
	}

	private void Update()
	{
	}

	protected virtual void UpdateProcess()
	{
	}

	private void OnDestroy()
	{
	}
}
