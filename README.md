# Homework 6 and 8

6 __ Sukurti Asp.NET MVC REst Api aplikaciją, kuri leistų pridėti vaisius, daržoves, indus (peiliai, šakutes ir t.t.).
Reikalavimai:
1. Vaisiai, Indai, Daržovės yra skirtingų tipų objektai su atskirais kontroleriais jiems.
2. Kiekvienas objektas turi turėti bent Id ir pavadinimą (name).
3. Galimi veiksmai: Pridėti daržovę, ištrinti, gauti visas, gauti pagal Id, pakeisti pavadinimą.
4. Tai turi būti ištęstuota Postman bibliotekos pagalba
5. Turi būti išnaudoti Get, Post, Put, Delete Http metodų tipai.
Extra:
1. Pagooglinkite 'Generic Controller', 'Generic types' ir pakeiskite, kad vietoj 3 kontrolerių būtų vienas.
2. Pridėkite Swagger Api biblioteką, kuri aprašo jūsų RestApi.
#
8 __ Pakeisti Lesson6 užduotį, kad duomenys būtų išsaugomi duomenų bazėje. Jei per daug darbo užtenka duomenų bazę naudoti su vienu objektu, (ne su 3).
Reikalavimai:
1. Naudoti Mssql duomenų bazę.
2. Galima naudoti SqlConnection, Dapper, Entity framework Core. Patarčiau SqlConnection + Dapper, nebent pažįstat EntityFramework.
3. Programos paleidimo metu turėtų būti patikrinimas ar duomenų bazėje egzistuoja lentelės ir sukurti jei jų nėra.
4. ConnectionString turi būtų laikomas appsettings.json
5. Restartavus programą, informacija turi nepasikeisti (paimti iš duomenų bazės)
