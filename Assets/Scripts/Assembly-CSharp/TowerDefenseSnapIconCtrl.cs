using UnityEngine;

public class TowerDefenseSnapIconCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private DxxImage imgCountDown;

	[SerializeField]
	private GameObject goTip;

	private Vector3 position;

	private RectTransform _container;

	private RectTransform _thisRectTransform;

	private Camera sceneCamera;

	private Camera uiCamera;

	private float timeLeft;

	private float timeMax;

	private float scale;

	private float widthHalfContainerCalibrated;

	private float heightHalfContainerCalibrated;

	private Vector2 lastScreenPoint;

	private Vector2 lastLocalPoint;

	public int id { get; private set; }

	private RectTransform container => null;

	private RectTransform thisRectTransform => null;

	public DxxImage GetIcon()
	{
		return null;
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void SetData(int id, Vector3 position, float countDown, bool hasBoss)
	{
	}

	private void Update()
	{
	}

	private void UpdatePosition()
	{
	}

	private void UpdateCountDown()
	{
	}
}
