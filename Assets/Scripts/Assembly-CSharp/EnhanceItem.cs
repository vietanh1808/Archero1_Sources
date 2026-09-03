using System;
using UnityEngine;
using UnityEngine.UI;

public class EnhanceItem : MonoBehaviour
{
	public delegate(object, int) GetDataDelegate(int curIndex, int lastIndex, int index);

	public Image image;

	private int curveOffSetIndex;

	private int curRealIndex;

	private int lastIndex;

	[SerializeField]
	private float dCurveCenterOffset;

	private Transform mTrs;

	protected object m_data;

	protected int m_nDataIndex;

	private Action<EnhanceItem> SetTarget;

	private GetDataDelegate GetDataFunc;

	public int CurveOffSetIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int RealIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int LastIndex
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public float CenterOffSet
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float xPos => 0f;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public virtual void UpdateScrollViewItems(float xValue, float depthCurveValue, int depthFactor, float itemCount, float yValue, float scaleValue)
	{
	}

	protected virtual void OnClickEnhanceItem()
	{
	}

	protected virtual void OnStart()
	{
	}

	protected virtual void OnAwake()
	{
	}

	protected virtual void SetItemDepth(float depthCurveValue, int depthFactor, float itemCount)
	{
	}

	public virtual void SetSelectState(bool isCenter)
	{
	}

	public void Init(int index, Action<EnhanceItem> setTarget, GetDataDelegate getDataFunc)
	{
	}

	protected virtual void OnInit()
	{
	}

	private void UpdateItemRender(bool change)
	{
	}

	protected virtual void OnUpdateItemRender()
	{
	}

	public (object, int) GetData()
	{
		return default;
	}

	public void Close()
	{
	}

	protected virtual void OnPreClose()
	{
	}

	protected virtual void OnClose()
	{
	}
}
