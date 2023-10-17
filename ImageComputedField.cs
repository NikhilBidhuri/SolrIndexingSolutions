using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.ContentSearch.Utilities;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Resources.Media;
using Sitecore.Data.Fields;

public class MyMainImageIndexing : IComputedIndexField
{
    public string FieldName { get; set; }
    public string ReturnType { get; set; }
    public object ComputeFieldValue(IIndexable indexable)
    {
        Assert.ArgumentNotNull(indexable, "indexable");

        Item indexableItem = indexable as SitecoreIndexableItem;
        
        if (indexableItem == null)
        {
            Log.Warn($"{this} : unsupported IIndexable type : {indexable.GetType()}", this);
            return null;
        }
        ImageField img = indexableItem.Fields["Main Image"];

        if (img == null || img.MediaItem == null)
        {
            return null;
        }
        else
        {
            return MediaManager.GetMediaUrl(img.MediaItem);
        }
    }
}
