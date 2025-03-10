// Today in microsoft learn i learned how to: create a charecter escape sequence on how to format the output using it 
eg.
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

and verbatium string literals which will keep all string literals without the need to escape the backslash 
eg.
Console.Write(@"c:\invoices");
Then to genarate japanese invoices 
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
you will then get:

Generating invoices for customer "Contoso Corp" ...

Invoice: 1021		Complete!
Invoice: 1022		Complete!

Output Directory:	
c:\invoices

日本の請求書を生成するには：
	c:\invoices\app.exe -j
