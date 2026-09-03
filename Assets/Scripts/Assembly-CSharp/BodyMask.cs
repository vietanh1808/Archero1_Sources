using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class BodyMask : PauseObject
{
	public class BodyElementData
	{
		public Color color;

		public int count;
	}

	public GameObject LeftWeapon;

	public GameObject RightWeapon;

	[Header("0法杖 1长矛")]
	public List<GameObject> OtherWeapons;

	public GameObject LeftBullet;

	public GameObject Body;

	public GameObject EffectMask;

	public GameObject HPMask;

	public GameObject FootMask;

	public GameObject HeadMask;

	public GameObject RotateMask;

	public GameObject BulletHitMask;

	public GameObject HeadTopEffect;

	public GameObject SpecialHitMask;

	public List<GameObject> BulletList;

	public List<MeshRenderer> Body_Extra_MeshRenderers;

	public List<SkinnedMeshRenderer> Body_Extra;

	public List<SkinnedMeshRenderer> SeparateBodies;

	public GameObject AnimatorBodyObj;

	public Transform BodyCenter;

	[SerializeField]
	private Transform m_tWingParent;

	public GameObject SpecialBone;

	[NonSerialized]
	public HeroPlayMakerControl mHeroPlayMakerCtrl;

	[NonSerialized]
	public GameObject ZeroMask;

	protected EntityBase m_Entity;

	private Dictionary<int, Transform> mWeaponPosList;

	private Animation ani;

	private bool bOffset;

	private bool bFlyStone;

	private float m_fAddScale;

	protected BodyMaskCamera mCamera;

	protected BodyShaderBase mShaderBase;

	private Vector3? originEffectScale;

	private Vector3 originEffectPos;

	private Dictionary<EElementType, BodyElementData> ElementColor;

	private bool bVisible;

	protected bool bHittedColor;

	protected float mHittedTime;

	private bool bTargetColor;

	private Dictionary<int, GameObject> mHeadTopList;

	private List<int> mHeadIDs;

	public Transform WingParent => null;

	public EntityBase Entity => null;

	public Transform DeadNode => null;

	private void Awake()
	{
	}

	public void SetLocalPosition(float x, float z)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void PlayAnim(string anim)
	{
	}

	public virtual bool isHaveAniName(string anim)
	{
		return false;
	}

	protected virtual void AwakeInit()
	{
	}

	public void InitShaderBase()
	{
	}

	public BodyShaderBase GetBodyShaderBase()
	{
		return null;
	}

	public virtual void SetEntity(EntityBase entity)
	{
	}

	public void SetEntityInDragon(EntityBase entity)
	{
	}

	public void UpdateElite()
	{
	}

	public void UpdateHell()
	{
	}

	public void updateWithSpecialShader()
	{
	}

	public void updateWithNormalShader()
	{
	}

	public void UpdateTransparent()
	{
	}

	public void UpdateBodyExtraTransparent()
	{
	}

	public void SetSeparateBodiesVisible(bool visible)
	{
	}

	public void SetTexture(string value)
	{
	}

	public void SetRimColor(Color color)
	{
	}

	public void SetColorPower(float value)
	{
	}

	public void SetRimPower(float value)
	{
	}

	public void SetTextureWithoutInit(string value)
	{
	}

	public void SetStrengh()
	{
	}

	public void AddScale(float scale)
	{
	}

	private float getMetaBodyScale()
	{
		return 0f;
	}

	public void SetScale(float scale)
	{
	}

	public void ResetScaleInMeadowBattle()
	{
	}

	private void OnElite()
	{
	}

	public Transform GetBullet(int index)
	{
		return null;
	}

	public void SetIsVislble(bool value)
	{
	}

	public bool GetIsInCamera()
	{
		return false;
	}

	public virtual void Hitted(Vector3 HittedDirection, HitType type)
	{
	}

	public void SetMaterialSuperGold()
	{
	}

	protected virtual void OnHittedColorBefore()
	{
	}

	protected override void UpdateProcess()
	{
	}

	protected virtual void OnHittedColor()
	{
	}

	public void AddElement(EElementType type)
	{
	}

	public void RemoveElement(EElementType type)
	{
	}

	private void UpdateElement()
	{
	}

	public void DeadDown()
	{
	}

	public void SetFlyStone(bool fly)
	{
	}

	public void DeInit()
	{
	}

	public void CacheEffect()
	{
	}

	private void CacheNode(GameObject node)
	{
	}

	private void CacheNode(Transform node)
	{
	}

	public void SetTarget(bool value)
	{
	}

	public void SetBodyScale(float value)
	{
	}

	public void CustomBodyScale(Vector3 scale)
	{
	}

	public float GetBodyScale()
	{
		return 0f;
	}

	public void SetOrder()
	{
	}

	public Transform GetWeaponNode(int index, Transform t)
	{
		return null;
	}

	public void SetAlpha(float alpha)
	{
	}

	public float GetAlpha()
	{
		return 0f;
	}

	public void SetBodyExtraAlpha(float alpha)
	{
	}

	public void ShowShadow(bool show)
	{
	}

	public void AddClips(List<AnimationClip> clips)
	{
	}

	public void AddClip(AnimationClip clip)
	{
	}

	public void AddAnyClip(AnimationClip clip)
	{
	}

	private void InitBodyEffects(int nFxId, int layer)
	{
	}

	public void InitEffects(Character_Char data, int layer)
	{
	}

	public void InitEffects(int id, int layer)
	{
	}

	public Transform GetKetNode(int index)
	{
		return null;
	}

	public void SetBodyOnlyVisible(bool visible)
	{
	}

	public bool ChangeMesh(GameObject o)
	{
		return false;
	}

	public void EnableAni(bool enable)
	{
	}

	public List<string> GetAllAniNams()
	{
		return null;
	}

	public GameObject InitWing(int nWingId, int nSkinId, int wingStar, int nWeaponId = 0)
	{
		return null;
	}

	public void DeinitWing()
	{
	}

	public float GetCurAniRemainTime()
	{
		return 0f;
	}

	public float GetCurAniTime()
	{
		return 0f;
	}

	public void ResetCurAniTime()
	{
	}

	public void AddHeadTop(int skillaloneid, GameObject o)
	{
	}

	public void RemoveHeadTop(int skillaloneid)
	{
	}

	public Vector3 GetHeadPosition(int skillaloneid)
	{
		return default;
	}

	private void UpdateHeadTop()
	{
	}
}
