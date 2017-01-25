namespace Laoshi.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFieldMaster")]
    public partial class tblFieldMaster
    {
        public tblFieldMaster()
        {
            tblFieldMaster1 = new HashSet<tblFieldMaster>();
            tblFieldValueMasters = new HashSet<tblFieldValueMaster>();
        }

        public int Id { get; set; }

        [StringLength(400)]
        public string FieldName { get; set; }

        public int? ParentId { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<tblFieldMaster> tblFieldMaster1 { get; set; }

        public virtual tblFieldMaster tblFieldMaster2 { get; set; }

        public virtual ICollection<tblFieldValueMaster> tblFieldValueMasters { get; set; }
    }
}
