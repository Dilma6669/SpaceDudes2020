﻿using System.Collections.Generic;

public class StructureData_01
{
    public List<int[,]> floors = new List<int[,]>()
    {
        // 00 = Empty
        // 01 = WorldNode

        // LOOK AT THESE AS UNDERNEATH MAPS
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 2nd Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 3rd Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 4th Floorw
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 2nd Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
         },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 },
            { 01, 01, 01, 01, 01, 01, 01, 01, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        },
        // 1st Floor
        new int[,] {
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 00, 00, 00, 00, 00, 00, 00, 00, 00, 00 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 },
            { 01, 01, 00, 00, 00, 00, 00, 00, 01, 01 }
        }
    };
}