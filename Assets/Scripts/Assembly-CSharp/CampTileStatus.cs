using System;

[Flags]
public enum CampTileStatus
{
	None = 0,
	UnOpen = 1,
	Open = 2,
	Close = 4,
	SelfCampUnLock = 8,
	Occupying = 0x10,
	Occupied = 0x20
}
