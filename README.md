# SchemaReader
ArcGIS Pro 1.2 add-in that displays useful information about dataset schemas.

This will be messy. First ArcGIS Pro Add-in attempt. Really weak exposure to WPF.

This is a re-write of an ArcCatalog add-in.

This add-in will give the user a toggleable pane that will show them information about a feature class or shapefile that is 
currently selected in the project pane. 

The information displayed includes the following columns, one row per field:

  Field Position - The index of the field starting at 1. 

  Field Name

  Field Type - The ESRI data type of the field.

  Max Length - The maximum allows length of the field.

  Character Sample - If the field contains a string, Displays the longest value found, preceded by the length in paranthesis.

  Precision Sample - If the field contains a float point type such as double, displays the largest value found preceded by the length 
    in paranthesis

  Scale Sample - If the field contains a floating point type such as double, displays the largest value found preceded by the length 
    of the mantissa.

The ObjectID and Shape fields are ignored. 

While the add-in's pane is open, the pane will react to a selection change in the project pane and update the displayed information to
reflect the newly selected item.  
