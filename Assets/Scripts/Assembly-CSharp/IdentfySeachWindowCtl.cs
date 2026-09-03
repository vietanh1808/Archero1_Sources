using System.Collections.Generic;
using DG.Tweening;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class IdentfySeachWindowCtl : MonoBehaviour
{
	[Header("物品")]
	public GridLayoutGroup centerGroup;

	public GameObject itemTemp;

	[Header("主要信息")]
	public Image icon;

	public Text nameText;

	public Text getText;

	public Text effectText;

	[Header("操作按钮")]
	public Text seachBtnText;

	public Text seachValueBtnText;

	public ButtonCtrl seachBtn;

	[Header("其他")]
	public Button sceneClickBtn;

	public RectTransform seachingLayer;

	public RectTransform seachLayerItem;

	public const int useCoinItem = 1;

	private IdentfyItem itemData;

	private Gambling_StoneConfig itemConfig;

	private List<IdentfySeachItemCtl> itemList;

	private Sequence seachingAni;

	private Sequence waitSeach;

	private Sequence gotoTargetAni;

	private bool isSeaching;

	public int Index { get; private set; }

	public void Init()
	{
	}

	public void Show(bool pShow)
	{
	}

	protected void OnAndroid_escape()
	{
	}

	private void OnCloseClick()
	{
	}

	private void OnSeachClick()
	{
	}

	private int GetRandIndex()
	{
		return 0;
	}

	private void StartSeach()
	{
	}

	private void PlayGoToTarget(int pIndex)
	{
	}

	private void PlaySeachingAnimation()
	{
	}

	public void SetData(int pIndex, IdentfyItem pData)
	{
	}

	private void Clear()
	{
	}

	private void RestItemList()
	{
	}

	private void RefValueText()
	{
	}

	private void RefItemInfo()
	{
	}

	public void OnLanguageChange()
	{
	}
}
