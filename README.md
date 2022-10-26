# PE opdracht C# Mobile 2022-2023


### Stef Wouters (12100187@student.pxl.be)


## Screenshots

<p align="center"><img src="screenshots/Login.jpg" width="200"></p>
De loginpage heeft een Snackbar (gemaakt met communityToolKit) die laat weten of je online bent (Verbinding hebt met de API)
De Api zit niet mee in dit project maar wordt bij het grote project wel mee geupload.
De API is zelf geschreven en runt op een lokaal netwerk. Elk device op dat (wifi) netwerk kan aan de API.

In de video kan u zien dat de cursor om te typen een rode kleur heeft.

<p align="center"><img src="screenshots/Register.jpg" width="200"></p>
De registratie en Login werken al met de API de rest van de app voorlopig nog niet.
Je kan je dus wel al registreren.
Momenteel heb ik voor test redenen gezorgt dat je gewoon op login kan drukken zonder login gegevens. Zo kan u de app zelf verkennen en uittesten.

<p align="center"><img src="screenshots/Dashboard.jpg" width="200"></p>
Dashboard zijn knoppen in een grid. Dit is gewoon een test layout.
In de video ga je zien dat als ik tever naar onder scroll een rode bubbel komt. Deze heb in in colors.xml aangepast.

<p align="center"><img src="screenshots/Flyout.jpg" width="200"></p>
De flyout page krijg je enkel nadat je ingelogt bent te zien.
A.S.P is de naam voor het programma (Anti Sterf Programma) Medicatie beheer en bijhouden van persoonlijke parameters.

<p align="center"><img src="screenshots/Medication.jpg" width="200"></p>
Hier staat een lijst met al de medicatie die je ineemt. Bij het grote project ga je deze kunnen aanpassen en meldingen van krijgen als je deze moet innemen. 
Deze lijst maakt ook gebruik van een grid.

De lijst is momenteel hard coded zoals in de les gezien is, in de toekomst komt dit uit de database via de API.

<p align="center"><img src="screenshots/Weight.jpg" width="200"></p>
De chart is gemaakt met een nuget package genaamt LiveCharts2.
Deze is nog niet in full release maar momenteel werkt het al stabiel genoeg om te gebruiken in mijn app.
De gegevens zijn hard coded maar gaan voor het grote project uit de database komen.

<p align="center"><img src="screenshots/WeightToolTip.jpg" width="200"></p>
Je krijgt een soort tooltip te zien als je op de punten klikt.
Dan krijg je de gegevens van dat punt te zien.
Bijna alles aan de chart is custom. Je kan zo goed als alles zelf aanpassen.

In de video zal u zien dat ik de eerste keer een paar keer op de punten moet drukken vooralleer ik de toolTip krijg te zien. Eenmaal als dit lukt werken de andere onmiddelijk. Ik vermoed dat dit nog een bug is in LiveCharts2.

<p align="center"><img src="screenshots/O2.jpg" width="200"></p>
Extra pagina voor de toekomst.

<p align="center"><img src="screenshots/Settings.jpg" width="200"></p>
Extra pagina voor de toekomst.


Je kan bij de flyout ook terug uitloggen. De enige manier om terug in de app te geraken is door opnieuw in te loggen.
Maar voor test redenen kunt u gewoon op login drukken zodat u de app kan bekijken.


## Video

**Video Link**
https://www.youtube.com/watch?v=VjgesNBTKaI

Please Like and Subscribe ;) 


## Sources

https://lvcharts.com/ => chart op Weight pagina
https://cbea.ms/git-commit/ => goede commits schrijven
https://www.youtube.com/watch?v=dWnGoZY3XiE&t=1372s => Kleine hulp bij het maken van login flow en het hidden van de flyout bij login en registratie.

