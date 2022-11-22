// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

var TitoloLibro = "Clean Code";
var AutoreLibro = "Robert C. Martin";
long Isbn = 9780132350884;
short NumeroPagine = 431;
float Larghezza = 17.78f;
float Altezza = 23.37f;
float Profondità = 2.79f;
var Dimensioni = Larghezza + "cm x" + Altezza + "cm x" + Profondità + "cm";
float MediaValutazione = 4.7f;
int NumeroRecensioni = 4572;
bool Kindle = true;
bool CopertinaFlessibile = false;
short PesoLibro = 800;

Console.WriteLine("---------------IL LIBRO DI OGGI: "+TitoloLibro+" di "+AutoreLibro + " ----------------\n"
    + "Informazioni generiche: Presenta i principi, i modelli e le pratiche per scrivere codice pulito e \n"+
    "sfida i programmatori a leggere attentamente il codice, scoprendo cosa è giusto e cosa c'è di sbagliato in esso.\n"
    + "ISBN:"+Isbn+"\n"
    + "Numero delle pagine:" + NumeroPagine+"\n"
    + "Peso del libro:"+PesoLibro+" g"+"\n"
    + "Dimensioni del libro:"+Dimensioni+"\n"
    + "Informazioni Amazon: È la migliore applicazione pragmatica dei principi Lean al software che abbia mai visto in stampa.\n"
    + " —James O. Coplien, fondatore del progetto Pasteur Organizational Patterns\n"
    + "Numero di recensioni:"+NumeroRecensioni+" recensioni\n"
    + "Valutazione media:"+MediaValutazione+ "*"+"\n"
    + "Kindle disponibile:"+Kindle+"\n"
    + "Copertina flessibile disponibile:"+CopertinaFlessibile+"\n"
    + "------------------------------------------------------------------------------------"
    );







