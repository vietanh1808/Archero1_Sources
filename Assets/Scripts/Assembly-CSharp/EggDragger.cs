using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EggDragger : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Header("是否精准拖拽")]
	public bool m_isPrecision;

	private Vector3 m_offset;

	private RectTransform m_rt;

	public EggIcon item;

	public GameObject from;

	public Image[] to;

	public GameObject panel;

	private void Start()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void SetDraggedPosition(PointerEventData eventData)
	{
	}

	public void checkCollider(Vector3 v)
	{
	}

	public void handleCollider(int index)
	{
	}
}
