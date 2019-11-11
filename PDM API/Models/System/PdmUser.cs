using System;
using System.Collections.Generic;

namespace PDM_API.Models.Auth
{
    [Serializable]
    public class ProdComUser
    {
        public string Username { get; set; }

        public bool HasReadAllRole { get; set; }

        public bool IsCompany = false;

        public HashSet<string> FieldAccess { get; set; } = new HashSet<string>();

        public ProdComUser()
        {

        }
    }
}
