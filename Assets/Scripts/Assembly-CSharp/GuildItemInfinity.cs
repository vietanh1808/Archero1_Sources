using System;
using UnityEngine.EventSystems;

public class GuildItemInfinity : InfinityBase<GuildItem>, IEndDragHandler, IEventSystemHandler
{
	public float flipPageDelta;

	public Action<int> onEndDrag;

	public void OnEndDrag(PointerEventData eventData)
	{
	}
}
