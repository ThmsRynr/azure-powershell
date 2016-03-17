﻿using System;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Sql.Backup.Model
{
    public class AzureSqlDatabaseBackupArchivalPolicyModel
    {
        /// <summary>
        /// Gets or sets the name of the resource group
        /// </summary>
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the name of the server
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the database
        /// </summary>
        public string DatabaseName { get; set; }

        /*
         * Not supported for MVP
        /// <summary>
        /// Gets or sets a value indicating whether to use server default
        /// </summary>
        public bool UseServerDefault { get; set; }
        */

        /// <summary>
        /// Gets or sets the backup archival state
        /// </summary>
        public string BackupArchivalState { get; set; }

        /// <summary>
        /// Gets or sets the backup archival policy
        /// </summary>
        public string VaultPolicyName { get; set; }
    }
}
