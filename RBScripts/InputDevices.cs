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

namespace RedBlueTools
{
	public static class InputDevices
	{
		//TODO We need a data structure that can be accessed by name, iterated on, and retricted to
		// only certain keys.
		public enum ControllerTypes
		{
			Keyboard = 0,
			XBox
		}

		static InputDevice[] inputDevices = {
			new InputDevice ("PC"),
			new InputDevice ("XBox")
		};

		static public InputDevice[] GetAllInputDevices ()
		{
			return inputDevices;
		}
	}
}