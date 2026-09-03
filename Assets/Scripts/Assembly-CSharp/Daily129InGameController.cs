using System.Collections.Generic;
using Daily129;
using Dxx.Util;
using UnityEngine;

public class Daily129InGameController
{
	private const int IntegralAdd = 10;

	private long _lMaxHp;

	private long _lCurrentHp;

	private float _fIntegralRatio;

	private int _fCurIntegral;

	private int _nGrandTotalCoin;

	private int _nGrandTotalCostCoin;

	private int _nCoin;

	private Daily129TowerController _daily129TowerController;

	private SequencePool mSeqPool;

	private bool _bIsWin;

	private GameObject _objGuide;

	public long MaxHp => 0L;

	public long CurHp => 0L;

	public int CurIntegral => 0;

	public int GrandTotalCoin => 0;

	public int GrandTotalCostCoin => 0;

	public int CurCoin
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsWin
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Daily129InGameController Init()
	{
		return null;
	}

	public void SetDailyTowerController(Daily129TowerController controller)
	{
	}

	public void DeInit()
	{
	}

	public List<float> GetSpeeds()
	{
		return null;
	}

	public void OnHitted(EntityBase entity, long value)
	{
	}

	private void ShowGameOverUI()
	{
	}

	public void OnKill(EntityBase entity)
	{
	}

	public void CostCoin(int coin)
	{
	}

	public int GetSuperSkill()
	{
		return 0;
	}

	private void CreateGuide()
	{
	}

	private void CheckGuide()
	{
	}

	public void RemoveGuideObj()
	{
	}
}
