using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeContractUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText m_textTitle;

	[SerializeField]
	private DxxText m_textLv;

	[SerializeField]
	private Text m_textContent;

	[SerializeField]
	private ScrollRect m_scrollviewContract;

	[SerializeField]
	private ContractItem ContractCopyOne;

	[SerializeField]
	private DxxText m_textDebuffTitle;

	[SerializeField]
	private ScrollRect m_scrollviewDebuff;

	[SerializeField]
	private DxxText m_textEmptyDebuff;

	[SerializeField]
	private ContractDebuffItem DebuffCopyOne;

	[SerializeField]
	private DxxText m_textGainTitle;

	[SerializeField]
	private ScrollRect m_scrollviewGain;

	[SerializeField]
	private DxxText m_textEmptyGain;

	[SerializeField]
	private ContractGainItem GainCopyOne;

	[SerializeField]
	private ButtonCtrl m_btnClose;

	[SerializeField]
	private ContractTips mContractTips;

	[SerializeField]
	private ContractDebuffTips mContractDebuffTips;

	private LocalUnityObjctPool mContractPool;

	private LocalUnityObjctPool mDebuffPool;

	private LocalUnityObjctPool mGainPool;

	private ContractItem m_selectItem;

	private ContractDebuffItem m_selectDebuffItem;

	private List<int> m_listSelectIds;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	private void OnSelectContract(Daily_HeroDefenceChallenge data)
	{
	}

	private void UpdateContent()
	{
	}

	private void OnClickContract(ContractItem item)
	{
	}

	private void OnClickContractDebuffItem(ContractDebuffItem item)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void UpdateLevel()
	{
	}
}
