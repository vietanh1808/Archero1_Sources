using System;
using UnityEngine;

public class EmojiOneCtrl : MonoBehaviour
{
	public GameObject Image_face;

	public GameObject Image_mask;

	public GameObject Image_focus;

	public GameObject locker;

	public ButtonCtrl button;

	public RedNodeCtrl redNodeCtrl;

	public Action<HeadBoxOne> OnButtonClick;

	private bool haveRed;

	private void Awake()
	{
	}

	private void OnInit()
	{
	}
}
