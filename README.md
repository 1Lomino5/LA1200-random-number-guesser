#  Random Number Guesser
#### Ein Spiel bei dem man eine zufällige generierte Zahl eraten werden kann, programmiert in C#.
<br>

#### Was ist das Ziel dieses Portfolios ?
###### Die Leserin oder der Leser kann am Ende dieses Beitrages einen Timer in C# erstellen und weiss wie man damit die Zeit stoppen kann. 
<br>

## Wie man einen Timer in C# erstellt

### Anleitung
Um ein Timer in C# verwenden zu können muss man folgende Schritte befolgen.

Als erstes solte man einen neuen Timer mit diesem Befehl ``Stopwatch stopWatch = new Stopwatch();`` erstellen, denn ohne den kann man die Zeit nicht stoppen.

Nun hat man einen neuen Timer erstellt, dieser an sich macht bis jetzt aber noch nichts.
Um den Timer zu starten kann man jetzt den Befehl ``stopWatch.Start();`` verwenden.

Wenn man diesen Befehl eingibt wird ab diesem Zeipunkt im Code die Zeit gemessen, um die Zeit am Ende auswerten zu können muss man als nächstes einen Stoppunkt setzten.
Der Befehl um den Timer zu stoppen lautet: ``stopWatch.Stop();``

Das die Daten am Schluss richtig angezeigt werden müssen sie noch konvertiert werden. 
Zuerst wird die gemessen Zeit in eine Variable eingefügt, 
kann man mit diesem Befehl ``ts = stopWatch.Elapsed;`` machen .  
Nun setzt man das ganze noch in das richtige Format:
``elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
 ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);``

Wenn das alles geklappt hat ist man nun bereit für den letzten Schritt, die Ausgabe.
Um das fertig Ergebniss jetzt ausgeben zu können muss man nur noch diesen Befehl ``Console.Write(elapsedTime);`` benutzen.






### Code
Um das ganze einmal bildlich darzustellen hier ein Beispiel:
 ```csharp
 Stopwatch stopWatch = new Stopwatch();
 stopWatch.Start();
 stopWatch.Stop();
 ts = stopWatch.Elapsed;
 elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
 ```
 
 ### Einbettung in einem Code
Im folgenden Video sieht man ein Beispiel wo man diesen Timer benutzen könnte.

[![Mein Foto](http://img.youtube.com/vi/i0y-RBSp8R0/0.jpg)](https://youtu.be/i0y-RBSp8R0)
Im oben verlinkten Video können Sie ein Beispiel für eine Anwendung des Timers sehen.
Am Ende sieht man die verbrauchte Zeit. Dieser Timer wurde mit der Methode erstellt welche in der Anleitung erklärt wurde.


## Verifikation
Mit der obigen Anleitung sollten eigentlich keine Fragen aufkommen, somit ist das Ziel das die Leser nun wisssen wie man einen Timer erstellt und verwendet nun hoffentlich erfüllt.

## Reflexion
Dies war mein erstes Projekt welches ich in C# umgesetzt habe. Auf dem Weg zum fertig Produkt gab es immer wieder Probleme welche gelöst werden mussten, doch das Schöne daran ist das Gefühl welches man hat, wenn man die Probleme oder Herausforderungen selber lösen konnten. Ein Problem auf das ich mehrere Male gestossen bin während dem Programmieren ist die Struktur meines Codes. Da ich noch nicht genau weiss wie man einen Code schön und richtig Strukturiert ist mein VBV (Verbesserungvorschlag) das ich bei meinem nächsten Projekt meinen Code versuche besser darzustellen. Was ich mir als Ziel setzte ist das ich mich noch in diese Richtung informiere werde und meinen Code überarbeite.
