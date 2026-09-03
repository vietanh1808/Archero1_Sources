using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class MainUIButtonBaseCtrl : MonoBehaviour
{
	private List<MainUIButtonBase> mInterfaces;

	public RectTransform bgImg;

	public Button openBtn;

	public RectTransform contentParent;

	public ScrollRect scrollRect;

	public Transform arrow;

	public RedNodeCtrl redNodeCtrl;

	public Mask mask;

	private bool isOpen;

	private int minShowCount;

	private int maxShowCount;

	private int ShowBgCount;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Add;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_OnClickOpenBtn;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_DeInit;

	private static DelegateBridge __Hotfix0_UpdateUI;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public void Add(MainUIButtonBase item)
	{
	}

	public void Refresh()
	{
	}

	public void OnClickOpenBtn()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void Close()
	{
	}

	public void DeInit()
	{
	}

	public void UpdateUI()
	{
	}
}
