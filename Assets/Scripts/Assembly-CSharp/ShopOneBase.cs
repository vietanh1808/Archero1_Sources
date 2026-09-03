using UnityEngine;

public abstract class ShopOneBase : MonoBehaviour
{
	private RectTransform _rectt;

	public RectTransform mRectTransform => null;

	private void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}

	public void Init()
	{
	}

	protected abstract void OnInit();

	public void Deinit()
	{
	}

	protected abstract void OnDeinit();

	public abstract void OnLanguageChange();

	public abstract void UpdateNet();

	public virtual void UpdateUI()
	{
	}

	public virtual void RefreshBoxStateByRelics()
	{
	}
}
