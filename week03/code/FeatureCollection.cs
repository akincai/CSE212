public class FeatureCollection
{
    public MetaData metadata { get; set; }
    public decimal[] bbox { get; set; }
    public Feature[] features { get; set; }
}
public class MetaData
{
    public long generated { get; set; }
    public string url { get; set; }
    public string title { get; set; }
    public string api { get; set; }
    public int count { get; set; }
    public int status { get; set; }
}
public class Feature
{
    public Properties properties { get; set; }
    public Point geometry { get; set; }
    public string id { get; set; }
}
public class Properties
{
    public decimal mag { get; set; }
    public string place { get; set; }
    // dev note: DEBUGGING THIS WAS A NIGHTMARE (JUST IMPORT THE INFORMATION YOU NEED)
    //  SOMEWHERE IN THE COMMENTED CODE IS AN IMPROPER TYPED OR IMPORTED DATATYPE
    // public long time { get; set; }
    // public long updated { get; set; }
    // public int tz { get; set; }
    // public string url { get; set; }
    // public string detail { get; set; }
    // public int felt { get; set; }
    // public decimal cdi { get; set; }
    // public decimal mmi { get; set; }
    // public string alert { get; set; }
    // public string status { get; set; }
    // public int tsunami { get; set; }
    // public int sig { get; set; }
    // public string net { get; set; }
    // public string code { get; set; }
    // public string ids { get; set; }
    // public string sources { get; set; }
    // public string types { get; set; }
    // public int nst { get; set; }
    // public decimal dmin { get; set; }
    // public decimal rms { get; set; }
    // public decimal gap { get; set; }
    // public string magType { get; set; }
    // public string type { get; set; }
}
public class Point
{
    public decimal[] coordinates { get; set; }
}