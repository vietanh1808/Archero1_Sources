using NewPlay121;
using UnityEngine;

public class NPCDragonSkillItem : BaseDragonSkillItem
{
	public DragonSkillIcon skillIcon;

	public ButtonCtrl btn_get;

	public ButtonCtrl btn_icon;

	public DxxImage img_dragonCoin;

	public DxxText txt_dragonCoin;

	protected int skillId;

	protected int dragonCoinCost;

	private Color oldColor;

	public RectTransform c2;

	public bool IsEnabled => false;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void Refresh(int _skillId)
	{
	}

	private void refreshDragonCoin(int skillId)
	{
	}
}
