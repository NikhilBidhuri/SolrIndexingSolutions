using Newtonsoft.Json;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using System;
using System.Collections.Generic;

public class CustomArrayField : IComputedIndexField
{
    public string FieldName { get; set; }
    public string ReturnType { get; set; }
    public object ComputeFieldValue(IIndexable indexable)
    {
        // Get your array data, e.g., from your Sitecore item
        List<string[]> arrayOfArrays = new List<string[]>
        {
            new string[] { "01", "Nikhil" },
            new string[] { "02", "Divya" },
            new string[] { "03", "Krishna" }
        };
        // Serialize the array into a JSON string
        string serializedData = JsonConvert.SerializeObject(arrayOfArrays);

        // Return it as a stringCollection
        return new List<string> { serializedData };
    }
}
