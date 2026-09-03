using Habby.Guild.Data;
using UnityEngine;

public class GuildEntrance : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public GameObject effect;

	public DxxText txt_Name;

	private bool canclick;

	private bool clicking;

	private void Awake()
	{
	}

	private void OnClickBtn()
	{
	}

	private void OnHaveGuild(GetMyTeamRespose response)
	{
	}

	private void GoCacheAll()
	{
	}

	private void OnCachedInfo(int code)
	{
	}

	private void OnNotHaveGuild(GetMyTeamRespose resposeData)
	{
	}

	public void Open()
	{
	}

	private void Show(bool value)
	{
	}

	public new void UpdateUI()
	{
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	public override bool IsShow()
	{
		return false;
	}

	public override bool isRed()
	{
		return false;
	}

	public override void OnLanguageChange()
	{
	}
}
