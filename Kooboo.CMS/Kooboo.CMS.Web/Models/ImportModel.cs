﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Kooboo.CMS.Web.Models
{
    public class ImportModel
    {
        public static ImportModel Default = new ImportModel();

        [Required(ErrorMessage = "Required")]
        [RegularExpression(".+\\.(zip)$", ErrorMessage = "Required a zip file.")]
        [UIHint("File")]
        [Description("Only .zip file is accepted.")]
        public string File { get; set; }

        [Description("Will overwrite the exists items.")]
        [Required(ErrorMessage = "Required")]
        public bool Override { get; set; }
    }
}