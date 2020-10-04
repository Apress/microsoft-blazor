# Errata for *Microsoft Blazor*

On **page 34** [code error]:
 
Listing 2-14 lacks @ symbol before onchange keyword. The code should be:

```csharp
<input type="number"
       value="@increment"
       @onchange="@((ChangeEventArgs e)
                  => increment = int.Parse($"{e.Value}"))" />
```


***

On **page 47** [code error]:
 
Listing 2-33 includes the following line of code with the instructions to add it to the _Imports.razor file 

@layout MainLayout 

This is a error and prevents the code from loading in the browser.

.

***

