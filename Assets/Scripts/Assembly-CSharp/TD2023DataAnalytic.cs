using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class TD2023DataAnalytic
{
	private string Tower_2023;

	private int chapter;

	private int layer;

	private string result;

	public ObscuredLong TD_MaxHP;

	public ObscuredLong TD_MaxAtk;

	public ObscuredLong TD_MaxToken;

	public ObscuredLong TD_CostToken;

	public ObscuredInt TD_HurtNum;

	public ObscuredLong TD_HP;

	public ObscuredLong TD_Atk;

	public ObscuredInt TD_Level;

	public ObscuredLong TD_BaseHP;

	public ObscuredInt TD_TowerNum;

	public ObscuredInt TD_TowerNum1;

	public string TD_TowerInfos;

	public ObscuredString TD_DropInfos;

	private int timerId;

	private string timerName;

	private const string SUCCESS = "success";

	private const string FAIL = "fail";

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onTimer()
	{
	}

	public void PopulatePro(Dictionary<string, object> pro)
	{
	}

	public void RefreshTD_MaxToken(long curTDCoin)
	{
	}

	public void RefreshTD_MaxAtk(long curAttack)
	{
	}

	public void UpdateTD_CostToken(int delta)
	{
	}

	public void RefreshTD_MaxHP(long curMaxHP)
	{
	}

	public void InitValues()
	{
	}

	public void SaveValuesOnWaveFinished()
	{
	}

	private bool isWin()
	{
		return false;
	}

	public void SaveValuesOnGameEnd()
	{
	}

	private void onChangHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private string getTowerInfos()
	{
		return null;
	}
}
