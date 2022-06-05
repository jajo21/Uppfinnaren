# Uppfinnaren 2.0 - December 2021
## Instruktioner
1. Ladda ner repot från https://github.com/jajo21/Uppfinnaren
2. Leta upp valfri terminal och utgå från mappen "./Uppfinnaren"
3. Applikationen kräver att du har .NET5.0 SDK installerat
4. Skriv kommandot ```dotnet run``` i terminalen
5. Applikationen körs nu på port 5000 och 5001
6. Öppna en webbläsare och navigera in på https://localhost:5001/

## Syfte - YH-utbildning: Webbutvecklare .NET
* Inlämningsuppgift i kursen Dynamiska Webbsystem 1 - December 2021
* Beskrivning: Målet i denna uppgift är att utveckla en dynamisk webbapplikation med ASP.NET och designmönstret MVC. I denna uppgift ska jag skapa min första riktiga webbapplikation i C#, kunden är i detta fallet en erkänd träslöjdslärare och uppfinnare som i många år sålt sina tokiga skapelser lokalt, men nu vill nå ut till en bredare publik, och därför anlitat mig som webbutvecklare. Uppfinnaren, d.v.s. min kund i denna uppgift, vill komma igång snabbt med en hemsida där hen kan visa upp sina skapade altser i ett digitalalt galleri - ungefär som produkter i en vanlig webbbutik - men om möjligt med en mer kreativ touch. I framtiden kommer ni tillsammans vidareutveckla hemsidan med stöd för beställningar - men klart till denna inlämning vill hen först sen en ganska enkel sida.
* Resultat: Version 1 = 100/100(G), Version 2 = 100/100 (VG)

## Tekniker
* C#
* ASP.NET MVC
* ASP.NET Entity Framework med UseInMemoryDatabase
* xUnit
* Razor

## Kravspecifikation
 |Krav|Uppfyllt|Egna Kommentarer|
 |---|---|---|
|**1**  |**Ja**| *Lösningen ska vid inlämning vara körbar med .NET Core* |
|**2**  |**Ja**| *Den inlämnade lösningen är en vidareutveckling av inlämning i föregående uppgift*|
|**3**  |**Ja**| *Minst fyra ytterligare sidor ska ha lagts till i lösningen, samtliga ska visa produkter av en enskild kategori. 1 ny sida per kategori. Detta kan göras med en dynamisk sida eller fyra statiska sidor.* |
|**4**  |**Ja**| *Alstren som visas på alla 5 galleri-sidor ska vara hämtade från en databas via Entity Framework* |
|**5**  |**Ja**| *Entity Framework används med en databaskoppling till en tillfällig databas via metoden `UseInMemoryDatabase`.*|
|**6**  |**Ja**| *Minst två enhetstester har skapats till lösningen.*|
|**7**  |**Ja**| *Ett enhetstest kontrollerar så att produkter av en given kategori kan filtreras ut från domänlogiken (förslagsvis ett Repository)* |
|**8**  |**Ja**| *Lösningen ska förutom kod innehålla en fil med namnet "reflections" i formatet md, txt eller pdf* |
|**9**  |**Ja**| *reflections-filen ska under rubrik "Ursprung" innehålla en kort analys (1-3 paragrafer) över hur applikationen var uppbyggd i början av arbetet. Svara på vilka delar som var svåra respektive enkla att uppdatera i detta arbete.* |
|**10**  |**Ja**| *	reflections-filen ska under rubriken "Resultat" en kort analys över förändringarna i kodstrukturen när du lämnar in, fokusera på nya funktioner och egenskaper som underlättar underhåll samt vidareutveckling. Kom ihåg att motivera dina ställningstaganden! (2-4 paragrafer).* |
|**11**  |**Ja**| *reflections-filen innehåller en lista över skapade Enhetstester samt motiverar på vilket sätt de bidrar till att göra applikationen enklare att underhålla och vidareutveckla* |
