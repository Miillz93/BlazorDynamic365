namespace BlazorDynamic365.Data;


public class Rootobject
{
    public string odatacontext { get; set; }
    public Value[] value { get; set; }
}

public class Value
{
    public string odataetag { get; set; }
    public string contactid { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string fullname { get; set; }
    public string jobtitle { get; set; }
    public string telephone1 { get; set; }
    public string emailaddress1 { get; set; }
}

