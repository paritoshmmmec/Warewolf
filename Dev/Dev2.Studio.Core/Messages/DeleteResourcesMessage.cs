/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2017 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using System.Collections.Generic;
using Dev2.Studio.Interfaces;

// ReSharper disable CheckNamespace
namespace Dev2.Studio.Core.Messages
{
    public class DeleteResourcesMessage : IMessage
    {
        public DeleteResourcesMessage(ICollection<IContextualResourceModel> resourceModels, string folderName, bool showDialog = true, Action actionToDoOnDelete = null)
        {
            FolderName = folderName;
            ActionToDoOnDelete = actionToDoOnDelete;
            ShowDialog = showDialog;
            ResourceModels = resourceModels;
        }

        public ICollection<IContextualResourceModel> ResourceModels;

        public string FolderName { get; set; }
        public Action ActionToDoOnDelete { get; set; }
        public bool ShowDialog { get; set; }
    }
}
