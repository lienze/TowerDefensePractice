﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 地图cube，可以放置炮塔
public class MapCube : MonoBehaviour {

	[HideInInspector] // [HideInInspector]可以隐藏这个public属性显示在inspector面板
	public GameObject turretGo; // 当前cube下的炮塔，如果为空，则表示当前位置没有炮塔

	// 构建炮塔
	public void BuildTurret(GameObject turretPrefab) 
	{
		
	}
}