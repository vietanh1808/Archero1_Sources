using System;
using DG.Tweening;
using UnityEngine;

public class MainUIBattleLayerCtrl : MonoBehaviour
{
	public const string BoxAniString = "BoxChestRotating";

	public DxxText Text_Stage;

	public CurrencyExpCtrl mExpCtrl;

	public ButtonCtrl Button_Layer;

	public RedNodeCtrl mRedCtrl;

	public RectTransform BoxTran;

	public Animation BoxAni;

	public DxxText Text_StageCount;

	public Action OnLayerClick;

	private bool bEnable;

	private int mMax;

	private Sequence seq;

	private GameMode mode;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetLayer(int current, int max, GameMode mode)
	{
	}

	private void UpdateStageCount()
	{
	}

	public void UpdateNet()
	{
	}

	public void OnLanguageChange()
	{
	}
}
