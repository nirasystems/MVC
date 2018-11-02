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
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Acr.RScanDashboard.Models
{
	public class CDSOrganizationViewModel
	{
        /// <summary>
        /// The Unique Identifier
        /// </summary>
		public int ID { get; set; }

        /// <summary>
        /// The Organization ID.
        /// </summary>
        [Required(ErrorMessage = "OrganizationID is required")]
		public int OrganizationID { get; set; }
		[Required(ErrorMessage = "Organization is required")]
		public string Organization { get; set; }
		[Required(ErrorMessage = "Password is required")]
		public string Password { get; set; }
		public Nullable<System.DateTime> CreatedDate { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }

		public List<CDSOrganizationGroup> CDSOrganizationGroupList { get; set; }

		public DateTime GroupsIngestDate { get; set; }

	}
}