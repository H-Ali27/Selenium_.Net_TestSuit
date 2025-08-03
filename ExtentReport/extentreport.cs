using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using UnitTestProject1;

namespace UnitTestProject1
{
    public class extentreport : baseclass
    {
        public static string reportName = "HTMLTestReport.html";
        public static string reportPath = Path.Combine(@"E:\Selenium Practice\Heckathone01\UnitTestProject1\Screenshots", reportName);
       
        public static ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
        public static ExtentReports report = new ExtentReports();
        public static ExtentTest parent;
        public static ExtentTest childreport;

        public static void LogReport(string detail, string filename, string path, string format)
        {
            string fullPathWithExt = Path.Combine(path, filename + "." + format.ToLower());
            baseclass.screenshot(filename,path,format);
            childreport.Log(Status.Pass,(detail + ":Pass"),MediaEntityBuilder.CreateScreenCaptureFromPath(fullPathWithExt).Build());
        }
        public static void Parent_log(string parentTag) 
        {
            parent = report.CreateTest(parentTag);
        }
        public static void Child_log(string Nodename)
        {
            childreport = parent.CreateNode(Nodename);
        }
        public static void LogReportFailed(string detail, string filename,string path, string format)
        {
            string fullPathWithExt = Path.Combine(path, filename + "." + format.ToLower());
            baseclass.screenshot(filename, path, "png");
            childreport.Log(Status.Pass, (detail + ":Fail"), MediaEntityBuilder.CreateScreenCaptureFromPath(fullPathWithExt ).Build());
        }
        public static void Report()
        {
            report.AttachReporter(htmlReporter);
        }
        public static void flush()
        {
            report.Flush();
        }
    }
}
