# Lernperiode 5
2.5 bis 23.5

## Grobplanung
Ich möchte eine Datenbank für mein Tower-Defense-Game erstellen, in der ich Anmeldedaten und den dazugehörigen Punktestand speichern kann.

Heute habe ich eine Datenbank mit dem SQL Server erstellt. Sie hat eine Tabelle logins und eine Tabelle scores. In der Tabelle logins gibt es die Spalten userID, name und password. In der Tabelle scores gibt es die Spalten userID und score. Dann habe ich noch Beispieldaten eingefügt. Da unser Lehrer uns erst nächstes Mal erklärt, wie man diese Datenbank mit C# verbindet, habe ich mir noch ein wenig JSON beigebracht, weil das auch eine einfache Art ist, Daten zu speichern.

## 9.5 Kernfunktionalität
- [x] Meine Datenbank mit meinem C#-Projekt verbinden.
- [x]  Ein Login hinzufügen, damit man den Score zu einem bestimmten Spieler speichern kann.


Heute hatte ich ein Problem, und zwar hat mein Projekt irgendwie eine Referenz zu sich selbst erstellt, wodurch 180 Fehler entstanden sind. Das habe ich gelöst, indem ich den Stand vom letzten Freitag heruntergeladen und in ein neues Projekt eingefügt habe. So konnte ich wieder weiterarbeiten. Das zu lösen hat jedoch die Hälfte der Zeit in Anspruch genommen.

Nachdem ich dieses Problem gelöst hatte, habe ich noch ein drittes Form erstellt, auf dem man sich einloggen kann – erst danach startet das Spiel. Das mit dem parent hat hier am Anfang nicht funktioniert, da das neue Form im Namespace LP_5 ist und die anderen Forms im Namespace LP_4, da ich das beim Lösen des vorherigen Problems übernommen habe und nicht einfach ändern konnte. Das habe ich dann gelöst, indem ich beim Erstellen des Forms LP_5. vor Form3 geschrieben habe. Zum Schluss habe ich noch eine Datenbank in SQLite erstellt und begonnen, diese mit dem Login zu verbinden. Damit bin ich aber noch nicht fertig geworden.

## 16.5 Kernfunktionalität und Ausbau
- [x] Das Login mit dem Form verbinden
- [x] Einen Score zum Spiel hinzufügen
- [x] Den Score in der Datenbank zum dazugehörigen Login speichern
- [x] Hinzufügen, dass man ein neues Login erstellen kann, wenn man das erste Mal spielt


Heute habe ich die Datenbank mit meinem Spiel verbunden. Wenn die Burg zerstört wird, wird die aktuelle Goldmenge als Highscore in der Datenbank gespeichert.
Hier hatte ich zuerst Probleme, da ich beim relativen Pfad zur Datenbank eine Ebene vergessen hatte. Dann wurde immer angezeigt, dass die Tabelle nicht existiert. Ich habe eine Weile gebraucht, bis ich den Fehler gefunden habe.
Ich habe noch einen anderen Fehler gefunden, bei dem ich noch nicht genau weiß, warum er auftritt. Es kommt immer eine Fehlermeldung, wenn ich das Spiel schließe. Der Highscore wird aber trotzdem gespeichert. Ich glaube, der Fehler hängt irgendwie mit den Projektilen zusammen. Ich habe versucht, ihn zu beheben, das hat aber nicht funktioniert.
Dann habe ich noch das Anmelde-Form mit der Datenbank verbunden. Es liest jetzt die Logindaten aus der Datenbank aus.

## 23.5 Abschluss
- [x] Den Fehler vom letzten Mal lösen
- [x]  Hinzufügen, dass man ein neues Login erstellen kann

Heute habe ich den Fehler vom letzten Mal gelöst. Das Problem war, dass die Gegner, wenn man das Spiel verloren hatte, weitergelaufen sind, obwohl sie keinen nächsten Punkt mehr in ihrem Pfad hatten. Der nächste Punkt war also außerhalb des Arrays. Das habe ich behoben, indem jetzt zuerst überprüft wird, ob es einen nächsten Punkt gibt. Wenn nicht, löscht sich der Gegner.
Dann habe ich noch hinzugefügt, dass man beim ersten Spielstart ein neues Login erstellen kann, welches dann in der Datenbank gespeichert wird.
Zum Schluss habe ich noch versucht zu programmieren, dass man die Türme auch upgraden kann, damit der Highscore noch mehr Sinn ergibt. Das ist mir aber in der Zeit noch nicht ganz gelungen.

# Fertiges Projekt
In dieser Lernperiode habe ich eine Datenbank zu meinem Tower-Defense-Game hinzugefügt, in der Logindaten und der Highscore gespeichert werden. Bevor man das Spiel beginnt, muss man sich entweder einloggen oder einen neuen Account erstellen. Es ist nicht möglich, zwei Accounts mit dem gleichen Benutzernamen zu erstellen. Wenn man einen neuen Account erstellt hat, kann man sich einloggen und mit dem Spiel beginnen. Wenn die Basis zerstört wird, wird die aktuelle Goldmenge als Highscore dem passenden Benutzernamen in der Datenbank zugewiesen.

![LP_5](https://github.com/user-attachments/assets/822008dc-26ac-4450-87bb-7b16eb0e5089)


## Reflexion
Zuerst habe ich mich nicht auf diese Lernperiode gefreut, da mir SQL nicht so sehr gefallen hat. In Kombination mit C# hat es aber eigentlich viel Spaß gemacht. Ich habe etwas sehr Nützliches gelernt, nämlich wie ich meine Daten neben Text- und JSON-Dateien auch in einer Datenbank speichern kann. SQLite ist auch nicht so kompliziert, und wenn man es einmal verstanden hat, ist es relativ einfach.
Bei mir hat auch alles geklappt, außer dass ich einmal bei einer SQL-Query Klammern vergessen habe und es dadurch nicht funktioniert hat. Diesen Fehler habe ich zum Glück schnell bemerkt und beheben können. Danach hat alles super geklappt.
