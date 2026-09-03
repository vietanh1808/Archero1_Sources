using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UIElements;
using XLua;

public class MiningPlay : MonoBehaviour
{
	[SerializeField]
	private ScrollView scroll;

	[SerializeField]
	private RectTransform content;

	[SerializeField]
	private RectTransform line;

	[SerializeField]
	private DxxText text_Meter;

	[SerializeField]
	private MiningItemCell miningItem;

	[SerializeField]
	private SkeletonGraphic drill;

	[SerializeField]
	private SkeletonGraphic mattock;

	[SerializeField]
	private RectTransform scrow;

	private List<MiningBlockShowData> mapData;

	private List<MiningItemCell> mapCells;

	private LocalUnityObjctPool pool;

	private const float MoveBaseSpeed = 0.3f;

	private int sumLine;

	private Action bigBoxAction;

	private List<GameObject> unusedCells;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_InitCell;

	private static DelegateBridge __Hotfix0_MoveLine;

	private static DelegateBridge __Hotfix0_MoveDownTheMap;

	private static DelegateBridge __Hotfix0_Move;

	private static DelegateBridge __Hotfix0_RefreshMap;

	private static DelegateBridge __Hotfix0_ReadUseProp;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_CheckCellIsPassState;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge _c__Hotfix0_ctor;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void OnOpen()
	{
	}

	public void InitCell()
	{
	}

	public void MoveLine()
	{
	}

	public void MoveDownTheMap()
	{
	}

	public void Move()
	{
	}

	public void RefreshMap()
	{
	}

	private void ReadUseProp(MiningBlockShowData bd)
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private bool CheckCellIsPassState(MiningBlockShowData data)
	{
		return false;
	}

	public void OnClose()
	{
	}
}
