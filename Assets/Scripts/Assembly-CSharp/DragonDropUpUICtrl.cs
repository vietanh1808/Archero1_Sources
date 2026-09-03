using System;
using UnityEngine;
using UnityEngine.UI;

public class DragonDropUpUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtDesc;

	[SerializeField]
	private DxxText txtCountdown;

	[SerializeField]
	private DxxText txtGuarantee;

	[SerializeField]
	private DxxText txtDescGuarantee;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnBg;

	[SerializeField]
	private ScrollRect sr;

	[SerializeField]
	private GameObject template;

	private LocalUnityObjctPool pool;

	private int UpType;

	private int[] chestType;

	private Func<bool>[] isOpen;

	private Func<long>[] endTime;

	private Func<int[][]>[] UPshow;

	private Func<int>[] Rate;

	private Func<ushort>[] UpCount;

	private string[] Langauage1;

	private string[] Langauage2;

	private string[] Langauage3;

	private string[] Langauage4;

	private void android_escape()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
