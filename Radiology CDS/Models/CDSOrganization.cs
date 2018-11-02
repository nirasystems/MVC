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

namespace Acr.RScanDashboard.Models
{   
    public partial class CDSOrganization
    {
        /// <summary>
        /// The Unique Identifier
        /// </summary>
		public int ID { get; set; }

        /// <summary>
        /// The Organization ID.
        /// </summary>
        public int OrganizationID { get; set; }

        /// <summary>
        /// The Organization Name.
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// The Security Key.
        /// </summary>
        public string SecurityKey { get; set; }

        /// <summary>
        /// The Created Datetime.
        /// </summary>
        public Nullable<DateTime> CreatedDate { get; set; }

        /// <summary>
        /// The Modified Datetime.
        /// </summary>
        public Nullable<DateTime> ModifiedDate { get; set; }

        /// <summary>
        /// The Group Ingested Datetime.
        /// </summary>
        public Nullable<DateTime> GroupIngestedDate { get; set; }
    }
}