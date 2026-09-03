using System;
using TableTool;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TetrisItem : UIBehaviour
{
	private GraphicRaycaster _rayCaster;

	private EventSystem _eventSystem;

	private PointerEventData _eventData;

	private Daily_BagWeaponConfig config;

	private Canvas _canvas;

	public int RowIndex;

	public int ColumIndex;

	public TetrisCommon.UnitType ItemType;

	[NonSerialized]
	private RectTransform m_Rect;

	public GraphicRaycaster RayCaster => null;

	protected RectTransform rectTransform => null;

	public void InitComponent(GraphicRaycaster caster)
	{
	}

	private new void Start()
	{
	}

	public bool CheckCanDeploy(out TetrisPackItem packItem, ref int occupyId, ref int configId)
	{
		packItem = null;
		return false;
	}
}
