using System.Collections.Generic;
using UnityEngine;

public class EnhanceScrollView : MonoBehaviour
{
	public AnimationCurve scaleCurve;

	public AnimationCurve positionCurve;

	public AnimationCurve depthCurve;

	public GameObject copyItem;

	public GameObject ItemCache;

	private LocalUnityObjctPool ItemPool;

	[Tooltip("The Start center index")]
	public int startCenterIndex;

	public float cellWidth;

	private float totalHorizontalWidth;

	public float yFixedPositionValue;

	public float lerpDuration;

	private float mCurrentDuration;

	private int mCenterIndex;

	public bool enableLerpTween;

	private EnhanceItem curCenterItem;

	private EnhanceItem preCenterItem;

	private bool canChangeItem;

	private float dFactor;

	private float originHorizontalValue;

	public float curHorizontalValue;

	private int depthFactor;

	public List<EnhanceItem> listEnhanceItems;

	private List<EnhanceItem> listSortedItems;

	protected List<object> m_datas;

	protected int m_nRenderCnt;

	protected int m_nStartIndex;

	public float factor;

	public EnhanceItem CurCenterItem => null;

	public void EnableDrag(bool isEnabled)
	{
	}

	private void Awake()
	{
	}

	public void Refresh(List<object> datas, int nStartIndex = 0, int nRenderCnt = 3)
	{
	}

	protected virtual void LerpTweenToTarget(float originValue, float targetValue, bool needTween = false, bool Initial = false)
	{
	}

	public void DisableLerpTween()
	{
	}

	public void UpdateEnhanceScrollView(float fValue)
	{
	}

	private void Update()
	{
	}

	private void TweenViewToTarget()
	{
	}

	private void OnTweenOver()
	{
	}

	protected virtual void OnSelectedItem(object data, int index)
	{
	}

	private float GetScaleValue(float sliderValue, float added)
	{
		return 0f;
	}

	private float GetXPosValue(float sliderValue, float added)
	{
		return 0f;
	}

	private int GetMoveCurveFactorCount(EnhanceItem preCenterItem, EnhanceItem newCenterItem)
	{
		return 0;
	}

	public static int SortPosition(EnhanceItem a, EnhanceItem b)
	{
		return 0;
	}

	private void SortEnhanceItem()
	{
	}

	protected virtual void OnSortEnhanceItem()
	{
	}

	public void SetHorizontalTargetItemIndex(EnhanceItem selectItem)
	{
	}

	public void OnBtnRightClick()
	{
	}

	public void OnBtnLeftClick()
	{
	}

	public void OnDragEnhanceViewMove(Vector2 delta)
	{
	}

	public void OnDragEnhanceViewEnd()
	{
	}

	private int CalCurCenterIndex()
	{
		return 0;
	}

	private (object, int) GetDataByIndex(int lastIndex, int curIndex, int index)
	{
		return default;
	}

	public void Close()
	{
	}

	protected virtual void OnClose()
	{
	}
}
