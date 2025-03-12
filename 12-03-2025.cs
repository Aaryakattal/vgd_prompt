// Today i learned how to Combine strings using string concatenation for simply combining two or more string values into a new string value.
eg. 
  
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

//The in unit 4 i learned Combine strings using string interpolation, String interpolation combines multiple values into a single literal string by using a "template" and one or more interpolation expressions.
You can combine string interpolation and verbatim literals by combining the symbols for each and using that as a prefix for the string template.
  
eg.
  
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

This is using a verbatium string literal which i told in the last journal response 
