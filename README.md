# DOKUMENTÁCIÓ

### ⚠️ FIGYELEM: EZ A PROGRAM CSAKIS TANULMÁNYI CÉLOKBÓL KÉSZÜLT.
### ⚠️ ATTENTION: THIS PROGRAM WAS ONLY MADE FOR EDUCATIONAL PURPOSES

<br>

# *Szókitaláló / Akasztófa*

<br>

# Kinézet
## Megjelenítés
> A program egyszerű terminál alapú megjelenítéssel működik.
<img width="1172" height="664" alt="kép" src="https://github.com/user-attachments/assets/e92adc88-71d1-43d7-94b1-148aa91050a6" />

---

## Dizájn
> Dizájnjában igyekszik a mindenki által ismert akasztófa játék hangulatát előidézni az egyszerű ábrával és eddig tippelt helytelen betűk feljegyzésével
<img width="1155" height="689" alt="kép" src="https://github.com/user-attachments/assets/02f06438-3e20-4f3e-8ffe-d527d5f92585" />
<img width="1154" height="677" alt="kép" src="https://github.com/user-attachments/assets/ffbfa29f-007c-44ea-8207-cff4081cca88" />


---

## Életerő kijelzés 
Egyszerű életerő kijelző rendszer
> Azon játékosok számára akik nem ismerik teljese a játékot (vagy azok számára akik esetleg nem lennének teljesen tisztában a játékban a még felhasználható tippek számának leolvasásával az ábráról) korszerű életerő kijelző rendszer is szerepel a kezelőfelületen melyről könnyedén leolvasható hogy áll a tippek mennyiségében

<img width="216" height="129" alt="kép" src="https://github.com/user-attachments/assets/5203ffa8-4e77-4c45-81a7-3847d0c3c8e8" />

---


# Program működése

<br>

## Főbb programozási elvek, szempontok
> A program C# nyelvben lett írva. A program fejlesztése során fontos szempont volt a kód olvashatósága, egyszerűsége és természetesen gyors futási ideje.

> A program számos kommenttel lett ellátva az olvashatóság, értelmezhetőség érdekében, emellett a *clean code* elv alkalmazásával jó néhány programrész ki lett szervezve függvényekbe

<br>

# Main - A "Fő program(rész)"
> A Fő programrészben először néhány a programban használt változók inicializálása történik, ezek mellett a lehetséges szavakat tartalmazó lista feltöltése is megtörténik itt

> A Fő programrész ezen részében ezek mellett az eredményt tartalmazó lista (EredLista) és a szóból készített "munka" lista (HelyesLista) is feltöltésre kerülnek

> Ezek után a programban megtörténik egy kezdeti megjelenítése ami a felhasználói felületet előhozza és így kezdőthet a játék

<img width="1437" height="611" alt="kép" src="https://github.com/user-attachments/assets/be9a21e3-a96f-465d-8fe3-485fc7f3f636" />

##

> A fő loop bekéri a felhasználótól a tippjét (tehát a betűt amire gondol hogy benne van a szóban)

> A fő loopban a tipp helyességének ellenőrzése is megesik (tényleg csak 1 betűt adott meg? adott-e meg betűt?)

> Amennyiben a helytelen megadott betűk már tartalmazzák a tippet így nem kezd bele egy hosszabb ellenőrzésbe és egyből figyelmezteti a felhasználót

> Elindítja az ellenőrzést (BenneVanE) Ezután annak megfelelően jár el (hogy benne volt-e a tipp a szóban vagy nem) tehát megjeleníti a Benne van! vagy Nincs benne! szöveggel a játékteret, levon az életerőből és az ábrát az életerő mennyiségéből kirajzolja az Akasztofa Eljárás

> Mindez addig megy amíg a felhasználónak el nem fogyott az életereje vagy ki nem találta a szót

<img width="682" height="833" alt="kép" src="https://github.com/user-attachments/assets/5dde7e35-eba8-4dd2-b77b-4d1cee17d9d4" />

##

> A Főprogramrész vége vizsgálja a fő loopból való kilépés okát Majd az oknak megfelelően jár el (Tájékoztatja a felhasználót hogy elveszette vagy megnyerte a játékot)

<img width="993" height="376" alt="kép" src="https://github.com/user-attachments/assets/a72115c8-a459-4418-91a5-ae6fcf87ccca" />

---

<br>

# A program függvényei/eljárásai/kiszervezett programrészei (alprogramjai)

## HelyesListaFeltoltes azaz a kitalálandó szóból lista generálás
> Ez a függvény a véletlenszerűen kiválaszott szó karaktereiből egy listát készít amivel a program később majd dolgozni fog
<img width="754" height="178" alt="kép" src="https://github.com/user-attachments/assets/e16b2c5e-51f4-4610-a829-ba44dbdb86af" />

---

## EredListaFeltoltes azaz a felhasználó játékhoz használt listájának generálása
> Ez a függvény generál egy listát amiben a felhasználó tippjei fognak elhelyezkedni és annak az eldöntése érdekében hogy a játékos eltalálta-e a szót ezt a listát fogja segítségül venni, valamint ezt a listát fogja megjeleníteni

> A listát eleinte _ karakterekkel töltjük meg hogy a betűk helyeit látni lehessen
<img width="620" height="174" alt="kép" src="https://github.com/user-attachments/assets/ea00efdb-8a22-46a8-b437-7019e51f8e8b" />

---

## BenneVanE
> Feladata hogy ellenőrzi hogy a paraméterként megadott string benne van-e a szóban és hogy melyik helyeken található
<img width="973" height="396" alt="kép" src="https://github.com/user-attachments/assets/351bb33a-be1d-4825-b321-8dd900415223" />

---

## Megjelenites
> Ez az eljárás felel a felhasználói felület megjelenítéséért a megfelelő paraméterként megadott tájékoztató szöveggel

> Megjeleníti az életerőt és meghívja az Akasztofa eljárást továbbá kijelzi az eddig megadott hibás betűket is

<img width="1429" height="840" alt="kép" src="https://github.com/user-attachments/assets/f1f4521e-f2f9-41db-baad-7f9529c2c7f3" />

---

## Akasztofa
> Ez az eljárás felel az akasztófa ábra megjelenítéséért, a takarékosság érdekében csak a szükséges szimbólumokat tároljuk el majd azokból a program fogja összeállítani az ábrát

> Az ábra megjelenítése a játékfelület jobb oldalára történik

> Ennél az eljárásnál 2 dimenziós lista is alkalmazva lett a szimbólumok pozíciójának tárolására

> Az eljárásnak egyedül az életerőre van szüksége hogy ki tudja rajzolni a megfelelő akasztófa állapotot

<img width="1381" height="755" alt="kép" src="https://github.com/user-attachments/assets/b004ac50-7a98-46ba-805b-22bdfcc784a0" />
