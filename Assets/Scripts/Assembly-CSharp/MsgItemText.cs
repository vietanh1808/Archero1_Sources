using UnityEngine;
using UnityEngine.UI;

public class MsgItemText : MsgItemBaseWithLRHeadItem
{
	public RectTransform PanelRTF;

	public Image BG;

	public DxxText Text_Time;

	public DxxText Text_Content;

	public DxxText Text_LGrade;

	public DxxText Text_RGrade;

	public DxxText Text_LName;

	public DxxText Text_RName;

	protected override void OnInit(ChatMsgDataBase d)
	{
	}
}
