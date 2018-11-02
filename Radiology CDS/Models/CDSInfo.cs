#region Header
//      Copyright (C) 2018 NIRA Systems.
//      All rights reserved. Reproduction or transmission in whole or in part, in
//      any form or by any means, electronic, mechanical or otherwise, is prohibited
//      without the prior written consent of the copyright owner.
//
// Release history:
//      Date        |    Author             |       Description
//----------------------------------------------------------------------------------------------
//      12-Oct-2018 |    Umesh Babu         |       Created and implemented the functionalities. 
//----------------------------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acr.Dart.MongoDBClient
{
	public class CDSInfo
	{
        /// <summary>
        /// The Group ID.
        /// </summary>
		public string GroupId { get; set; }

        /// <summary>
        /// The Group Name.
        /// </summary>
		public string GroupName { get; set; }

        /// <summary>
        /// The Department ID.
        /// </summary>
		public int DepartmentId { get; set; }
	}
}