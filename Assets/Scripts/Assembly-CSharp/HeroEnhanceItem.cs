using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class HeroEnhanceItem : EnhanceItem
{
	public DxxText id;

	public Transform ModelParent;

	public DxxImage lockImg;

	public BodyMask bodyMask;

	[SerializeField]
	private RectTransform effectparent;

	private List<GameObject> m_listEffects;

	private bool isSelected;

	public RawImage img_heroShow;

	private HeroShow heroShow;

	public PlayerCharacter_Skin Data => null;

	protected override void SetItemDepth(float depthCurveValue, int depthFactor, float itemCount)
	{
	}

	public override void SetSelectState(bool isCenter)
	{
	}

	private void RefShader()
	{
	}

	private void SetShaderColorPower(float pPower)
	{
	}

	protected override void OnUpdateItemRender()
	{
	}

	private void LoadModel(PlayerCharacter_Skin data)
	{
	}

	private void UnLoadModel(PlayerCharacter_Skin data)
	{
	}

	private void CreatModel(GameObject res, string modelId)
	{
	}

	private void createHeroModel(GameObject res)
	{
	}

	private GameObject createHeroShow(GameObject res)
	{
		return null;
	}

	private string GetBodyString(string value)
	{
		return null;
	}

	protected override void OnPreClose()
	{
	}

	protected override void OnClose()
	{
	}
}
