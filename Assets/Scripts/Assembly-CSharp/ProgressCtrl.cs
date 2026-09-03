using UnityEngine;

public class ProgressCtrl : MonoBehaviour
{
	public enum ProgressDirection
	{
		LeftToRight = 0
	}

	public ProgressDirection direction;

	private RectTransform fill;

	private RectTransform tran;

	private float width;

	private float height;

	private float _Value;

	public float Value
	{
		get
		{
			return 0f;
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

	public void SetFillSprite(Sprite spr)
	{
	}

	private void InitFill()
	{
	}

	private void RefreshSize()
	{
	}

	public void SetFillX(float w)
	{
	}

	protected void UpdateFill()
	{
	}
}
