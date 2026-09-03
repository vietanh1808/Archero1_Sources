using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class SailingMapEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	private Vector2 begin;

	[CompilerGenerated]
	private Action<Vector2> m_HandlerClick;

	[CompilerGenerated]
	private Action<Vector2> m_HandlerDragBegin;

	[CompilerGenerated]
	private Action<Vector2> m_HandlerDrag;

	[CompilerGenerated]
	private Action<Vector2> m_HandlerDragEnd;

	public event Action<Vector2> HandlerClick
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Vector2> HandlerDragBegin
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Vector2> HandlerDrag
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Vector2> HandlerDragEnd
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void handleOffset(PointerEventData eventData)
	{
	}

	private void handleClick(Vector2 v2)
	{
	}
}
