using UIKit;
using UnityEngine.UI;

public class MsgItemBase : UITableViewCell
{
	protected ScrollRect _scrollRect;

	public void init(ChatMsgDataBase data, ScrollRect scrollRect)
	{
	}

	protected virtual void OnInit(ChatMsgDataBase data)
	{
	}

	private void Update()
	{
	}

	protected virtual void OnUpdate()
	{
	}
}
