﻿using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "hr_passportinfoEntity", Namespace = "http://www.KAF.com/types")]
    public partial class hr_passportinfoEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _passportid;
        protected long ? _hrbasicid;
        protected string _passportno;
        protected DateTime ? _passportissuedate;
        protected DateTime ? _passportexpirydate;
        protected long ? _passportissuecountryid;
        protected bool ? _isfamilypassport;
        protected string _passportfiledescription;
        protected string _passportfilepath;
        protected string _passportfilename;
        protected string _passportfiletype;
        protected string _passportextension;
        protected Guid ? _passportfileid;
        protected string _remarks;
        protected int ? _forreview;
        protected bool ? _iscurrent;
                
        
        [DataMember]
        public long ? passportid
        {
            get { return _passportid; }
            set { _passportid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_passportinfo), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(100)]
        [Display(Name = "passportno", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._hr_passportinfo), ErrorMessageResourceName = "passportnoRequired")]
        public string passportno
        {
            get { return _passportno; }
            set { _passportno = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passportissuedate", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public DateTime ? passportissuedate
        {
            get { return _passportissuedate; }
            set { _passportissuedate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passportexpirydate", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public DateTime ? passportexpirydate
        {
            get { return _passportexpirydate; }
            set { _passportexpirydate = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passportissuecountryid", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public long ? passportissuecountryid
        {
            get { return _passportissuecountryid; }
            set { _passportissuecountryid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "isfamilypassport", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public bool ? isfamilypassport
        {
            get { return _isfamilypassport; }
            set { _isfamilypassport = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "passportfiledescription", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public string passportfiledescription
        {
            get { return _passportfiledescription; }
            set { _passportfiledescription = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "passportfilepath", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public string passportfilepath
        {
            get { return _passportfilepath; }
            set { _passportfilepath = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "passportfilename", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public string passportfilename
        {
            get { return _passportfilename; }
            set { _passportfilename = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "passportfiletype", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public string passportfiletype
        {
            get { return _passportfiletype; }
            set { _passportfiletype = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(250)]
        [Display(Name = "passportextension", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public string passportextension
        {
            get { return _passportextension; }
            set { _passportextension = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "passportfileid", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public Guid ? passportfileid
        {
            get { return _passportfileid; }
            set { _passportfileid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [MaxLength(550)]
        [Display(Name = "remarks", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public string remarks
        {
            get { return _remarks; }
            set { _remarks = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "forreview", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public int ? forreview
        {
            get { return _forreview; }
            set { _forreview = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "iscurrent", ResourceType = typeof(KAF.MsgContainer._hr_passportinfo))]
        public bool ? iscurrent
        {
            get { return _iscurrent; }
            set { _iscurrent = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public hr_passportinfoEntity():base()
        {
        }
        
        public hr_passportinfoEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public hr_passportinfoEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("PassportID"))) _passportid = reader.GetInt64(reader.GetOrdinal("PassportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportIssueDate"))) _passportissuedate = reader.GetDateTime(reader.GetOrdinal("PassportIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportExpiryDate"))) _passportexpirydate = reader.GetDateTime(reader.GetOrdinal("PassportExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportIssueCountryID"))) _passportissuecountryid = reader.GetInt64(reader.GetOrdinal("PassportIssueCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyPassport"))) _isfamilypassport = reader.GetBoolean(reader.GetOrdinal("IsFamilyPassport"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportFileDescription"))) _passportfiledescription = reader.GetString(reader.GetOrdinal("PassportFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportFilePath"))) _passportfilepath = reader.GetString(reader.GetOrdinal("PassportFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportFileName"))) _passportfilename = reader.GetString(reader.GetOrdinal("PassportFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportFileType"))) _passportfiletype = reader.GetString(reader.GetOrdinal("PassportFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportExtension"))) _passportextension = reader.GetString(reader.GetOrdinal("PassportExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportFileID"))) _passportfileid = reader.GetGuid(reader.GetOrdinal("PassportFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsCurrent"))) _iscurrent = reader.GetBoolean(reader.GetOrdinal("IsCurrent"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }


        protected void LoadFromReader(IDataReader reader, bool IsListViewShow)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("PassportID"))) _passportid = reader.GetInt64(reader.GetOrdinal("PassportID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportNo"))) _passportno = reader.GetString(reader.GetOrdinal("PassportNo"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportIssueDate"))) _passportissuedate = reader.GetDateTime(reader.GetOrdinal("PassportIssueDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportExpiryDate"))) _passportexpirydate = reader.GetDateTime(reader.GetOrdinal("PassportExpiryDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportIssueCountryID"))) _passportissuecountryid = reader.GetInt64(reader.GetOrdinal("PassportIssueCountryID"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsFamilyPassport"))) _isfamilypassport = reader.GetBoolean(reader.GetOrdinal("IsFamilyPassport"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportFileDescription"))) _passportfiledescription = reader.GetString(reader.GetOrdinal("PassportFileDescription"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportFilePath"))) _passportfilepath = reader.GetString(reader.GetOrdinal("PassportFilePath"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportFileName"))) _passportfilename = reader.GetString(reader.GetOrdinal("PassportFileName"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportFileType"))) _passportfiletype = reader.GetString(reader.GetOrdinal("PassportFileType"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportExtension"))) _passportextension = reader.GetString(reader.GetOrdinal("PassportExtension"));
                if (!reader.IsDBNull(reader.GetOrdinal("PassportFileID"))) _passportfileid = reader.GetGuid(reader.GetOrdinal("PassportFileID"));
                if (!reader.IsDBNull(reader.GetOrdinal("Remarks"))) _remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                if (!reader.IsDBNull(reader.GetOrdinal("ForReview"))) _forreview = reader.GetInt32(reader.GetOrdinal("ForReview"));
                if (!reader.IsDBNull(reader.GetOrdinal("IsCurrent"))) _iscurrent = reader.GetBoolean(reader.GetOrdinal("IsCurrent"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date1"))) _ex_date1 = reader.GetDateTime(reader.GetOrdinal("Ex_Date1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Date2"))) _ex_date2 = reader.GetDateTime(reader.GetOrdinal("Ex_Date2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar1"))) _ex_nvarchar1 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Nvarchar2"))) _ex_nvarchar2 = reader.GetString(reader.GetOrdinal("Ex_Nvarchar2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint1"))) _ex_bigint1 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Bigint2"))) _ex_bigint2 = reader.GetInt64(reader.GetOrdinal("Ex_Bigint2"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal1"))) _ex_decimal1 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal1"));
                if (!reader.IsDBNull(reader.GetOrdinal("Ex_Decimal2"))) _ex_decimal2 = reader.GetDecimal(reader.GetOrdinal("Ex_Decimal2"));
                if (!reader.IsDBNull(reader.GetOrdinal("TransID"))) this.BaseSecurityParam.transid = reader.GetString(reader.GetOrdinal("TransID"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserOrganizationKey"))) this.BaseSecurityParam.userorganizationkey = reader.GetInt64(reader.GetOrdinal("UserOrganizationKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("UserEntityKey"))) this.BaseSecurityParam.userentitykey = reader.GetInt64(reader.GetOrdinal("UserEntityKey"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedBy"))) this.BaseSecurityParam.createdby = reader.GetInt64(reader.GetOrdinal("CreatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedByUserName"))) _createdbyusername = reader.GetString(reader.GetOrdinal("CreatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("CreatedDate"))) this.BaseSecurityParam.createddate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedBy"))) this.BaseSecurityParam.updatedby = reader.GetInt64(reader.GetOrdinal("UpdatedBy"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedByUserName"))) _updatedbyusername = reader.GetString(reader.GetOrdinal("UpdatedByUserName"));
                if (!reader.IsDBNull(reader.GetOrdinal("UpdatedDate"))) this.BaseSecurityParam.updateddate = reader.GetDateTime(reader.GetOrdinal("UpdatedDate"));
                if (!reader.IsDBNull(reader.GetOrdinal("IPAddress"))) this.BaseSecurityParam.ipaddress = reader.GetString(reader.GetOrdinal("IPAddress"));
                if (!reader.IsDBNull(reader.GetOrdinal("FormID"))) this.BaseSecurityParam.appformid = reader.GetInt64(reader.GetOrdinal("FormID"));
                if (!reader.IsDBNull(reader.GetOrdinal("TS"))) this.BaseSecurityParam.ts = reader.GetInt64(reader.GetOrdinal("ts"));
                CurrentState = EntityState.Unchanged;
            }
        }
        #endregion
    }
}
