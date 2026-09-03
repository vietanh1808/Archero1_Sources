using System;
using TableTool;
using UnityEngine;

public class Act6thDrillTreasureCardItem : MonoBehaviour
{
	[SerializeField]
	private RectTransform tran_CardBack;

	[SerializeField]
	private RectTransform tran_CardFront;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private ButtonCtrl btn_CardBack;

	public int index;

	private Vector3 ro_End;

	private float ro_Time;

	private Action<bool> specialCallBack;

	private Act6thDrillTreasureMgr DMgr => null;

	public void OnInit(Action<bool> sCallback)
	{
	}

	public void OnBtnCardClick()
	{
	}

	public void PlayCardAni(bool isSpecial, Drop_DropModel.DropData rData, int addHeight, bool isAuto = false)
	{
	}

	public void InItProp()
	{
	}

	public void OnHeightComplete(bool isRestart = false, bool isAuto = false)
	{
	}
}
