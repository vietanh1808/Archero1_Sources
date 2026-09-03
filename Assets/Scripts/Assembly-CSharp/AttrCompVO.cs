using TableTool;
using UnityEngine;

public class AttrCompVO
{
	public DragonMagic_MagicAttributesIcon meta;

	public string AttrName;

	public long AttrValue;

	public bool mIsPercent;

	public int Order;

	public string Desc => null;

	public string KeyDesc => null;

	public Sprite AttrSprite => null;

	public string ValueDesc => null;

	public string ValueDescImprint => null;

	public AttrCompVO(string attrName, long attrValue, bool isPercent = false)
	{
	}
}
