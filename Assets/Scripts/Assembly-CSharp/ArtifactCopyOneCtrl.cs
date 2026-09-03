using System;
using UnityEngine;

public class ArtifactCopyOneCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText _textName;

	private int _id;

	public int ID => 0;

	public void Init(int id, PropOneEquip equipOne, Action<ArtifactCopyOneCtrl> onClick)
	{
	}
}
