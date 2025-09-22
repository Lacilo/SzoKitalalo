### ⚠️ FIGYELEM: EZ A PROGRAM CSAKIS TANULMÁNYI CÉLOKBÓL KÉSZÜLT.
### ⚠️ ATTENTION: THIS PROGRAM WAS ONLY MADE FOR EDUCATIONAL PURPOSES

<br>

# *Szókitaláló / Akasztófa*

<br>

# Kinézet 🖥️
## Megjelenítés
> A program egyszerű terminál alapú megjelenítéssel működik.
<img width="1172" height="664" alt="kép" src="https://github.com/user-attachments/assets/e92adc88-71d1-43d7-94b1-148aa91050a6" />

---

## Dizájn ✨
> Dizájnjában igyekszik a mindenki által ismert akasztófa játék hangulatát előidézni az egyszerű ábrával és eddig tippelt helytelen betűk feljegyzésével
<img width="1155" height="689" alt="kép" src="https://github.com/user-attachments/assets/02f06438-3e20-4f3e-8ffe-d527d5f92585" />

---

## Életerő kijelzés 
Egyszerű életerő kijelző rendszer
> Azon játékosok számára akik nem ismerik teljese a játékot (vagy azok számára akik esetleg nem lennének teljesen tisztában a játékban a még felhasználható tippek számának leolvasásával az ábráról) korszerű életerő kijelző rendszer is szerepel a kezelőfelületen melyről könnyedén leolvasható hogy áll a tippek mennyiségében

<img width="216" height="129" alt="kép" src="https://github.com/user-attachments/assets/5203ffa8-4e77-4c45-81a7-3847d0c3c8e8" />

---


# Program működése ⚙️

<br>

## Főbb programozási elvek, szempontok
> A program C# nyelvben lett írva. A program fejlesztése során fontos szempont volt a kód olvashatósága, egyszerűsége és természetesen gyors futási ideje.

> A program számos kommenttel lett ellátva az olvashatóság, értelmezhetőség érdekében, emellett a *clean code* elv alkalmazásával jó néhány programrész ki lett szervezve függvényekbe

<br>

# A program függvényei

## HelyesListaFeltoltes azaz a kitalálandó szóból lista generálás
> Ez a függvény a véletlenszerűen kiválaszott szó karaktereiből egy listát készít amivel a program később majd dolgozni fog
<img width="754" height="178" alt="kép" src="https://github.com/user-attachments/assets/e16b2c5e-51f4-4610-a829-ba44dbdb86af" />

## EredListaFeltoltes azaz a felhasználó játékhoz használt listájának generálása
> Ez a függvény generál egy listát amiben a felhasználó tippjei fognak elhelyezkedni és annak az eldöntése érdekében hogy a játékos eltalálta-e a szót ezt a listát fogja segítségül venni, valamint ezt a listát fogja megjeleníteni
> A listát eleinte _ karakterekkel töltjük meg hogy a betűk helyeit látni lehessen
<img width="620" height="174" alt="kép" src="https://github.com/user-attachments/assets/ea00efdb-8a22-46a8-b437-7019e51f8e8b" />

## BenneVanE
> A függvény ami ellenőrzi hogy a paraméterként megadott string benne van-e a szóban és hogy melyik helyeken található
<img width="973" height="396" alt="kép" src="https://github.com/user-attachments/assets/351bb33a-be1d-4825-b321-8dd900415223" />

## Megjelenites
> Ez az eljárás felel a felhasználói felület megjelenítéséért a megfelelő paraméterként megadott tájékoztató szöveggel
<br>
> Megjeleníti az életerőt és meghívja az Akasztofa eljárást továbbá kijelzi az eddig megadott hibás betűket is

<img width="1429" height="840" alt="kép" src="https://github.com/user-attachments/assets/f1f4521e-f2f9-41db-baad-7f9529c2c7f3" />


## Akasztofa
> Ez az eljárás felel az akasztófa ábra megjelenítéséért, a takarékosság érdekében csak a szükséges szimbólumokat tároljuk el majd azokból a program fogja összeállítani az ábrát
<br>
> Az ábra megjelenítése a játékfelület jobb oldalára történik
