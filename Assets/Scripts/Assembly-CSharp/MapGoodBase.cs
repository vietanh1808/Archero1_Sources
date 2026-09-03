using UnityEngine;

public class MapGoodBase : MonoBehaviour
{
	private Vector2Int _xy;

	public object[] args;

	public int GoodId { get; set; }

	public Vector2Int XY
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public object[] Args
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public virtual void Init()
	{
	}
}
