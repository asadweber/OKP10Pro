﻿using System;
using System.Runtime.Serialization;
using System.Data;
using System.ComponentModel.DataAnnotations;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;

namespace KAF.BusinessDataObjects
{
    [Serializable]
    [DataContract(Name = "tran_manpowerstatedetlEntity", Namespace = "http://www.KAF.com/types")]
    public partial class tran_manpowerstatedetlEntity : BaseEntity
    {
        #region Properties
    
        protected long ? _manpowerstatedetlid;
        protected long ? _manpowerstateid;
        protected long ? _hrbasicid;
        protected long ? _hrsvcid;
        protected long ? _rankid;
        protected long ? _groupid;
        protected long ? _subunitid;
        protected long ? _campid;
        protected long ? _manpowerstatusid;
                
        
        [DataMember]
        public long ? manpowerstatedetlid
        {
            get { return _manpowerstatedetlid; }
            set { _manpowerstatedetlid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "manpowerstateid", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl), ErrorMessageResourceName = "manpowerstateidRequired")]
        public long ? manpowerstateid
        {
            get { return _manpowerstateid; }
            set { _manpowerstateid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrbasicid", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl), ErrorMessageResourceName = "hrbasicidRequired")]
        public long ? hrbasicid
        {
            get { return _hrbasicid; }
            set { _hrbasicid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "hrsvcid", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl), ErrorMessageResourceName = "hrsvcidRequired")]
        public long ? hrsvcid
        {
            get { return _hrsvcid; }
            set { _hrsvcid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "rankid", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl), ErrorMessageResourceName = "rankidRequired")]
        public long ? rankid
        {
            get { return _rankid; }
            set { _rankid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "groupid", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl), ErrorMessageResourceName = "groupidRequired")]
        public long ? groupid
        {
            get { return _groupid; }
            set { _groupid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "subunitid", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl), ErrorMessageResourceName = "subunitidRequired")]
        public long ? subunitid
        {
            get { return _subunitid; }
            set { _subunitid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "campid", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl), ErrorMessageResourceName = "campidRequired")]
        public long ? campid
        {
            get { return _campid; }
            set { _campid = value; this.OnChnaged(); }
        }
        
        [DataMember]
        [Display(Name = "manpowerstatusid", ResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl))]
        [Required(ErrorMessageResourceType = typeof(KAF.MsgContainer._tran_manpowerstatedetl), ErrorMessageResourceName = "manpowerstatusidRequired")]
        public long ? manpowerstatusid
        {
            get { return _manpowerstatusid; }
            set { _manpowerstatusid = value; this.OnChnaged(); }
        }
        
        
        #endregion
    
        #region Constructor
    
        public tran_manpowerstatedetlEntity():base()
        {
        }
        
        public tran_manpowerstatedetlEntity(IDataReader reader)
        {
            this.LoadFromReader(reader);
        }
        
         public tran_manpowerstatedetlEntity(IDataReader reader, bool IsListViewShow)
        {
            this.LoadFromReader(reader, IsListViewShow);
        }
        
        protected void LoadFromReader(IDataReader reader)
        {
            if (reader != null && !reader.IsClosed)
            {
                this.BaseSecurityParam = new SecurityCapsule();
                if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateDetlID"))) _manpowerstatedetlid = reader.GetInt64(reader.GetOrdinal("ManpowerStateDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateID"))) _manpowerstateid = reader.GetInt64(reader.GetOrdinal("ManpowerStateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _rankid = reader.GetInt64(reader.GetOrdinal("RankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _groupid = reader.GetInt64(reader.GetOrdinal("GroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubUnitID"))) _subunitid = reader.GetInt64(reader.GetOrdinal("SubUnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CampID"))) _campid = reader.GetInt64(reader.GetOrdinal("CampID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStatusID"))) _manpowerstatusid = reader.GetInt64(reader.GetOrdinal("ManpowerStatusID"));
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
                if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateDetlID"))) _manpowerstatedetlid = reader.GetInt64(reader.GetOrdinal("ManpowerStateDetlID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStateID"))) _manpowerstateid = reader.GetInt64(reader.GetOrdinal("ManpowerStateID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrBasicID"))) _hrbasicid = reader.GetInt64(reader.GetOrdinal("HrBasicID"));
                if (!reader.IsDBNull(reader.GetOrdinal("HrSvcID"))) _hrsvcid = reader.GetInt64(reader.GetOrdinal("HrSvcID"));
                if (!reader.IsDBNull(reader.GetOrdinal("RankID"))) _rankid = reader.GetInt64(reader.GetOrdinal("RankID"));
                if (!reader.IsDBNull(reader.GetOrdinal("GroupID"))) _groupid = reader.GetInt64(reader.GetOrdinal("GroupID"));
                if (!reader.IsDBNull(reader.GetOrdinal("SubUnitID"))) _subunitid = reader.GetInt64(reader.GetOrdinal("SubUnitID"));
                if (!reader.IsDBNull(reader.GetOrdinal("CampID"))) _campid = reader.GetInt64(reader.GetOrdinal("CampID"));
                if (!reader.IsDBNull(reader.GetOrdinal("ManpowerStatusID"))) _manpowerstatusid = reader.GetInt64(reader.GetOrdinal("ManpowerStatusID"));
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