﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckGameGlobalConfig {
    public static float moveSpeed = 5f;
	public static float sideMoveSpeed = 20f;
    public static float startDistance = 64f;
    public static float winDistance = 2.0f;
	public static float targetLineDistance = 30f;

	public static float duckPushDistance = 20f;

	public static float preDropOffTime = 10f;
    public static float dropOffTime = 5f;

	public static float quackSpamInterval = 0.5f;

	public static bool drawDebugLines = true;

	public static float removeDuckFatnessInterval = 10f;

	public static float fatness1PushMultiplier = 1f;
	public static float fatness2PushMultiplier = 0.8f;
	public static float fatness3PushMultiplier = 0.6f;
}
