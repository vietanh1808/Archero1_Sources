using UnityEngine;

public class ViewCell : MonoBehaviour
{
	[HideInInspector]
	public ViewCellData mData;

	public RectTransform cellRect;

	[HideInInspector]
	public bool isUsed;

	public void Init()
	{
	}

	protected virtual void OnInit()
	{
	}

	public void Refresh(ViewCellData data)
	{
	}

	protected virtual void OnRefresh()
	{
	}

	public void Recycle()
	{
	}

	protected virtual void OnRecycle()
	{
	}

	public virtual float GetHight()
	{
		return 0f;
	}

	public virtual float GetWight()
	{
		return 0f;
	}
}
