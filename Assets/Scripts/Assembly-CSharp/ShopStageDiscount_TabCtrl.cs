using System;
using UnityEngine;
using UnityEngine.UI;

public class ShopStageDiscount_TabCtrl : MonoBehaviour
{
	public enum TabName
	{
		NORMAL = 0,
		HERO = 1,
		HELL = 2
	}

	public ButtonCtrl tabNormal;

	public ButtonCtrl tabHero;

	public Image imageNormal;

	public Image imageHero;

	public Image iconNormal;

	public Image iconHero;

	public DxxText textNormal;

	public DxxText textHero;

	public Action<TabName> onTabClicked;

	private bool tarBarEnabled;

	private TabName selectedTab;

	private Func<bool> checkBusy;

	public int GetHeight()
	{
		return 0;
	}

	public void OnInit()
	{
	}

	public void SetEnabled(bool enabled)
	{
	}

	public void SetCheckBusy(Func<bool> checkBusy)
	{
	}

	protected static void SetTop(RectTransform transform, float top)
	{
	}

	protected static void SetAlpha(Image image, float alpha)
	{
	}

	protected static void SetAlpha(Text text, float alpha)
	{
	}

	public void SetTabSelected(TabName tab)
	{
	}

	public void OnLanguageChange(int index)
	{
	}
}
