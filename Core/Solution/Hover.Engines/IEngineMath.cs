﻿namespace Hover.Engines {

	/*================================================================================================*/
	public interface IEngineMath {


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		Vector3 NewVector3Random();


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		Quaternion NewQuaternionAngleAxis(float pAngle, Vector3 pAxis);

		/*--------------------------------------------------------------------------------------------*/
		Quaternion NewQuaternionFromTo(Vector3 pFrom, Vector3 pTo);

		/*--------------------------------------------------------------------------------------------*/
		Quaternion NewQuaternionRandom();


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		Quaternion RotateQuaternion(Quaternion pQuaternion, Quaternion pRotation);

		/*--------------------------------------------------------------------------------------------*/
		Vector3 RotateVector(Vector3 pVector, Quaternion pRotation);

	}

}
