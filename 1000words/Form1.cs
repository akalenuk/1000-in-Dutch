using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1000words {

    public partial class Form1 : Form {

        string[] dutch = new string[1000] {"de", "van", "of", "een", "het", "en", "voor", "op", "naar", "om", "niet", "te", "zijn", "moet", "wordt", "worden", "indien", "met", "deze", "dat", "daar", "er", "alle", "aan", "punt", "lijst", "als", "dit", "eerste", "bij", "as", "punten", "vlak", "geen", "door", "laatste", "die", "geweest", "nog", "functie", "uit", "maar", "lijn", "dan", "al", "hier", "over", "kan", "aantal", "ook", "nu", "moeten", "gesloten", "kunnen", "volgende", "waarde", "gegeven", "enkel", "dus", "driehoek", "rond", "begin", "tot", "na", "zoeken", "toe", "terug", "reeds", "positie", "andere", "per", "mensen", "haar", "nieuw", "niuewe", "ik", "wegschrijven", "verwijderen", "geval", "testen", "richting", "zijde", "via", "lengte", "ze", "staat", "rij", "bepalen", "zodat", "tussen", "nodig", "achteraan", "invoegen", "eigen", "eerst", "niets", "loop", "heeft", "gaan", "eindpunt", "einde", "dezelfde", "buiten", "berekenen", "transformatie", "lus", "boven", "jaar", "meer", "initialisatie", "basis", "anders", "vooraan", "onder", "omdat", "minimum", "hebben", "afstand", "zeker", "identiek", "correct", "alles", "zal", "tabel", "stappen", "gewoon", "deleten", "zoek", "voeg", "mogelijk", "kolom", "goed", "gezet", "ben", "wel", "versie", "toegevoegd", "snijpunt", "lijnen", "kijken", "geheugen", "dimensie", "weg", "vermits", "vanaf", "snijden", "pas", "laag", "koppel", "klasse", "gebruik", "driehoeken", "binnen", "berekening", "beeld", "volledig", "twee", "staan", "spreiden", "rotatie", "put", "keep", "invullen", "even", "deel", "waar", "verwerking", "verschillende", "teken", "rechts", "mogen", "liggen", "lets", "kleur", "gebruiken", "extra", "beginpunt", "alleen", "welke", "tijd", "juiste", "goede", "eventueel", "afhankelijk", "vooral", "mijn", "heel", "komt", "zonder", "zetten", "wijzen", "waarschuwing", "waarbij", "verschillen", "toevoegen", "plaatsen", "palet", "kleuren", "iets", "hoek", "gelijk", "blok", "altijd", "aangepast", "zelf", "stap", "rand", "plaats", "openen", "nemen", "maken", "lijnstuk", "laten", "inlezen", "informatie", "houden", "gebeuren", "elkaar", "dubbel", "bewaren", "beide", "allocatie", "afronden", "aanmaken", "zowel", "zou", "zolang", "zo", "vinden", "vergemakkelijken", "totdat", "toch", "snijding", "oude", "normaal", "hetzelfde", "happen", "gedeelte", "been", "zet", "werd", "vullen", "vlakken", "verwerken", "tweede", "tijdens", "sluit", "resultaat", "kijk", "intern", "halen", "grootte", "eruit", "eronder", "erboven", "eens", "doos", "doen", "beginnen", "af", "achter", "zorg", "zit", "willen", "visualisatie", "verschil", "vanuit", "uitrekken", "these", "teller", "steeds", "spiegel", "soort", "principe", "onderste", "leeg", "juist", "inkrimpen", "idem", "gevormd", "formule", "filenaam", "ervoor", "eenheid", "controle", "automatisch", "wat", "wanneer", "vrij", "voegen", "venster", "vandaar", "stoppen", "stelsel", "sectie", "opvragen", "opvolger", "omzetten", "omgekeerd", "naam", "most", "minstens", "minst", "meerdere", "mee", "lijsten", "laatst", "komen", "koen", "kant", "u", "je", "invers", "hoogte", "gedeeltelijk", "exclusief", "delen", "centrum", "bijgevoegd", "bevatten", "bestaan", "bepaald", "zich", "werken", "weet", "wederom", "volgens", "vlag", "verwijzing", "vervangen", "vergelijking", "tegengestelde", "storing", "standaard", "spiegelen", "sluiten", "schuif", "scherm", "samen", "roteren", "registratie", "ramp", "projectie", "onze", "oneindig", "omwille", "ofwel", "groter", "geven", "geraken", "gedaan", "fout", "formaat", "extensie", "expliciet", "ed", "drie", "disk", "deelgebied", "bovenste", "blokken", "blijven", "berekend", "bepaling", "ander", "alloceren", "allemaal", "zoals", "zien", "weten", "waren", "vroeger", "vraag", "voorlopig", "volgend", "verwijderd", "vermijden", "verder", "veranderen", "veel", "typen", "totaal", "tekenfunctie", "submenu", "speciaal", "sorteren", "soms", "resolutie", "rekening", "rechtstreeks", "piek", "oplossing", "ons", "oneven", "onderkant", "onderaan", "omzetting", "omdraaien", "nadat", "mooi", "moment", "misschien", "men", "lopen", "lineair", "lid", "lezen", "kinderen", "keer", "ja", "interne", "ingesteld", "hiervoor", "hierboven", "herhalen", "haal", "groot", "getal", "gereserveerd", "genoeg", "gemeenschappelijk", "ervan", "elke", "eigenlijk", "controleren", "continue", "bovenaan", "afgeleid", "aanvraag", "aanpassen", "zullen", "zorgen", "zitten", "zin", "wis", "wil", "werking", "welk", "waarschijnlijk", "waarop", "waarin", "voorzien", "volgorde", "voeren", "vertrekken", "verondersteld", "verhouding", "vergroten", "vast", "variabele", "transparant", "toekenning", "tijdelijk", "tellen", "telkens", "tegen", "tegelijkertijd", "taken", "systeem", "structuur", "starten", "schrijven", "relevant", "reden", "rechtsdraaiend", "raakpunt", "positief", "overlapping", "opvullen", "opschuiven", "oproepen", "oplossen", "onmogelijk", "onafhankelijk", "omgekeerde", "nooit", "noodzakelijk", "natuurlijk", "muis", "minder", "meter", "maximaal", "manier", "loper", "linksdraaiend", "leest", "leegmaken", "lagen", "laat", "kopie", "keren", "inclusief", "implementatie", "ieder", "hun", "hulp", "hoofdlijn", "hoe", "hij", "hierbij", "hem", "groepen", "grenzen", "gewijzigd", "geldig", "garanderen", "fractie", "exact", "erg", "draairichting", "doorlopen", "diagonaal", "daarom", "daarna", "commentaar", "bovengrens", "blijkbaar", "blijft", "beter", "beperkt", "beiden", "behouden", "behalve", "afleiden", "achterkant", "absoluut", "aansluiting", "jaren", "miljoen", "zwart", "zouden", "zoon", "zojuist", "zichzelf", "zichtbaar", "zelfde", "zeggen", "zaken", "wissel", "wijziging", "wijzigen", "wijzer", "weinig", "wegsmijten", "waarvan", "waardoor", "vrijgeven", "voorkomen", "volgen", "voldoende", "virtueel", "verzetten", "verzet", "verwacht", "verticaal", "verschillend", "veronderstellen", "vermindering", "verminderen", "verminderd", "verkleind", "vergelijken", "verdwijnen", "verdubbeling", "verdergaan", "velden", "veld", "veiligheid", "veelvoud", "vastleggen", "vallen", "val", "uitzonderingsgeval", "uitschrijven", "uitleg", "uiten", "tussenafstand", "translatie", "transformatiematrix", "toestemming", "toekennen", "terugzetten", "tekenfuncties", "tekenen", "tegenkomen", "succes", "stuiten", "stel", "stag", "snijvlak", "snel", "slechts", "slaan", "sla", "rondsturen", "roepen", "reserveren", "renderen", "rechte", "randen", "perforatie", "pennen", "passen", "overschrijven", "overloop", "overeenkomen", "overeen", "oppervlakte", "operatie", "onveranderd", "onnozel", "onderzoeken", "ondergrens", "omtrek", "normaliseren", "non", "niveau", "niks", "netwerk", "negatief", "nabijheid", "middelen", "merkteken", "mekaar", "markeren", "map", "linkerdeel", "let", "laagdikte", "krijgen", "kop", "konden", "kloppen", "klassen", "kind", "kiezen", "kap", "inversie", "ineens", "indices", "inbouwen", "iedere", "horizontaal", "hoeveel", "hoeken", "hiervan", "hierna", "hierin", "hertekend", "helft", "hangen", "groep", "grijs", "grens", "gevraagd", "getekend", "gelegen", "gelden", "gekend", "gehouden", "gebieden", "gaten", "extern", "evenwijdig", "evenredig", "ertussen", "erop", "ernaar", "erbij", "enig", "ene", "elk", "eenzelfde", "eenvoudig", "eentje", "dumpen", "doorschuiven", "dichter", "dicht", "derde", "deling", "definitie", "deeltje", "daarvan", "bouwen", "boom", "boog", "bewegen", "beste", "beslissen", "behandeling", "bedoeld", "auto", "arcering", "apart", "analoog", "afsluiten", "achtergrond", "aanwezig", "aanroepen", "aanpassing", "zoveel", "zon", "zodoende", "zij", "zeer", "wout", "wit", "wist", "wisselen", "wijze", "werk", "weer", "waarmee", "vulling", "vroegere", "vrije", "vorm", "voordat", "voorbereiden", "vonden", "voer", "vlaggen", "visualiseren", "vier", "verwezen", "verplicht", "verplaatsen", "veronderstelling", "verhinderen", "vergewissen", "vergelijkbaar", "vereiste", "verdubbelen", "verdere", "verbonden", "verband", "verandering", "uniek", "uitwisselbaar", "uitvoering", "uitvoeren", "uitstaan", "uitsluitend", "uitslag", "uiteinde", "typisch", "troep", "trimmen", "trekken", "transparantie", "transformeren", "traag", "tijdverlies", "thuis", "tevoren", "terugkeren", "teruggeven", "terecht", "ter", "tekening", "sturen", "stukken", "stuk", "straks", "straal", "stelt", "stellen", "statistiek", "startpunt", "startpositie", "springen", "specifiek", "snelheid", "slecht", "situatie", "simpel", "selecteren", "schuldige", "schijf", "schaal", "scan", "samenvallen", "ruimte", "rotatieas", "ronde", "respectievelijk", "relatief", "referentie", "reductie", "redelijk", "rechtsonder", "rechthoek", "raar", "puur", "puntenlijst", "procent", "probleem", "proberen", "printen", "plateau", "parabool", "overschot", "overnemen", "overlopen", "overige", "overgaan", "ouders", "opslaan", "oppervlak", "opmerking", "opkuisen", "opdat", "opbouw", "oorspronkelijk", "onvermijdelijk", "ontstaan", "onszelf", "onmiddellijk", "ongewijzigd", "ongeveer", "ondersteuning", "ondersteunen", "omringen", "omkeren", "nuttig", "nummer", "negeren", "neer", "nee", "namen", "namelijk", "nakijken", "naast", "naartoe", "naargelang", "mogelijkheid", "mislopen", "minima", "middelpunt", "middeling", "meteen", "merken", "meestal", "meest", "meemaken", "meegeven", "macht", "maart", "losse", "loodrecht", "loodlijn", "lies", "leiden", "leggen", "leg", "lage", "lag", "kwadraat", "kleine", "klaar", "kijkrichting", "kies", "ketting", "kennis", "kaarten", "interpreteren", "interpretatie", "interpoleren", "interessant", "insluipen", "inhoud", "ingevoerd", "indiener", "immers", "hulpje", "huidig", "hou", "hope", "hoogst", "hoofd", "hoge", "hieruit", "herstel", "hernoemen", "herberekening", "heb", "halve", "grote", "globaal", "gewezen", "gevolg", "gevallen", "gerelateerd", "geplaatst", "geordend", "gemakkelijk", "gemaakt", "gelijke", "gebruiker", "gebrek", "functionaliteit", "filteren", "fataal", "extractie", "eveneens", "evaluatie", "ergens", "equivalent", "enige", "ende", "eindresultaat", "eind", "eenvoudigweg", "duiden", "dubbele", "doorzenden", "doorgeven", "domme", "destructie", "debuggen", "daarop", "cruciaal", "corrigeren", "coordinaat", "convergeren", "conceptueel", "constatering", "configuratie", "concreet", "concluderen", "compensatie", "combineren", "coderen", "circa", "cijfer", "categorie", "casus", "calculeren", "capaciteit", "convertor", "conversie", "constructie", "consequent", "connectie", "conform", "comprimeren", "compatibiliteit", "combinatie", "cirkelboog", "checken", "casten", "breken", "breedte", "bovendien", "bouw", "bootsen", "boodschap", "binnenkrijgen", "bijkomend", "bijhouden", "bezet", "bewerking", "beslissing", "beschrijving", "beschouwen", "bereik", "benodigdheden", "belangrijk", "bekijken", "bekeken", "beheer", "bedoeling", "basisinformatie", "assen", "andersom", "alsof", "allerlaatste", "allereerste", "afwisselen", "afwijking", "afwerken", "afronding", "afleiding", "afknotten", "afgesloten", "afgeleide", "afdruk", "adres", "achterom", "achtergrondkleur", "achteren", "achteraf", "aanzicht", "aanvaarden", "aansluiten", "aanmaak", "aangegeven", "aangeduid", "aanbrengen"};

        string[] english = new string[1000] {"the", "of", "or", "a", "the", "and", "for", "on", "to", "to", "not", "to", "are", "must", "is", "be", "if", "with", "this", "that", "there", "there", "all", "to", "point", "list", "as", "this", "first", "at", "axis", "points", "surface", "no", "through", "last", "which", "been", "afurther", "function", "from", "but", "line", "than", "all", "here", "about", "may", "number", "also", "now", "should", "closed", "may", "following", "value", "given", "only", "so", "triangle", "around", "beginning", "to", "after", "search", "to", "back", "already", "position", "another", "per", "people", "her", "new", "new", "I", "saving", "removing", "case", "testing", "direction", "side", "through", "length", "they", "state", "row", "determine", "sothat", "between", "needed", "rear", "insert", "own", "first", "nothing", "over", "has", "go", "endpoint", "end", "same", "outside", "calculating", "transformation", "loop", "above", "year", "more", "initialization", "base", "otherwise", "front", "under", "because", "atleast", "have", "distance", "certainly", "identical", "right", "all", "willbe", "table", "steps", "just", "delete", "search", "add", "possibly", "column", "good", "put", "am", "well", "version", "added", "intersection", "lines", "look", "memory", "dimension", "route", "since", "from", "cutting", "only", "low", "torque", "class", "use", "triangles", "within", "calculation", "image", "fully", "two", "stand", "spread", "rotation", "well", "notch", "fill", "just", "part", "where", "processing", "several", "sign", "right", "may", "lie", "something", "color", "using", "additional", "starting", "only", "which", "time", "right", "good", "possibly", "depending", "especially", "my", "very", "comes", "without", "convert", "point", "warning", "killing", "differences", "add", "places", "palette", "colors", "something", "angle", "equal", "block", "always", "adjusted", "self", "step", "edge", "place", "open", "take", "make", "segment", "let", "read", "information", "hold", "happen", "assembling", "double", "keep", "both", "allocation", "rounding", "creating", "both", "would", "while", "so", "find", "facilitate", "until", "anyway", "intersection", "old", "normal", "thesame", "mouthfuls", "portion", "leg", "set", "was", "filling", "faces", "processing", "second", "during", "closes", "result", "look", "internal", "get", "size", "out", "below", "above", "once", "box", "do", "start", "off", "rear", "care", "sitting", "want", "visualization", "difference", "from", "stretching", "thesis", "counter", "still", "mirror", "type", "principle", "lower", "empty", "just", "contract", "ditto", "formed", "formula", "filename", "before", "unit", "control", "automatic", "what", "when", "free", "add", "window", "hence", "stop", "scheme", "section", "retrieve", "successor", "converting", "conversely", "name", "musts", "atleast", "atleast", "multiple", "note", "lists", "last", "come", "valorous", "side", "you", "you", "inverse", "height", "part", "excluding", "parts", "center", "added", "contain", "consist", "determined", "self", "work", "know", "again", "under", "flag", "reference", "replacing", "compare", "reverse", "failure", "standard", "mirroring", "close", "slide", "screen", "together", "rotate", "registration", "disaster", "projection", "our", "infinity", "reasons", "either", "more", "give", "get", "made", "error", "size", "extension", "explicitly", "etc", "three", "disc", "subarea", "top", "blocks", "stay", "calculated", "clause", "another", "allocate", "all", "suchas", "see", "namely", "were", "previously", "question", "provisionally", "next", "removed", "avoid", "further", "change", "many", "types", "total", "drawingfunction", "sub", "special", "sorting", "sometimes", "resolution", "bill", "straight", "peak", "solution", "us", "odd", "bottom", "down", "conversion", "turn", "after", "nice", "currently", "maybe", "people", "walk", "linear", "paragraph", "reading", "children", "times", "yes", "internal", "set", "this", "above", "repeat", "get", "big", "number", "reserved", "enough", "common", "thereof", "every", "actually", "check", "continuous", "top", "derived", "request", "adjust", "willbe", "care", "down", "sentence", "clear", "wishes", "operation", "which", "probably", "inwhich", "inwhich", "provide", "order", "perform", "leave", "assumed", "ratio", "enlarge", "solid", "variable", "transparent", "award", "temporary", "count", "each", "against", "while", "tasks", "system", "structure", "starting", "write", "relevance", "reason", "clockwise", "tangentpoint", "positive", "lap", "fill", "move", "calls", "solving", "impossible", "independent", "reverse", "never", "necessary", "ofcourse", "mouse", "less", "m", "upto", "way", "runner", "counterclockwise", "reads", "unloading", "layers", "leave", "copy", "times", "including", "implementation", "every", "their", "help", "heading", "how", "he", "this", "him", "groups", "borders", "changed", "valid", "guarantee", "group", "exactly", "very", "direction", "through", "diagonal", "therefore", "thereafter", "comments", "limit", "apparently", "remains", "better", "limited", "both", "maintain", "except", "distract", "back", "absolutely", "terminal", "years", "million", "black", "would", "son", "just", "itself", "visible", "same", "say", "business", "ac", "change", "change", "needle", "little", "throwaway", "ofwhich", "toafford", "release", "prevent", "track", "enough", "virtual", "move", "resistance", "expects", "vertical", "different", "suppose", "reduction", "reduce", "decreased", "decreased", "compare", "disappear", "doubling", "proceed", "fields", "field", "safety", "multiplicity", "capture", "fall", "fall", "exceptionalcase", "unsubscribe", "explanation", "express", "spacing", "translation", "transformationmatrix", "permission", "assigning", "restore", "drawingfunctions", "signs", "encounter", "success", "encounter", "set", "forestay", "cuttingedge", "fast", "only", "beat", "beat", "sendround", "call", "reserve", "render", "straight", "edges", "perforation", "pens", "fit", "overwrite", "overflow", "match", "match", "surface", "surgery", "unchanged", "silly", "studies", "limit", "perimeter", "normalize", "nun", "level", "nothing", "network", "negative", "proximity", "means", "mark", "eachother", "mark", "folder", "left", "note", "thickness", "get", "head", "could", "beat", "classes", "child", "choose", "hood", "inversion", "suddenly", "indexes", "install", "every", "horizontal", "number", "corners", "this", "below", "herein", "redrawn", "half", "hang", "group", "gray", "limit", "asked", "signed", "located", "apply", "known", "held", "regions", "holes", "external", "parallel", "commensurate", "between", "note", "forward", "there", "any", "one", "each", "thesame", "simple", "one", "dump", "bysliding", "poet", "close", "third", "division", "definition", "particle", "thereof", "build", "tree", "bow", "move", "best", "rule", "treatment", "meant", "auto", "shading", "separate", "analog", "close", "background", "present", "call", "adjustment", "asmuchas", "sun", "thus", "they", "very", "fuzz", "white", "erasure", "exchange", "mode", "work", "again", "to", "filling", "previous", "free", "form", "before", "preparing", "found", "enter", "flags", "visualize", "four", "referenced", "required", "move", "assumption", "prevent", "ensure", "similar", "required", "double", "further", "connected", "napkin", "change", "unique", "interchangeability", "version", "perform", "outstanding", "only", "result", "end", "typically", "gang", "trimming", "draw", "transparency", "transform", "slow", "lossoftime", "home", "before", "return", "return", "go", "in", "drawing", "send", "pieces", "piece", "soon", "jet", "represents", "set", "statistics", "starting", "startingposition", "jump", "specifically", "speed", "only", "situation", "simple", "selection", "culprit", "disk", "scale", "scanning", "coincide", "space", "rotation", "round", "respectively", "relative", "reference", "reduction", "reasonable", "lowerright", "rectangle", "odd", "pure", "pointslist", "percent", "issue", "try", "printing", "platform", "parabola", "surplus", "takeover", "browse", "remaining", "pass", "parents", "saving", "surface", "note", "cleanup", "thatone", "building", "originally", "inevitable", "genesis", "ourselves", "immediately", "unchanged", "about", "support", "support", "surround", "invert", "useful", "number", "ignoring", "down", "no", "names", "namely", "check", "next", "go", "depending", "option", "miss", "minimum", "center", "averaging", "immediately", "brands", "usually", "most", "experience", "give", "power", "march", "loose", "perpendicular", "perpendicular", "loss", "lead", "put", "put", "low", "was", "square", "small", "finished", "viewingdirection", "choose", "necklace", "knowledge", "cards", "interpreting", "interpretation", "interpolate", "interesting", "creep", "content", "imported", "submitter", "after", "helper", "current", "keeping", "hopefully", "highest", "head", "high", "therefrom", "recovery", "rename", "recalculation", "i", "half", "large", "global", "former", "result", "cases", "related", "posted", "ordered", "easy", "created", "equal", "user", "deficiency", "functionality", "filtering", "fatal", "extraction", "also", "evaluation", "somewhere", "equivalentof", "only", "income", "result", "end", "simply", "denote", "double", "forward", "pass", "stupid", "destruction", "debug", "thereafter", "crucial", "edit", "coordinate", "concentrate", "conceptual", "observation", "configuration", "concrete", "conclude", "compensation", "combine", "code", "approximately", "figure", "category", "case", "calculate", "capacity", "converter", "conversion", "construction", "consistently", "connection", "conformity", "compress", "compatibility", "combination", "arc", "check", "casting", "break", "width", "moreover", "building", "replicate", "message", "ingest", "additional", "tracking", "busy", "editing", "decision", "description", "consider", "range", "supplies", "important", "view", "views", "management", "intention", "basicinformation", "axes", "theother", "if", "latestfirst", "first", "alternate", "deviation", "finishing", "rounding", "distraction", "truncate", "closed", "derivative", "print", "address", "back", "backgroundcolor", "back", "afterwards", "view", "accept", "connecting", "creation", "indicated", "denoted", "apply"};

        int[] score = new int[1000];

        int current_word;
        int [] button_indexes = {0,0,0,0};

        int pulse = 0;

        Bitmap chart;

        int find_underscored(int from){
            for(int i = from; i < 1000; i++)
                if(score[i] < 10)
                    return i;
            return 1000;
        }

        int calculate_scored(){
            int scored = 0;
            for(int i = 0; i < 1000; i++)
                if(score[i] == 10)
                    scored += 1;
            return scored;
        }

        void next_step(){
            if( pulse % 10 == 0){
                current_word = find_underscored(0);
            }else{
                current_word = find_underscored(current_word+1);
                if(current_word == 1000)
                    current_word = find_underscored(0);
            }
            pulse += 1;

            // write progress
            label2.Text = calculate_scored().ToString() + " / 1000";

            // draw progress
            Graphics g;
            g = Graphics.FromImage(chart);
            g.Clear(Color.PowderBlue);
            Pen blue = new Pen(Brushes.SteelBlue);
            Pen green = new Pen(Brushes.ForestGreen);
            for(int i = 0; i < 1000; i++){
                if(score[i] == 10)
                    g.DrawLine(green, i % 500, 60 - 30*(i/500), i % 500, 60 - 30*(i/500) - 3*score[i]);
                else
                    g.DrawLine(blue, i % 500, 60 - 30*(i/500), i % 500, 60 - 30*(i/500) - 3*score[i]);
            }
            g.Dispose();
            pictureBox1.Refresh();

            // write progress
            System.IO.File.WriteAllLines("scores.txt", score.Select(s => (s.ToString())));

            // setup buttons
            if(current_word == 1000){
                label1.Text="Congratulations!";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                MessageBox.Show("You won!");
                return;
            }
            Random random = new Random();
            for(int i =0; i<4; i++){
                while(true){
                    button_indexes[i] = random.Next(0, 1000);
                    if(button_indexes[i] == current_word)
                        continue;
                    for(int j=0; j<i; j++)
                        if(button_indexes[i] == button_indexes[j])
                            continue;
                    break;
                }
            }
            int index_of_right = random.Next(0, 4);
            button_indexes[index_of_right] = current_word;

            label1.Text = dutch[current_word];
            if(score[current_word] == 0)
                label3.Text = english[current_word];
            else
                label3.Text = "";
            button1.Text = english[button_indexes[0]];
            button2.Text = english[button_indexes[1]];
            button3.Text = english[button_indexes[2]];
            button4.Text = english[button_indexes[3]];
        }

        void lighten_yes(){
            label_yes.ForeColor = Color.Lime;
            timer1.Interval = 500;
            timer1.Enabled = true;
        }

        void lighten_no(){
            label_no.ForeColor = Color.Red;
            timer1.Interval = 500;
            timer1.Enabled = true;
        }

        public Form1() {
            InitializeComponent();
            chart = new Bitmap(500, 60);
            pictureBox1.Image = chart;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            // load progress
            try{
                int i = 0;
                foreach(string s in System.IO.File.ReadAllLines("scores.txt"))
                {
                    score[i] = int.Parse(s);
                    i+=1;
                }
            }
            catch   // anything
            {
                score = new int[1000];
            }

            next_step();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(button_indexes[0] == current_word){
                lighten_yes();
                score[current_word] += 1;
            }else{
                lighten_no();
                score[current_word] = 0;
            }
            next_step();
        }

        private void button2_Click(object sender, EventArgs e) {
            if(button_indexes[1] == current_word){
                lighten_yes();
                score[current_word] += 1;
            }else{
                lighten_no();
                score[current_word] = 0;
            }
            next_step();
        }

        private void button3_Click(object sender, EventArgs e) {
            if(button_indexes[2] == current_word){
                lighten_yes();
                score[current_word] += 1;
            }else{
                lighten_no();
                score[current_word] = 0;
            }
            next_step();
        }

        private void button4_Click(object sender, EventArgs e) {
            if(button_indexes[3] == current_word){
                lighten_yes();
                score[current_word] += 1;
            }else{
                lighten_no();
                score[current_word] = 0;
            }
            next_step();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            label_yes.ForeColor = Color.FromArgb(0, 32, 0);
            label_no.ForeColor = Color.FromArgb(32, 0, 0);
            timer1.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
