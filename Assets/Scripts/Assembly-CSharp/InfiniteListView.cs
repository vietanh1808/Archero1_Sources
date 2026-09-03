using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollRect))]
public class InfiniteListView : MonoBehaviour
{
	public enum Direction
	{
		TopToBottom = 0,
		BottomToTop = 1,
		LeftToRight = 2,
		RightToLeft = 3
	}

	public ViewCell[] viewCellCopys;

	public RectTransform itemParent;

	public RectTransform view;

	public Direction listDir;

	public float Top;

	public float Bottom;

	private Dictionary<int, List<ViewCell>> viewCells;

	private Dictionary<ViewCellData, ViewCell> keyValuePairs;

	protected List<ViewCellData> curShowListDatas;

	protected Tween tween;

	protected ScrollRect scrollRect;

	public float size { get; private set; }

	public float viewSize { get; private set; }

	protected float pos => 0f;

	public void Init()
	{
	}

	protected virtual void OnInit()
	{
	}

	public void Open(List<ViewCellData> datas)
	{
	}

	public void Refresh(List<ViewCellData> datas)
	{
	}

	public void SetFirstShowToIndex(int index)
	{
	}

	public void ScollFirstShowToIndex(int index, float time)
	{
	}

	public void ScollFirstToPos(float pos, float time)
	{
	}

	public void SetFirstToPos(float pos)
	{
	}

	public void DisableScoll()
	{
	}

	public void EnableScoll()
	{
	}

	public void SetToFinal()
	{
	}

	public void ScollToFinal(float time)
	{
	}

	public void InitList()
	{
	}

	public virtual float GetCellInterval(ViewCellData data)
	{
		return 0f;
	}

	public void OnValueChange(Vector2 pos)
	{
	}

	public void Close()
	{
	}

	protected virtual void OnClose()
	{
	}

	private void RefreshList()
	{
	}

	private ViewCell GetViewCell(ViewCellData data)
	{
		return null;
	}

	private void RecycleViewCell(ViewCell cell)
	{
	}

	private void RecycleAll()
	{
	}
}
