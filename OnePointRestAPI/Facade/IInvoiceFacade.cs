﻿#region Header
/*
 ************************************************************************************
 Name: IInvoiceFacade
 Description: Interface  for all the Values operations 
 Created On:  28-sep-2018
 Created By:  Uday Kiran
 Last Modified On: 
 Last Modified By: 
 Last Modified Reason: 
 ************************************************************************************
 */
#endregion

using System.Collections.Generic;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using OnePointRestAPI.ValidationModels;

namespace OnePointRestAPI.Facade
{
    interface IInvoiceFacade : IFacade
    {
        // method declarations goes here
        dynamic SearchInvoice(dynamic value);
    }
}