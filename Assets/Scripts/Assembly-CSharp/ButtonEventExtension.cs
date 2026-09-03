using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ButtonEventExtension : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
	public bool canDouble;

	public float pressDurationTime;

	public bool PressHandleOnce;

	public float doubleClickIntervalTime;

	public UnityEvent onClick;

	public UnityEvent onDoubleClick;

	public UnityEvent onPress;

	public UnityEvent onPressCancel;

	private bool isDown;

	private bool isPress;

	private float downTime;

	private bool isUp;

	private float clickIntervalTime;

	private int clickTimes;

	private void Update()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
