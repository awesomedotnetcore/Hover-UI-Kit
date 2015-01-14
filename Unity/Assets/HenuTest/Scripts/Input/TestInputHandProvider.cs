﻿using Henu.Input;
using UnityEngine;

namespace HenuTest.Input {

	/*================================================================================================*/
	public class TestInputHandProvider : IInputHandProvider {

		public bool IsLeft { get; private set; }
		public IInputHand Hand { get; private set; }

		public IInputPoint IndexPoint { get; private set; }
		public IInputPoint MiddlePoint { get; private set; }
		public IInputPoint RingPoint { get; private set; }
		public IInputPoint PinkyPoint { get; private set; }

		/*
		han: (0.121, 0.118, -0.020) / (0.100, 0.826, -0.030, 0.554)
		ind: (0.060, 0.134, 0.062) / (0.047, 0.919, 0.082, 0.383)
		mid: (0.031, 0.149, 0.025) / (-0.015, 0.848, 0.011, 0.530)
		rin: (0.029, 0.154, -0.013) / (-0.024, 0.791, -0.043, 0.610)
		pin: (0.040, 0.138, -0.053) / (-0.116, 0.703, -0.073, 0.698)
		*/


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public TestInputHandProvider(bool pIsLeft, TestInputHand pHand) {
			IsLeft = pIsLeft;
			Hand = pHand;

			GameObject indexObj = pHand.gameObject.transform.FindChild("IndexPoint").gameObject;
			GameObject midObj = pHand.gameObject.transform.FindChild("MiddlePoint").gameObject;
			GameObject ringObj = pHand.gameObject.transform.FindChild("RingPoint").gameObject;
			GameObject pinkyObj = pHand.gameObject.transform.FindChild("PinkyPoint").gameObject;

			IndexPoint = indexObj.gameObject.GetComponent<TestInputPoint>();
			MiddlePoint = midObj.gameObject.GetComponent<TestInputPoint>();
			RingPoint = ringObj.gameObject.GetComponent<TestInputPoint>();
			PinkyPoint = pinkyObj.gameObject.GetComponent<TestInputPoint>();
		}

	}

}
