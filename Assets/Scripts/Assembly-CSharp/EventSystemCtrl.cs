using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemCtrl : MonoBehaviour
{
	public static EventSystemCtrl Instance;

	private EventSystem mEventSystem;

	private int defaultDragThreshold;

	private bool bEnable;

	private void Start()
	{
	}

	public void SetDragEnable(bool value)
	{
	}
}
