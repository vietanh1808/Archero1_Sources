using System;

[Flags]
public enum SailingShipEntityStatus
{
	None = 0,
	Fire = 1,
	Injured = 2,
	Charging = 4,
	Repairing = 8,
	Destroy = 0x10,
	BeHit = 0x20
}
