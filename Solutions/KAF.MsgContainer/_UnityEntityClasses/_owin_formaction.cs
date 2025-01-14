﻿using  KAF.MsgContainer.Abstract;
using  KAF.MsgContainer.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KAF.MsgContainer;

namespace KAF.MsgContainer
{
    
    public  class _owin_formaction : _Common
    {
         private static IResourceProvider resourceProvider_owin_formaction = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_owin_formaction.xml"));//DbResourceProvider(); //  
         
         
        public static string formactionList
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("formactionList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formactionCreate
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("formactionCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formactionUpdate
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("formactionUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string formactionDetails
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("formactionDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string appformid
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("appformid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string appformidRequired
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("appformidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string actionname
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("actionname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string actionnameRequired
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("actionnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isview
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("isview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string eventname
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("eventname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string sequence
        {
            get
            {
                return resourceProvider_owin_formaction.GetResource("sequence", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
