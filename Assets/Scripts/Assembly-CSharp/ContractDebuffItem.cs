using System;
using UnityEngine;
using UnityEngine.UI;

public class ContractDebuffItem : ButtonCtrl
{
	[SerializeField]
	private Text m_textDebuff;

	[SerializeField]
	private Image m_imgIcon;

	private string m_strId;

	private int m_nValue;

	public void Init(string id, int value, Action<ContractDebuffItem> OnClickAction)
	{
	}

	public string GetLanguageString()
	{
		return null;
	}
}
