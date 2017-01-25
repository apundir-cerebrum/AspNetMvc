namespace Laoshi.WCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    

    public partial class tblFieldMaster
    {
        public tblFieldMaster()
        {
            tblFieldMaster1 = new HashSet<tblFieldMaster>();
            tblFieldValueMasters = new HashSet<tblFieldValueMaster>();
        }

        public int Id { get; set; }

        public string FieldName { get; set; }

        public int? ParentId { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<tblFieldMaster> tblFieldMaster1 { get; set; }

        public virtual tblFieldMaster tblFieldMaster2 { get; set; }

        public virtual ICollection<tblFieldValueMaster> tblFieldValueMasters { get; set; }
    }
}
