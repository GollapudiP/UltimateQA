using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using RazorEngine.Templating;
using System.Dynamic;

public class ReportManager
{
      
    private  ExtentReports? _ExtReport;
    private ReportManager()
    {
        var sparkReporter = new ExtentSparkReporter("UltimateQATestReport.html");
        _ExtReport = new ExtentReports();
        _ExtReport.AttachReporter(sparkReporter);

    }

    private static ReportManager? _Instance;

    public static ReportManager Instance
    {
        get
        {
            if(_Instance == null)
            {
                _Instance = new ReportManager();
            }

            return _Instance;
        }
    }

    public ExtentTest CreateTest(string testName)
    {
        return _ExtReport.CreateTest(testName);
    }

    public void FlushReport()
    {
        _ExtReport.Flush();
    }
}