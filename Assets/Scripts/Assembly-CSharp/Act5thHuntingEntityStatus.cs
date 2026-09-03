using System;

[Flags]
public enum Act5thHuntingEntityStatus
{
	None = 0,
	ReadyCreate = 1,
	Create = 2,
	TriggerWall = 4,
	TriggerEntity = 8,
	Move = 0x10,
	Urgency = 0x20,
	Recycle = 0x40,
	Dead = 0x80
}
