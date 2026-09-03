using UnityEngine;
using UnityEngine.EventSystems;

public class TetrisPackItem : UIBehaviour
{
	private Color curShowColor;

	public TetrisCommon.UnitType ItemType;

	private DxxImage backImg;

	private EmptyGraphic emptyGraphic;

	public TetrisUnitConfig config;

	public int RowIndex;

	public int ColumIndex;

	public int OccupiedUnitId;

	private new void Awake()
	{
	}

	public void Init(TetrisUnitConfig config)
	{
	}

	public void SetGrapic(EmptyGraphic graphic)
	{
	}

	public void EnableGraphic(bool isActive)
	{
	}

	public bool IsEmpty()
	{
		return false;
	}

	public bool IsOccupied()
	{
		return false;
	}

	public void SetIndex(int rowIndex, int columIndex)
	{
	}

	public void SetImageColor(Color color)
	{
	}

	public void SetImage(string name)
	{
	}
}
