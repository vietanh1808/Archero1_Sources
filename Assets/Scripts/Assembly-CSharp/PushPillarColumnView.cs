using DG.Tweening;
using UnityEngine;

public class PushPillarColumnView : MonoBehaviour
{
	private const int ROW_COUNT = 6;

	public PushPillarGridItem[] gridItems;

	public PushPillarPillarItem pillar;

	public Transform dropTarget;

	public RectTransform gridContainer;

	private int columnIndex;

	private const float PILLAR_TOP_Y = 561f;

	private const float PILLAR_BOTTOM_Y = 0f;

	private float perGridY;

	private RectTransform pillarRect;

	private float gridContainerInitY;

	private Sequence pushSequence;

	public float PerGridY => 0f;

	public void Init(int columnIndex)
	{
	}

	public void SetGridData(int row, PushPillarGridData data)
	{
	}

	public void SetPillarPosition(int position)
	{
	}

	public void PlayPushDown(float pushDownDist, float pushTime, float bounceTime)
	{
	}

	public void PlayGridDrop(int row, float duration)
	{
	}

	private float CalcGridHeight()
	{
		return 0f;
	}

	public void SetPillarPositionOnly(int position)
	{
	}

	public void ResetGridContainerPosition()
	{
	}

	public void AnimatePillarToPosition(int targetPosition, float duration)
	{
	}

	private void KillPushSequence()
	{
	}

	private void OnDestroy()
	{
	}
}
