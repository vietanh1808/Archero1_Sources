using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIPopClose : MonoBehaviour
{
	[SerializeField]
	private GameObject obj;

	public GraphicRaycaster RaycastInCanvas;

	private bool isCheck;

	private EventSystem eventSystem;

	public Action OnClose;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Check()
	{
	}
}
