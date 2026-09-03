using System;
using System.Text.RegularExpressions;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class MailOneCtrl : MonoBehaviour
{
	public DxxText Text_Name;

	public DxxText Text_Info;

	public DxxText Text_Time;

	public DxxText Text_New;

	public RedNodeCtrl m_RedCtrl;

	public ButtonCtrl Button_Open;

	public CanvasGroup mCanvasGroup;

	public ContentSizeFitter InfoFitter;

	public Action<int, MailOneCtrl> OnClickButton;

	private CMailInfo mData;

	private int mIndex;

	private Regex reg;

	private void Awake()
	{
	}

	public void Init(int index, CMailInfo data)
	{
	}

	public void UpdateMail()
	{
	}

	public void SetRedShow(bool value)
	{
	}
}
