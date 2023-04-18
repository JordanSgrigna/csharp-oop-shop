using csharp_oop_shop;

Prodotto prodottoUno = new Prodotto("Prodottolino", "Primo prodotto", 500f);

Console.WriteLine(prodottoUno.PriceWithTax);
Console.WriteLine(prodottoUno.NamePlusCode);
Console.WriteLine(prodottoUno.FormattedCode);
Console.WriteLine(prodottoUno.Price);
