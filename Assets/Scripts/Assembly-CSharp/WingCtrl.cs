using TableTool;
using UnityEngine;

public class WingCtrl
{
	private Wings_Skin m_data;

	private Transform m_wingParent;

	private Animation m_ani;

	private GameObject m_objWing;

	private EntityBase m_Entity;

	private Wing _wing;

	public const string WING_MODEL_PATH = "Game/Models/Wing";

	public const string WING_ANI_ASSET_PATH = "AniAssets/Wing";

	public void Init(EntityBase entity, int nSkinId, Transform wingParent, int nWingId = 0, int star = 0, bool isSelf = true)
	{
	}

	public void SetTexture(string path)
	{
	}

	public void SetAlphaEffect(float alpha)
	{
	}

	public void SetVisible(bool visible)
	{
	}

	private void InitAnimations()
	{
	}

	private void AddClip(int nWeaponId, string clipName, string defaultClipName)
	{
	}

	public void InitWeaponAnimations(int nWeaponID)
	{
	}

	public void DeInit()
	{
	}

	public Animation GetAnimation()
	{
		return null;
	}

	private void OnAddAnimationClipEvent(string name)
	{
	}

	private void OnChangeAnimation(AnimationCtrlBase.AniClass aniClass)
	{
	}
}
