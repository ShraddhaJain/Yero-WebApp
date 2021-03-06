﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System.ComponentModel; 


namespace Yero
{
    public class Audit
    {

///// <summary> 
///// Summary description for Audit 
///// </summary> 
//public class Audit 
//{ 
//    public Audit() 
//    { 
//    // 
//    // TODO: Add constructor logic here 
//    // 
//    } 

 public static void CustomError(Exception ex, string functionName, object p,bool IsUI) 
 { 
 String additionalInfo;  

 LogEntry logEntry = new LogEntry(); 
 logEntry.Severity = System.Diagnostics.TraceEventType.Error; 
 logEntry.Message = functionName + " :- PARAM " ; 

 foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(p)) 
 { 
 string name = descriptor.Name; 
 object value = descriptor.GetValue(p); 
 logEntry.Message = logEntry.Message + "||" + name + " :- " + value; 
 } 

 logEntry.Message = logEntry.Message + Environment.NewLine + ": --ERROR MESSAGE " + ex.Message.ToString(); 
 logEntry.Message = logEntry.Message + Environment.NewLine + ": --ERROR Callstack " + ex.StackTrace.ToString(); 
 logEntry.Message = logEntry.Message + Environment.NewLine + ": --ERROR Callstack " + ex.InnerException; 
 logEntry.Message = logEntry.Message + Environment.NewLine + ": --ERROR Callstack " + ex.Source.ToString(); 

 additionalInfo = "Activity ID: " + logEntry.ActivityId + "|| AppDomain :" + logEntry.AppDomainName + "|| EventId: " + logEntry.EventId + "|| ExtProperties: " + logEntry.ExtendedProperties + "|| Machine Name: " + logEntry.MachineName; 
 logEntry.Message = logEntry.Message + Environment.NewLine + ": --Additional Info " + additionalInfo; 


 Logger.Write(logEntry);
 if (IsUI)
 {
     HttpContext.Current.Response.Redirect("/Error.aspx");
 }
 }


 public static void CustomLog(string functionName, object p) 
 { 

 LogEntry logEntry = new LogEntry(); 

 logEntry.Message = functionName + ": -- " ; 

foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(p)) 
 { 
 string name = descriptor.Name; 
 object value = descriptor.GetValue(p); 
 logEntry.Message = logEntry.Message + " : -- PARAM ||" + name + " :- " + value; 
 } 

 Logger.Write(logEntry); 
 } 

}
}
