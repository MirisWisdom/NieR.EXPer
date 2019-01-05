# Profile Save Slot

NieR:Automata saves the player's progress to three save slots of their choice,
numbered 0 to 2. The slots are located in `%PERSONAL%\My Games\NieR_Automata`,
with the following names:

- `SlotData_0.dat`
- `SlotData_1.dat`
- `SlotData_2.dat`

As mentioned in the [Experience Points & Levels](level.md) documentation, the
level is inferred from the EXP. Rather than the level being saved in the slot,
it's the current EXP value that's saved:

| Offset    | Variable Type    |
| --------- | ---------------- |
| `0x3871C` | Unsigned integer |

Upon patching, the library backs up the save slot and then patches it. Backing
up is done by copying the selected save slot to the following destination:

| Base Directory                      | Backup Directory | Backup Subdirectory |
| ----------------------------------- | ---------------- | ------------------- |
| `%PERSONAL%\My Games\NieR_Automata` | `NieR.EXPer`     | `<GUID Value>`      |