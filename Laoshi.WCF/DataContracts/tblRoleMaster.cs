namespace Laoshi.WCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    

    public partial class tblRoleMaster
    {
        public tblRoleMaster()
        {
            tblLogins = new HashSet<UserLogin>();
        }

        public int Id { get; set; }

        public string RoleName { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<UserLogin> tblLogins { get; set; }
    }
}
