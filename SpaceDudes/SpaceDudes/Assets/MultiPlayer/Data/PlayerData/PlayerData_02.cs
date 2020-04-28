﻿
using System.Collections.Generic;
using UnityEngine;

public class PlayerData_02 : BasePlayerData {

    public PlayerData_02()
    {
        playerID = 2;
        name = "Fred";
        numUnits = 2;

        allUnitData = new List<UnitStruct>()
        {
            // can Climb walls, unitCombat Stats, starting Local loc
            new UnitStruct()
            {
                UnitModel = 0,
                UnitCanClimbWalls = false,
                UnitCombatStats = new int[2]{ 1, 4 }, // Rank, Movement
                UnitShipLoc = new Vector3Int(6, -2, 4),
                UnitRot = new Vector3Int(0, 90, 0),
            },

            new UnitStruct()
            {
                UnitModel = 0,
                UnitCanClimbWalls = false,
                UnitCombatStats = new int[2]{ 0, 4 },
                UnitShipLoc = new Vector3Int(4, -2, 6),
                UnitRot = new Vector3Int(0, 0, 0),
            }
        };


        shipMapPieces = new Dictionary<int, int[]>()
        {
            // LocID            Maptype                                 Rotation  other info
            { 356 , new int[] { (int)MapPieceTypes.MapPiece_Room_Empty,    0,      0,0 } },
            { 365 , new int[] { (int)MapPieceTypes.MapPiece_Room_Empty,    0,      0,0 } },
            { 374 , new int[] { (int)MapPieceTypes.MapPiece_Room_Empty,    0,      0,0 } }
        };



        // LOOK AT THESE AS UNDERNEATH MAPS
        // 1st Floor
        //new int[,] {
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, // starts at 01
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, 
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, 
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, 
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, 
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, 
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, 
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, 
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 } //81
        //},
        //// 2nd Floor
        //new int[,] {
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 } //162
        //},
        //// 3rd Floor
        //new int[,] {
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 } //243
        //},
        //// 4th Floorw
        //new int[,] {
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, //252
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, //270
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 02, 00, 00, 00, 00 }, //288 -> mid (284)
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 } //324
        //},
        //// 1st Floor
        //new int[,] {
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, //333
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, //351
        //    { 00, 00, 00, 00, 03, 00, 00, 00, 00 }, //360 -> mid (356)
        //    { 00, 00, 00, 04, 01, 04, 00, 00, 00 }, //369 -> mid (365)
        //    { 00, 00, 00, 00, 03, 00, 00, 00, 00 }, //378 -> mid (374)
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 } //405
        //},
        //// 2nd Floor
        //new int[,] {
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, //414
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, //432
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 02, 00, 00, 00, 00 }, //450 -> mid (446)
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 } //486
        //},
        //// 1st Floor
        //new int[,] {
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 }, // 495
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 } //567
        //},
        //// 1st Floor
        //new int[,] {
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 } //648
        //},
        //// 1st Floor
        //new int[,] {
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 },
        //    { 00, 00, 00, 00, 00, 00, 00, 00, 00 } //729
        //}
        /////////////////////////////////////////////////////////////////
    }
}