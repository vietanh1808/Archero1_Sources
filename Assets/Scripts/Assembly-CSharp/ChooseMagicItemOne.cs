using System;
using UnityEngine;
using UnityEngine.UI;

public class ChooseMagicItemOne : MonoBehaviour
{
	[SerializeField]
	private Image m_imgIcon;

	[SerializeField]
	private DxxText m_textName;

	[SerializeField]
	private DxxText m_textDesc;

	[SerializeField]
	private ButtonCtrl m_btnSelect;

	[SerializeField]
	private DxxText m_textBtn;

	private Action<int> OnSelectAction;

	public void Init(int id, Action<int> onSelect)
	{
	}
}
