using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ContractTips : MonoBehaviour
{
	[SerializeField]
	private DxxText m_textChallengePre;

	[SerializeField]
	private DxxText m_textChallenge;

	[SerializeField]
	private DxxText m_textAwardPre;

	[SerializeField]
	private DxxText m_textAward;

	[SerializeField]
	private Image m_imgIcon;

	[SerializeField]
	private ButtonCtrl m_btnActive;

	[SerializeField]
	private ButtonCtrl m_btnCancel;

	[SerializeField]
	private DxxText m_textActive;

	[SerializeField]
	private DxxText m_textCancel;

	[SerializeField]
	private Image m_imgArrow;

	private Daily_HeroDefenceChallenge m_data;

	private Func<int, bool> GetSelectStateFunc;

	public void Init(Daily_HeroDefenceChallenge data, Vector3 pos, Func<int, bool> func, Action<Daily_HeroDefenceChallenge> OnClickAction)
	{
	}

	private void UpdateBtnState()
	{
	}

	public void OnLanguageChange()
	{
	}
}
