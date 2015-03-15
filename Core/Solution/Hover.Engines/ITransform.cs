﻿namespace Hover.Engines {

	/*================================================================================================*/
	public interface ITransform {

		Vector3 LocalPosition { get; set; }
		Vector3 WorldPosition { get; set; }
		Quaternion LocalRotation { get; set; }
		Quaternion WorldRotation { get; set; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		Vector3 GetWorldPoint(Vector3 pLocalPoint);

		/*--------------------------------------------------------------------------------------------*/
		Vector3 CalculateLocalPoint(ITransform pOtherTransform, Vector3 pOtherLocalPoint);

	}

}
