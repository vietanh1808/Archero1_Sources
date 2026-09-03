using GameProtocol;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class RedEnvelopeListItem : UITableViewCell
{
	public HeadItem headItem;

	public DxxText nameTex;

	public DxxText timeTex;

	public DxxText descTex;

	public Image redpackImg;

	public Image BgImg;

	public GameObject lightObj;

	public GameObject maskObj;

	public ButtonCtrl clickBtn;

	private CRedpacketInfo mData;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_Click;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void Refresh(CRedpacketInfo data)
	{
	}

	public void Click()
	{
	}
}
