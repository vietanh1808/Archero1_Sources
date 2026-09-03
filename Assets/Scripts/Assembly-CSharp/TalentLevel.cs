using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class TalentLevel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Tips;

	public ButtonCtrl Button_Level;

	public DxxText Text_Upgrade;

	public DxxText Text_Count;

	public GameObject MaxLevel;

	public GameObject Icon32;

	public GameObject Icon33;

	public GameObject Icon34;

	public RectTransform TextContainer;

	public GameObject cpText;

	public RectTransform RTF_BG;

	private int tid;

	private int needType;

	private int needCount;

	private List<DxxText> effText;

	private int sdkSoul;

	private int sdkSoulBig;

	private int sdkSuperSoul;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	public void init(int tid)
	{
	}

	private void onButtonLevel()
	{
	}

	public void updateLevel()
	{
	}

	public void PlayLevelUp(DxxText item)
	{
	}

	private string GetEffectDesc(PVEtalent_node b, int level, string effect)
	{
		return null;
	}

	private void checkButtonState(PVEtalent_node b, int level)
	{
	}

	public void onButtonClosed()
	{
	}
}
