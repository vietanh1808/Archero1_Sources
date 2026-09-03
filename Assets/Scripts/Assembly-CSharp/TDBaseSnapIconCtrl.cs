using DG.Tweening;
using UnityEngine;

public class TDBaseSnapIconCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private DxxImage imgIconBase;

	[SerializeField]
	private GameObject goTip;

	private Vector3 position;

	private RectTransform _container;

	private RectTransform _thisRectTransform;

	private Camera sceneCamera;

	private Camera uiCamera;

	private float timeMax;

	private float scale;

	private float widthHalfContainerCalibrated;

	private float heightHalfContainerCalibrated;

	private Sequence sequence;

	private const float animTime = 0.3f;

	private Vector2 lastScreenPoint;

	private Vector2 lastLocalPoint;

	private RectTransform container => null;

	private RectTransform thisRectTransform => null;

	public DxxImage GetIcon()
	{
		return null;
	}

	public void Show()
	{
	}

	public void DeInit()
	{
	}

	public void Hide()
	{
	}

	public void SetData(Vector3 position)
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public void ShowAnim()
	{
	}

	private void ResetImgIcon()
	{
	}

	private void Update()
	{
	}

	private void UpdatePosition()
	{
	}
}
