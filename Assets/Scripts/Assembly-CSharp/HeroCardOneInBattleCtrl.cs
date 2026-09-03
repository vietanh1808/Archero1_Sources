using System;
using UnityEngine;

public class HeroCardOneInBattleCtrl : MonoBehaviour
{
	private static Material _gray;

	public DxxImage CardImage;

	public ButtonCtrl SelectBtn;

	public DxxText RoleLevelText;

	public HeroCardInfo CardData;

	public Action<HeroCardInfo> onClickAction;

	public static Material GrayMaterial => null;

	public void Init(HeroCardInfo data, Action<HeroCardInfo> onClickAction)
	{
	}

	public void SetGray(bool ifGray)
	{
	}

	public void UpdateIcon()
	{
	}

	public void UpdateState()
	{
	}

	public void OnClick()
	{
	}
}
