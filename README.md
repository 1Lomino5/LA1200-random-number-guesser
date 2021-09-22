#  Random Number Gueser
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

Wenn man alles geklappt hat ist man nun bereit für den letzten Schritt, die Ausgabe.
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
 
 ### Einbetung in einem Code
Im folgenden Video sieht man ein Beispiel wo man diesen Timer benutzen könnte.

Video wird hier noch eingefügt




###











 
