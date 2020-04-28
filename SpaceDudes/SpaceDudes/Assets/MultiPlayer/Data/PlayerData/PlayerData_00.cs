
using System.Collections.Generic;
using UnityEngine;

public class PlayerData_00 : BasePlayerData
{

    public PlayerData_00()
    {
        playerID = 0;
        name = "Kate";
        numUnits = 2;


        allUnitData = new List<UnitStruct>()
        {
            // can Climb walls, unitCombat Stats, starting Local loc
            new UnitStruct()
            {
                UnitModel = 0,
                UnitCanClimbWalls = true,
                UnitCombatStats = new int[2]{ 1, 4 }, // Rank, Movement
                UnitShipLoc = new Vector3Int(6, -2, 4),
                UnitRot = new Vector3Int(0, 90, 0),
            },

            new UnitStruct()
            {
                UnitModel = 0,
                UnitCanClimbWalls = true,
                UnitCombatStats = new int[2]{ 0, 4 },
                UnitShipLoc = new Vector3Int(4, -2, 6),
                UnitRot = new Vector3Int(0, 0, 0),
            }
        };


        shipMapPieces = new Dictionary<int, int[]>()
        {
            // LocID            Maptype                                Rotation  other info
            { 356 , new int[] { (int)MapPieceTypes.MapPiece_Room_Empty_01,    0,      0,0 } },
            { 365 , new int[] { (int)MapPieceTypes.MapPiece_Room_Empty_02,    0,      0,0 } },
            { 374 , new int[] { (int)MapPieceTypes.MapPiece_Room_Empty_01,    0,      0,0 } },
            { 446 , new int[] { (int)MapPieceTypes.MapPiece_Room_Empty_02,    0,      0,0 } }
        };
    }
}