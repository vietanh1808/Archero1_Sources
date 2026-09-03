using UnityEngine;

public class RuneDexBlockCtrl : MonoBehaviour
{
	public DxxText title;

	public DxxText content;

	public RectTransform BgTrans;

	private RuneGroup data;

	private const int headHeight = 100;

	private const int bgExtraHeight = 10;

	private float totalHeight;

	public void SetData(RuneGroup data)
	{
	}

	public float GetHeight()
	{
		return 0f;
	}
}
