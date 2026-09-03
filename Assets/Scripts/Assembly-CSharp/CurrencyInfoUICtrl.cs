using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyInfoUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private UILineCtrlOne m_textTitle;

	[SerializeField]
	private GameObject m_numParent;

	[SerializeField]
	private DxxText m_textNumPre;

	[SerializeField]
	private DxxText m_textNum;

	[SerializeField]
	private DxxText m_textContent;

	[SerializeField]
	private RectTransform m_rtIconParent;

	[SerializeField]
	private ButtonCtrl m_btnClose;

	[SerializeField]
	private ButtonCtrl m_btnMask;

	[Header("概率展示")]
	[SerializeField]
	private ButtonCtrl m_btnTips;

	[SerializeField]
	private GameObject m_goProbabilityShow;

	[SerializeField]
	private RectTransform m_rectScrollParent;

	[SerializeField]
	private RectTransform m_rectBgParent;

	[SerializeField]
	private BoxProbabilityShowDropItem m_proDropItem;

	[SerializeField]
	private ScrollRect m_scroll;

	private CurrencyInfoProxy.Transfer m_transfer;

	private LocalUnityObjctPool mPool;

	private List<Probability_RandomItem> randomProList;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void RefreshBtnTipsShow()
	{
	}

	public void OnBtnTipsClick()
	{
	}

	private void LoadProbabilityDrop()
	{
	}
}
