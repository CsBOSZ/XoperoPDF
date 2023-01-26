# XoperoPDF

>
> Przywrócenie tekstu do podstawowej formy
>```text
>//RRR
>```

>
> Przywrócenie koloru i rozmiaru tekstu do wartość zapisanych w szablonie
>```text
>//RR
>```

>
> Przywrócenie koloru tekstu do wartość zapisanych w szablonie
>```text
>//CR
>```

>
> Przywrócenie rozmiaru tekstu do wartość zapisanych w szablonie
>```text
>//SR
>```

>
> Przywrócenie koloru tekstu w szablonie do podstawowej formy
>```text
>//|CR
>```

>
> Przywrócenie rozmiaru tekstu w szablonie do podstawowej formy
>```text
>//|SR
>```

>
> Ustawienie koloru tekstu
>```text
>      R   G   B
>//CS>200|200|200
>```

>
> Ustawienie koloru tekstu w szablonie
>```text
>       R   G   B
>//|CS>200|200|200
>```

>
> Ustawienie rozmiaru tekstu
>```text
>    size
>//SS>40
>```

>
> Ustawienie rozmiaru tekstu w szablonie
>```text
>     size
>//|SS>40
>```

>
> Ustawienie koloru nagłówka
>```text
>     H1-H3
>       ^  R   G   B
>//|HCS>1|200|200|200
>```

>
> Ustawienie rozmiaru nagłówka
>```text
>     H1-H3
>       ^size
>//|HSS>1|20
>```

>
> Przywrócenie koloru nagłówka do podstawowej wersji
>```text
>     H1-H3
>//|HCR>1
>```

>
> Przywrócenie rozmiaru nagłówka do podstawowej wersji
>```text
>     H1-H3
>//|HSR>1
>```

>
> Przywrócenie rozmiaru i koloru nagłówka do podstawowej wersji
>```text
>     H1-H3
>//|HRR>1
>```

>
> Użycie szablonu nagłówka
>```text
>//H1 or //H2 or //H3
>```

>
> Dodanie linku
>```text
>         URL
>//AS>http//:URL
>```

>
> Wyczyszczenie z linku
>```text
>//AR
>```

>
> Wstawienie Zdjęcie
>```text
>                               Height
>            path           Width ^
>//IMG>/home/user/abibab.png|200|200
>```

>
> Wstawienie tabelki
>```text
>WidthPercentage
>      ^ numColumns
>//TAB>80|3|column1_row1|column2_row1|column3_row1|column1_row2|column2_row2|column3_row2
>```

>
> Ustawienie autora
>```text
>//AUTHOR>author
>```

>
> Ustawienie tytułu
>```text
>//TITLE>title
>```



