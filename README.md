# Uppfinnaren 1.0 - December 2021
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
* Resultat: 100/100 (G)

## Tekniker
* ASP.NET MVC
* C#
* Razor

## Kravspecifikation
 |Krav|Uppfyllt|Förklaring|
 |---|---|---|
|**1**  |**Ja**| *Lösningen ska bestå av en applikation skriven i C# som är körbar med .NET Core* |
|**2**  |**Ja**| *Applikationen använder ASP.NET för att starta en webbserver* |
|**3**  |**Ja**| *En sida som går att besöka från webbservern listar de skapelser (alster) som uppfinnaren vill visa upp* |
|**4**  |**Ja**| *En annan sida som går att besöka från webbservern visar uppfinnarens kontaktuppgifter* |
|**5**  |**Ja**| *Applikationen ska vara vara strukturerad med designmönstret "Model, View, Controller" (MVC)* |
|**6**  |**Ja**| *Dom tillgängliga alstren är skapade med en lämplig datastruktur och används från en lämplig plats för att senare uppdatera programmet. Motivering för detta finns i README.md filen* |

## Förtydliganden/motivering
*Finns det något extra du vill förtydliga med din lösning? Både bra och mindre bra*

De tillgängliga produkterna/uppfinningarna är skapade med en lämplig datastruktur med tanke på både OOP och MVC, för att vara enkla att byta ut i framtida uppdatering. Programmet är byggt med en tydlig objektorienterad struktur där en produkt utgör grunden, produkt instanser skapas för närvarande i MockProductRepository och fylls på i en lista. Ett tydligt interface finns för vad en samling produkter behöver innehålla(en lista med alla produkter samt en metod för att hämta varje enskild produkt i listan). Klassen MockProductRepository är en "mockup" eller ett exempel på hårdkodade produkter och hur produktupplägget skulle kunna se ut. I framtiden när de riktiga produkterna ska matas in på hemsidan så kan den här mockupen bytas ut till korrekt klass(och kopplas till en databas om jag har förstått det hela med databas rätt) som innehåller uppfinnarens produkter och den klassen bör även ärva IProductRepository interfacet. 

I programmet finns en ProductController som returnerar vad som kan visas på produkt-sidan från Modules när en request görs och i views finns en List.cshtml som presenterar specifikt vilken produktinformation som ska visas på sidan och hur den ska visas. Det är byggt på ett tydligt sätt så att man i praktiken inte ska behöva ändra mycket för att lägga till fler nya produkter. Det är dock möjligt att man vill ändra stylingen på sidan i framtiden för att göra det överskådligare och tydligare med fler produkter.

En del som jag tänker att jag hade kunnat gjort bättre är att inte lägga kontakt-sidan i homecontrollern. Utan att ha en "egen" controller för den, man kan tex ha en samlad controller för service/kontakt/info osv. Nu ligger kontaktsidan under homecontroller istället, jag tror inte att det är fel, men kan göras tydligare känns det som.

Har även med en bool i Product-klassen som inte används ännu, inStock som ska visa om produkter på hemsidan finns tillgänliga i lager eller inte. Den är överflödig för stunden men kan komma till användning senare. Finns såklart fler saker som kan komma till användning senare men väljer att ta det i kommande steg vid nästa krav från uppfinnaren.

Man skulle även kunna lägga till en Kategoriklass precis som i pluralsightkursen, för att kunna presentera sina produkter/sitt galleri på olika sidor beroende på vilken kategori uppfinningen/produkten tillhör. Men det är också ett tillägg som kan komma senare beroende på vad som behövs i kommande krav från uppfinnaren.