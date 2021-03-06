﻿using System;
using System.Collections.Generic;

namespace Laoshi.WCF
{
    

   
    public partial class UserLogin
    {
        public UserLogin()
        {
            tblUserTests = new HashSet<tblUserTest>();
            tblTestResults = new HashSet<tblTestResult>();
            tblTestTemplates = new HashSet<tblTestTemplate>();
            tblTestTemplates1 = new HashSet<tblTestTemplate>();
            tblUserPaymentInfoes = new HashSet<tblUserPaymentInfo>();
            tblUserProfiles = new HashSet<tblUserProfile>();
            tblUserSubscriptions = new HashSet<tblUserSubscription>();
        }

        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int? Role { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<tblUserTest> tblUserTests { get; set; }

        public virtual tblRoleMaster tblRoleMaster { get; set; }

        public virtual ICollection<tblTestResult> tblTestResults { get; set; }

        public virtual ICollection<tblTestTemplate> tblTestTemplates { get; set; }

        public virtual ICollection<tblTestTemplate> tblTestTemplates1 { get; set; }

        public virtual ICollection<tblUserPaymentInfo> tblUserPaymentInfoes { get; set; }

        public virtual ICollection<tblUserProfile> tblUserProfiles { get; set; }

        public virtual ICollection<tblUserSubscription> tblUserSubscriptions { get; set; }
    }
}