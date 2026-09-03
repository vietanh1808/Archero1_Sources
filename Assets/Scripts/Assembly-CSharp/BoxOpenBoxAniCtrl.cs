using UnityEngine;
using UnityEngine.UI;

public class BoxOpenBoxAniCtrl : MonoBehaviour
{
	public enum BoxState
	{
		BoxOpenOpen = 101,
		BoxOpenStand = 102,
		BoxOpenShow = 103
	}

	public const string BoxAni_Open = "BoxOpenOpen";

	public const string BoxAni_Stand = "BoxOpenStand";

	public const string BoxAni_Show = "BoxOpenShow";

	public const string BoxAni_Shock = "shock";

	public Image Image_Down;

	public DxxImage Image_Shadow;

	public Animator Ani_Box;

	public GameObject effect_light;

	public GameObject effect_open;

	public GameObject boxshowing_normal;

	public GameObject boxshowone_normal;

	public GameObject boxshowing_large;

	public GameObject boxshowone_large;

	public RectTransform child_box;

	public RectTransform child_box2d;

	private Vector2 boxstartpos;

	private Vector2 child_boxpos;

	private Vector2 child_box2dpos;

	private RectTransform mRectTransform;

	private LocalSave.TimeBoxType mBoxType;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void Play(BoxState state, LocalSave.TimeBoxType type)
	{
	}

	public void Play(string str)
	{
	}

	public void ShowOpenEffect(bool value)
	{
	}

	public void ShowBoxOpeningEffect(bool value)
	{
	}

	public void ShowBoxOneEffect(bool value)
	{
	}
}
