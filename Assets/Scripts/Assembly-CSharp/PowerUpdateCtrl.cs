using UnityEngine;

public class PowerUpdateCtrl : MonoBehaviour
{
	public RectTransform child;

	public RectTransform image_bg;

	public DxxText Text_Value;

	public DxxText Text_Change;

	private float change_y_init;

	private int m_before;

	private int m_after;

	private int m_current;

	private static Color color_add;

	private static Color color_reduce;

	private void Awake()
	{
	}

	public void Init(int before, int after)
	{
	}

	private void SetTextValue(int value)
	{
	}

	private void PlayAnimation()
	{
	}
}
