using System;

[Flags]
public enum CampTileOpenCond
{
	None = 0,
	TimeStatus = 1,
	LockStatus = 2,
	OccupyStatus = 4,
	OperationStatus = 8
}
