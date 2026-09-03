using System;

[Flags]
public enum CampTalentLineDir
{
	None = 0,
	Top = 1,
	Bottom = 2,
	Left = 4,
	Right = 8,
	LeftTop = 0x10,
	LeftBottom = 0x20,
	RightTop = 0x40,
	RightBottom = 0x80
}
