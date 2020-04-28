﻿using UnityEngine;

public class MapSettings : MonoBehaviour {

    // Kind of Global references //
    public static bool LOADPREBUILT_STRUCTURE = true;

    public static int MAPTYPE_MAP_FLOOR = 0;
    public static int MAPTYPE_MAP_VENTS = 1;
    public static int MAPTYPE_CONNECT_FLOOR = 2;
    public static int MAPTYPE_CONNECT_VENTS = 3;
    public static int MAPTYPE_CONNECT_UP_FLOOR = 4;
    public static int MAPTYPE_CONNECT_UP_VENTS = 5;
    public static int MAPTYPE_SHIPPORT_FLOOR = 6;
    public static int MAPTYPE_SHIPPORT_VENTS = 7;

    //////////////////////////


    private static int _worldSizeX = 10;
    public static int worldSizeX { get { return _worldSizeX; } }

    private static int _worldSizeZ = 10;
    public static int worldSizeZ { get { return _worldSizeZ; } }

    private static int _worldSizeY = 45;
    public static int worldSizeY { get { return _worldSizeY; } }

    private static int _worldType = 0; // 0 = square, 1 = Line, 2 = tower
    public static int worldType { get { return _worldType; } }

    //////////////////////////////

    private static int _mapPiecePanelCountXZ = 13;
    public static int MapPiecePanelCountXZ { get { return _mapPiecePanelCountXZ; } }

    private static int _mapPiecePanelCountY = 3;
    public static int MapPiecePanelCountY { get { return _mapPiecePanelCountY; } }

    private static int _connectorPiecePanelCountX = 3;
    public static int ConnectorPiecePanelCountX { get { return _connectorPiecePanelCountX; } }

    private static int _connectorPiecePanelCountZ = MapPiecePanelCountXZ;
    public static int ConnectorPiecePanelCountZ { get { return _connectorPiecePanelCountZ; } }

    private static int _connectorPiecePanelCountY = MapPiecePanelCountY;
    public static int ConnectorPiecePanelCountY { get { return _connectorPiecePanelCountY; } }

    //////////////////////////////

    private static int _nodeCountOfMapPiecesXZ = (MapPiecePanelCountXZ * 2) + 3; // 29
    public static int NodeCountOfMapPiecesXZ { get { return _nodeCountOfMapPiecesXZ; } }

    private static int _nodeCountOfMapPiecesY = (MapPiecePanelCountY * 2) + 3; // 9
    public static int NodeCountOfMapPiecesY { get { return _nodeCountOfMapPiecesY; } }

    //////////////////////////////

    private static int _mapNodeCountDistanceXZ = (MapPiecePanelCountXZ * 2); // 26
    public static int MapNodeCountDistanceXZ { get { return _mapNodeCountDistanceXZ; } }

    private static int _mapNodeCountDistanceY = (MapPiecePanelCountY * 2); // 6
    public static int MapNodeCountDistanceY { get { return _mapNodeCountDistanceY; } }

    //////////////////////////////

    private static int _edgeNodesOverlap = -1; // -1 means overlapping the last map, 1 = placing it next to it, 0 = fucked up
    public static int EdgeNodesOverlap { get { return _edgeNodesOverlap; } }

    //////////////////////////////

    private static int _mapPiecesAroundWorldNode = 3; // 1
    public static int MapPiecesAroundWorldNode { get { return _mapPiecesAroundWorldNode; } }

    private static int _worldNodeCountDistanceXZ = (MapNodeCountDistanceXZ * MapPiecesAroundWorldNode); // 78
    public static int WorldNodeCountDistanceXZ { get { return _worldNodeCountDistanceXZ; } }

    private static int _worldNodeCountDistanceY = (MapNodeCountDistanceY * MapPiecesAroundWorldNode); // 18
    public static int WorldNodeCountDistanceY { get { return _worldNodeCountDistanceY; } }

    //////////////////////////////


    private static int _worldPadding = -20; // 10 * 24 = nodes start at X : 240
    public static int worldPadding { get { return _worldPadding; } }

    private static int _sizeOfCubes = 1; // 1
    public static int sizeOfCube { get { return _sizeOfCubes; } }

    private static int[] sizes;
    public static int getRandomMapSize { get { return sizes[Random.Range(0, sizes.Length)]; } }

    private static int _sizeOfMapConnectorsXYZ = 1; // 1
    public static int sizeOfMapConnectorsXYZ { get { return _sizeOfMapConnectorsXYZ; } }


    void Awake() {
        sizes = new int[] { 1, 3 };
    }


}
