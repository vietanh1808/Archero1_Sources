using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class IdentfySelectUICtl : MonoBehaviour
{
	public Text windowTitleText;

	public Text windowContentText;

	public RectTransform heroView;

	public IdentfySelectHeroItemUI tempHero;

	public ButtonCtrl closeBtn;

	private List<IdentfySelectHeroItemUI> heroList;

	private IdentfySelectHeroItemUI curSelect;

	public void Init()
	{
	}

	private IdentfySelectHeroItemUI CreatOneHero(int pIndex, PlayerCharacter_Character item)
	{
		return null;
	}

	public void Show(bool pShow)
	{
	}

	protected void OnAndroid_escape()
	{
	}

	public void RestList()
	{
	}

	private void ClearList()
	{
	}

	public void SetSelect(IdentfySelectHeroItemUI pItem)
	{
	}

	public void RestUI()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void OnCloseClick()
	{
	}
}
