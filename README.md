# SolrIndexingSolutions

## Problem 1: Sitecore Image Field not Indexing in Solr field

By default, Solr doesn't index Sitecore Image Fields. To include Image fields in the Solr index, you need to create a computed field and use the `MediaManager.GetMediaUrl` method to get the Sitecore Image URL.

Here is the code for the computed field: `ImageComputedField.cs`

## Problem 2: Sitecore Richtext Field not returning raw HTML in Solr Field

By default, Solr returns text from Richtext fields, not raw HTML. To configure Sitecore to index a particular field as Richtext and return HTML, you can use a custom configuration.

Here is the configuration file: `RichTextHTML.Config`

## Problem 3: Multidimensional Array not getting stored in Solr Index

Solr's field return type is 'stringCollection,' which means you can return an array in a Solr Index Field. However, if you want to store arrays inside of an array and return it in a format like `[[01, Nikhil], [02, Divya], [03, Krishna]]`, you need to serialize the entire array using Newtonsoft.Json and return it as a stringCollection.

Here is a sample code for achieving this: `MultiDimentionalComputedField.cs`
