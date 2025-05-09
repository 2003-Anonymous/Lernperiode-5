# Lernperiode 5

2.5 bis 23.5

## Grob-Planung
Ich möchte eine Datenbank für mein Towerdefensgame erstellen, in der ich Anmeldedaten und den dazugehörigen Punktestand speichern kann. 

Heute habe ich eine Datenbank mit dem SQL-Server erstellt. Sie hat eine Tabelle logins und eine Tabelle scores. In der Tabelle logins hat es die Spalten userID, name und password. In der Tabelle scores hat es die Spalten userID und score. Dann habe ich noch Beispieldaten eingefügt. Da unser Lehrer uns erst nächstes mal erklärt, wie man diese Datenbank mit C# verbindet, habe ich mir noch ein wenig JSON beigebracht, weil das auch eine einfache Art ist, Daten zu speichern.


## 9.5 Kernfunktionalität

- [ ] Meine Datenbank mit meinem C# Projekt verbinden.
- [ ] Ein Login hinzufügen, dass man den Score zu einem bestimmten Spieler speichern kann.
      

Heute hatte ich ein Problem und zwar hat mein Projekt irgendwie eine Referenz zu sich selbst erstellt und dann hatte ich 180 Fehler. Das habe ich dann gelöst, indem ich den Stand vom letzten Freitag heruntergeladen habe und das in ein neues Projekt getan habe. So konnte ich dann wieder arbeiten. Das zu lösen hat aber die hälfte der Zeit in anspruch genommen. Nachdem ich dieses Problem gelöst habe, habe ich noch ein drittes Forms erstellt, auf dem man sich einloggen kann und erst dann startet das Spiel. Das mit dem parent hat hier am Anfang nicht so funktioniert, da das neue Forms im Namespace LP_5 ist und die anderen Forms sind im Namespace LP_4, da ich das beim lösen des anderen Problems übernommen habe und nicht einfach ändern konnte. Das habe ich dann gelöst, indem ich dort wo das Forms erstellt wird, vor das Form3 LP_5 hingeschriben habe. Zum Schluss habe ich noch eine Datenbank in Sqlite erstellt und begonnen, diese mit dem Login zu verbinden. Damit bin ich aber noch nicht fertig geworden.

## 16.5 Kernfunktionalität und Ausbau

- [ ] Das Login mit dem Forms verbinden
- [ ] Einen Score zum Spiel hinzufügen
- [ ] Den Score in der Datenbank zum dazugehörigen Login speichern
- [ ] Hizufügen, dass man ein neues Login erstellen kann, wenn man das erste mal spielt

✍️ Heute habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 23.5 Abschluss

- [ ] ...
- [ ] ... (falls Ihnen nichts einfällt: Können Sie mit einem PowerShell-Skript von Ihrer Datenbank regelmäßig ein *backup* erstellen?)
- [ ] Reflexion über Ihre Arbeitsweise
- [ ] Beschreibung des fertigen Projekts mit .gif etc.

✍️ Heute habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## Fertiges Projekt

✍️ Beschreiben Sie hier, wie Ihr Projekt am Ende aussieht, und fügen Sie mindestens ein .gif ein.

## Reflexion

✍️ Was ging gut, was ging weniger gut? Was haben Sie gelernt, und was würden Sie bei der nächsten Lernperiode versuchen besser zu machen? Fassen Sie auch einen übergeordneten Vorsatz für Ihr nächstes Jahr im Lernatelier (100 bis 200 Wörter).
