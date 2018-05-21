# Mossharbor.AzureWorkArounds.Storage
Implements functionality for missing azure storage apis in .net standard.  
The last version of the azure storage api did not contains functions that were not async making porting time consuming and difficult.
 
This library adds those operations back in a donet standard 2.0 compatible library.  So calls like this (see below) will compile. 

```cs
CloudPageBlob blob = (CloudPageBlob)blobItem;
blob.Delete();
```

you can see a discussion of the issue [here](https://github.com/Azure/azure-storage-net/issues/367)

Install the nuget package:  [Install-Package Mossharbor.AzureWorkArounds.Storage -Version 1.0.1](https://www.nuget.org/packages/Mossharbor.AzureWorkArounds.Storage/1.0.1#)

