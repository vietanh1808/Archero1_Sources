using System;
using UnityEngine;

public class TotemRefineAttrItem : MonoBehaviour
{
	[SerializeField]
	private DxxImage rareIcon;

	[SerializeField]
	private DxxText attrText;

	[SerializeField]
	private ButtonCtrl lockButton;

	[SerializeField]
	private GameObject lockRoot;

	[SerializeField]
	private GameObject lockedState;

	[SerializeField]
	private GameObject unlockedState;

	public void Init(TotemAtt attr, bool isMain, bool showLock, bool canLock, bool isLocked, Action onLockClicked = null)
	{
	}
}
