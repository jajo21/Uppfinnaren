[![Open in Visual Studio Code](https://classroom.github.com/assets/open-in-vscode-f059dc9a6f8d3a56e377f745f24479a46679e63a5d9fe6f495e02850cd0d8118.svg)](https://classroom.github.com/online_ide?assignment_repo_id=6585065&assignment_repo_type=AssignmentRepo)
# Uppfinnaren

>Du ska skapa din första riktiga webbapplikation i C#, kunden är i detta fallet en erkänd träslöjdslärare och uppfinnare
>
>[Gå till uppgiften](https://ju.instructure.com/courses/5943/assignments/24065)

## Instruktioner

*Vad behöver göras för att ditt program ska starta och gå och använda?*
**Kräver .NET5.0 SDK** och att
**Navigera till rätt mapp och skriva "dotnet run" i terminalen**

## TODO - Kvar att göra

*Vad har du inte hunnit med i denna uppgift?*
Jag anser att jag har hunnit med allt som krävs för denna uppgift. Lägger till en checklista nedanför.

 |Krav|Uppfyllt|Egna Kommentarer|
 |---|---|---|
|**1**  |**Ja**| |
|**2**  |**Ja**| |
|**3**  |**Ja**| |
|**4**  |**Ja**| |
|**5**  |**Ja**|*En annan sida som går att besöka från webbservern visar uppfinnarens kontaktuppgifter* - **Jag uppfattade det här kravet som att man kunde göra en helt statisk sida och det har jag också gjort även om det känns lite fel efter allt vi har lärt oss de senaste veckorna :)** |
|**6**  |**Ja**| |

## Förtydliganden/motivering

*Finns det något extra du vill förtydliga med din lösning? Både bra och mindre bra*

De tillgängliga produkterna/uppfinningarna är skapade med en lämplig datastruktur med tanke på både OOP och MVC, för att vara enkla att byta ut i framtida uppdatering. Programmet är byggt med en tydlig objektorienterad struktur där en produkt utgör grunden, produkt instanser skapas för närvarande i MockProductRepository och fylls på i en lista. Ett tydligt interface finns för vad en samling produkter behöver innehålla(en lista med alla produkter samt en metod för att hämta varje enskild produkt i listan). Klassen MockProductRepository är en "mockup" eller ett exempel på hårdkodade produkter och hur produktupplägget skulle kunna se ut. I framtiden när de riktiga produkterna ska matas in på hemsidan så kan den här mockupen bytas ut till korrekt klass(och kopplas till en databas om jag har förstått det hela med databas rätt) som innehåller uppfinnarens produkter och den klassen bör även ärva IProductRepository interfacet. 

I programmet finns en ProductController som returnerar vad som kan visas på produkt-sidan från Modules när en request görs och i views finns en List.cshtml som presenterar specifikt vilken produktinformation som ska visas på sidan och hur den ska visas. Det är byggt på ett tydligt sätt så att man i praktiken inte ska behöva ändra mycket för att lägga till fler nya produkter. Det är dock möjligt att man vill ändra stylingen på sidan i framtiden för att göra det överskådligare och tydligare med fler produkter.

En del som jag tänker att jag hade kunnat gjort bättre är att inte lägga kontakt-sidan i homecontrollern. Utan att ha en "egen" controller för den, man kan tex ha en samlad controller för service/kontakt/info osv. Nu ligger kontaktsidan under homecontroller istället, jag tror inte att det är fel, men kan göras tydligare känns det som.

Har även med en bool i Product-klassen som inte används ännu, inStock som ska visa om produkter på hemsidan finns tillgänliga i lager eller inte. Den är överflödig för stunden men kan komma till användning senare. Finns såklart fler saker som kan komma till användning senare men väljer att ta det i kommande steg vid nästa krav från uppfinnaren.

Man skulle även kunna lägga till en Kategoriklass precis som i pluralsightkursen, för att kunna presentera sina produkter/sitt galleri på olika sidor beroende på vilken kategori uppfinningen/produkten tillhör. Men det är också ett tillägg som kan komma senare beroende på vad som behövs i kommande krav från uppfinnaren.