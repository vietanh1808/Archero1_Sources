using UnityEngine;

public class BulletRedLineCtrl : MonoBehaviour
{
	public SpriteRenderer line1;

	public SpriteRenderer line2;

	private float line1height;

	private float line2height;

	private float old_line1height;

	private float old_line2height;

	[HideInInspector]
	public Vector3 StartPos { get; set; }

	[HideInInspector]
	public Vector3 EndPos { get; set; }

	private void Awake()
	{
	}

	public void ResetLineHeight()
	{
	}

	public void CustomizeLineHeight(float value)
	{
	}

	public void SetLine(bool islast, float length)
	{
	}

	public void UpdateLine(bool throughinsidewall, float width)
	{
	}

	private float getMinDis(bool throughinsidewall, float width)
	{
		return 0f;
	}

	public void UpdateLine(bool throughinsidewall, float width, float lossyScale)
	{
	}

	public void PlayLineWidth(float start, float end, float time)
	{
	}

	public void PlayLineWidth()
	{
	}

	public void PlayLineWidth(float time)
	{
	}
}
