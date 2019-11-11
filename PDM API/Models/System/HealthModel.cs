using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace PDM_API.Models
{
    public class HealthModel
    {
        public string Version { get; set; }
        public bool DatabaseCheckPassed { get; set; }
    }
}