namespace Laoshi.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblRoleMaster")]
    public partial class tblRoleMaster
    {
        public tblRoleMaster()
        {
            tblLogins = new HashSet<UserLogin>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(100)]
        public string RoleName { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<UserLogin> tblLogins { get; set; }
    }
}
