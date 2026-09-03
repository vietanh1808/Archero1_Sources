using UnityEngine;
using UnityEngine.UI;

public class HeadItem : MonoBehaviour
{
	public Image face;

	public Image circle;

	private int headId;

	private int headFrameId;

	private GameObject _effect;

	public Image VIP_BG;

	public DxxText VIP_Lv;

	public bool VIP_show;

	public bool VIP_click;

	public GameObject Effect => null;

	public void Init(int headId, int headFrameId)
	{
	}

	public void resetHead(int headId)
	{
	}

	public void resetHeadFrame(int headFrameId)
	{
	}

	public void setVIPInfo(int lv, bool click, bool show)
	{
	}

	public void onButtonClick()
	{
	}

	public void Close()
	{
	}
}
