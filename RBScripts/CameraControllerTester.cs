﻿/*****************************************************************************
 *  Red Blue Tools are Unity Editor utilities. Some utilities require 3rd party tools.
 *  Copyright (C) 2014 Red Blue Games, LLC
 *  
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 2 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 ****************************************************************************/
using UnityEngine;

namespace RedBlueTools
{
	public class CameraControllerTester : MonoBehaviour
	{
		public CameraShake cameraShake;

		// Test shake variables
		public float shakeSpeed = 1f;
		public float shakeMagnitude = 2f;
		public float shakeDuration = 1f;
		public float shakeDelay = 0f;
		public bool testShake;                  // Force camera shake using provided properties

		// Test zoom variables
		public float zoomRatio = 1.5f;
		public float zoomDuration = 2f;
		public float resetZoomDuration = 1.0f;
		public bool testZoom;                   // Force camera zoom using provided properties
		public bool testResetZoom;              // Force reset camera zoom

		// Update is called once per frame
		void Update ()
		{
			// Try our test methods
			TestShake ();
		}

		/*
	 * Test method to help check the behavior of various shakes. Set testShake to true
	 * while in Play mode.
	 */
		void TestShake ()
		{
			if (testShake) {
				testShake = false;
				cameraShake.Shake (shakeSpeed, shakeDuration, shakeMagnitude);
			}
		}

	}
}