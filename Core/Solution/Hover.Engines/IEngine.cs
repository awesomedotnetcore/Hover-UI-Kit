﻿namespace Hover.Engines {

	/*================================================================================================*/
	public interface IEngine {

		IEngineMath Math { get; }


		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		IContainer FindContainer(string pName);

	}

}
