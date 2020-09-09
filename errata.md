# Errata for *Microsoft Blazor*

On **page 47** [code error]:
 
Listing 2-33 includes the following line of code with the instructions to add it to the _Imports.razor file 

@layout MainLayout 

This is a error and prevents the code from loading in the browser.

.


On **page 63** [code error]:

Listing 2-54 has an error in the css class selectors they should be prefixed by a period.

.form-control.invalid {
 border-left: 5px solid #a94442; /∗ red ∗/
}
.form-control.valid.modified {
 border-left: 5px solid #42A948; /∗ green ∗/
}
***

