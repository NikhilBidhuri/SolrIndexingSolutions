# SolrIndexingSolutions
Problem 1 : Sitecore Image Field not Indexing in Solr field 
By default Solr don't index Sitecore Image Fields, so to get Image fields in Solr index we need to make a computed field and use MediaManager.GetMediaUrl method to get Sitecore Image Url

Here is the code for computed field: ImageComputedField.cs

Problem 2 : Sitecore Richtext Field not returning raw HTML in Solr Field
By default Solr return text of Richtext not raw HTML, so we will make a config which will tell sitecore to index a particular field as Richtext and return HTML

Here is the Config : RichTextHTML.Config

This configuration, provided in Sitecore's XML patch format, customizes the field reading behavior for a Solr search index in Sitecore. It's done by adding a field reader for the "Body Copy" field in the index configuration. The field reader specifies how the content of the "Body Copy" field should be processed and indexed in Solr. This configuration is specifically for the default Solr index configuration and extends the default behavior by associating the "Body Copy" field with the DefaultFieldReader type, which is a built-in field reader for Sitecore content search. The field reader type defines how to extract and process data from the "Body Copy" field during indexing.

In summary, this configuration is used to fine-tune the indexing behavior for the "Body Copy" field in a Solr search index in Sitecore.

Problem 3 : Multidimensional Array not getting stored in Solr Index
As Solr have field return type as 'stringCollection' so we can return Array in Solr Index Field
but If we want to store Arrays inside of Array and return it
like [[01,Nikhil],[02,Divya],[03,Krishna]].

To achieve this we need to serialize the whole array using NewtonSoft and then return it as stringCollection Only

Here is the sample code for it : MultiDimentionalComputedField.cs
