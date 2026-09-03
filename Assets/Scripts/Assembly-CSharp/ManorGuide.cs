using UnityEngine;
using UnityEngine.UI;

public class ManorGuide : MonoBehaviour
{
	[SerializeField]
	private float leftX;

	[SerializeField]
	private float rightX;

	[SerializeField]
	private float upY;

	[SerializeField]
	private float downY;

	public RectTransform rectTran;

	public RectTransform Rect_BG;

	[SerializeField]
	private RectTransform guide_marked;

	[SerializeField]
	private RectTransform guide_marked_arrow;

	public RectTransform Rect_Building;

	public Image Image_Icon;

	public DxxText Text_Count;

	public ManorTouchHandler touchHandler;

	private Vector3 PointMarked;

	private bool isHavePointMarked;

	private void Start()
	{
	}

	public void init()
	{
	}

	private void Update()
	{
	}

	private void GuidePointMarked()
	{
	}

	public void GuidTarget(RectTransform guid, RectTransform arrow, Vector3 target)
	{
	}

	private Vector3 GetBuildingPos(int buildId)
	{
		return default;
	}

	public void onButtonGoTo()
	{
	}
}
