using System;
using System.Text.RegularExpressions;
using Habby.Model;
using UnityEngine;
using UnityEngine.UI;

public class HabbyMailOneCtrl : MonoBehaviour
{
	public DxxText Text_Name;

	public DxxText Text_Info;

	public DxxText Text_Time;

	public DxxText Text_New;

	public DxxText Text_ExpireTime;

	public DxxText Text_ExpireTime2;

	public RedNodeCtrl m_RedCtrl;

	public ButtonCtrl Button_Open;

	public CanvasGroup mCanvasGroup;

	public ContentSizeFitter InfoFitter;

	public Action<int, HabbyMailOneCtrl> OnClickButton;

	public GameObject MaskGray;

	private MailData mData;

	private int mIndex;

	private Regex reg;

	private void Awake()
	{
	}

	public void Init(int index, MailData data)
	{
	}

	private string CheckContent(string content)
	{
		return null;
	}

	public void UpdateMail()
	{
	}

	public void SetRedShow(bool value)
	{
	}

	private string GetEndTimeStrings()
	{
		return null;
	}
}
