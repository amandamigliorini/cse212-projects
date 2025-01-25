public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> features {get; set;}
}

public class Feature{
    public string Type {get; set;}
    public Properties Properties {get; set;}

}

public class Properties{
    public double Mag {get; set;}
    public string Place {get; set;}
    public long Time {get; set;}

}
