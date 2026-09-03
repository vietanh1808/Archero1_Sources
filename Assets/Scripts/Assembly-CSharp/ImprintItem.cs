using System;
using UnityEngine;
using UnityEngine.UI;

public class ImprintItem : MonoBehaviour
{
	public Image m_Icon;

	public Image m_Bg;

	public ImprintStarCtrl m_StarCtrl;

	public GameObject m_mask;

	public ButtonCtrl m_Button;

	public Slider m_Slider;

	public DxxText Text_Pross;

	public DxxText Text_Add;

	public RedNodeCtrl m_RedNode;

	public GameObject mEffectUp;

	public GameObject mHasGetObj;

	private LocalSave.ImprintOne mData;

	private bool m_IsShowSlider;

	private bool m_IsShowStar;

	private bool m_IsShowMask;

	private bool m_IsShowRed;

	private bool m_IsShowInUI;

	private Action<LocalSave.ImprintOne> m_OnClick;

	public void Init(LocalSave.ImprintOne data, Action<LocalSave.ImprintOne> onClick, bool isShowSlider, bool isShowStar, bool isShowMask, bool isShowRed, bool isShowInUI)
	{
	}

	public void SetTotalAdd(float totalAdd)
	{
	}

	public void OnClick()
	{
	}

	private void Refresh()
	{
	}

	public void RefreshRedNode()
	{
	}

	public void ShowUpEffect(bool isShow)
	{
	}

	public void ShowHasGet(bool isShow)
	{
	}

	private void OnDestroy()
	{
	}

	public void DeInit()
	{
	}
}
