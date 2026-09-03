using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleAchieveUICtrl : MediatorCtrlBase
{
	public ScrollRectBase mScrollRect;

	public GridLayoutGroup mGrid;

	public GameObject copyitems;

	public GameObject copyachieve;

	public ButtonCtrl Button_Close;

	private List<BattleAchieveOneCtrl> mList;

	private LocalUnityObjctPool mPool;

	public override void OnLanguageChange()
	{
	}
}
