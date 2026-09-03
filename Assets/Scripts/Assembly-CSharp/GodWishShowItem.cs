using DG.Tweening;
using Spine;
using UnityEngine;
using UnityEngine.UI;

public class GodWishShowItem : MonoBehaviour
{
	public Sprite[] icon;

	public Image God;

	[HideInInspector]
	public bool isAni;

	private Sequence seq;

	public void Awake()
	{
	}

	private void Init()
	{
	}

	public void Play(int godId, bool ani = false)
	{
	}

	private void Complete(TrackEntry trackEntry)
	{
	}

	private void SpineEvent(TrackEntry trackEntry, Spine.Event e)
	{
	}

	public void closeGod()
	{
	}
}
