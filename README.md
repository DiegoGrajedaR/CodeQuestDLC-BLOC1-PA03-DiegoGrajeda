# ⚔️ # CodeQuest: L’aventura del programador/a de videojocs

# ⚠️ Projecte

Aquest projecte consisteix en desenvolupar un codi a partir de diverses etapes que podem dir capitols, els capitols tenen la seva funcioanlitat única.

Cada capítol serà una **branca** de l’estil:
  - `chapter1/trainwizard`
  - `chapter2/increaselvl`
  - `chapter3/lootthemine`
  - `chapter4/showinventory`
  - `chapter5/buyitems`
  - `chapter6/showattacks`
  - `chapter7/decodescroll`


PD: es farà ús de issues per tenir un major control del projecte a la vegada que és farà un joc de proves
per cada capítol.

## Chapter 1. El camí del mag aprenent 🧙‍♀️

Has estat admès a l’Acadèmia d’Arcanistes, però abans de començar necessites entrenar el teu poder màgic.

Demana el **nom del mag** i defineix el seu **nivell inicial a 1**.  
Cada dia d’entrenament (**5 dies**), el mag dedica una quantitat d’hores de meditació i obté una **quantitat aleatòria de poder** entre `1` i `10` punts.

Cada dia, mostra un missatge de la seva evolució dia a dia, amb un format similar a:

Dia 3 → Azrael, ja has meditat 10 hores i el teu poder ara és de 27 punts!

Al final, mostra el **nivell final de poder**. Segons el total:

| Rang de poder | Missatge | Nivell obtingut |
|----------------|-----------|----------------|
| ≤ 20 | “Encara confons la vareta amb una cullera.” | Zyn el Buguejat |
| < 30 | “Ets un Invocador de Brises Màgiques.” | Arka Nullpointer |
| > 35 i < 40 | “Uau! Pots invocar dracs sense cremar el laboratori!” | Elarion de les Brases |
| ≥ 47 | “Has assolit el rang de Mestre dels Arcans!” | ITB-Wizard el Gris |

> 🔍 **TIP:** Investiga com crear nombres aleatoris amb la classe `Random`.

### Joc de proves Chapter 1 📓

**Cas 1 "Error" --> nameWizard = ""**
|#Instrucció|#Iteració|Variables|---|---|---|---|---|
|-----------|---------|---------|---|---|---|---|---|
|-----------|---------|nameWizard|level|dayMeditionHours|dayPower|totalPower|Condition|
|1|-------|""|----|----------|--------|----------|---------|
|2|-------|""|----|----------|--------|----------|Output: "Error: Name cannot be empty"|


**Cas 2 "Normal" --> nameWizard = "byrOn"**
|#Instrucció|#Iteració|Variables|---|---|---|---|---|
|-----------|---------|---------|---|---|---|---|---|
|-----------|---------|nameWizard|level|dayMeditionHours|dayPower|totalPower|Condition|
|1||"byrOn"|1|-|-|-|-|
|2|1|"Byron"|1|17|6|6|-|
|2|2|"Byron"|1|16|9|15|-|
|2|3|"Byron"|1|15|10|25|-|
|2|4|"Byron"|1|19|7|32|-|
|2|5|"Byron"|1|1|5|37|totalPower >= 35 and <40|
|3|-|"Byron"|1|1|5|37|Output: "Wow! You can summon dragons without burning down the lab! Byron your wizard range is Elarion of the Embers with a total power of 37!"|

---  


## Chapter 2. Increase LVL (Combat amb daus) ⚔️
Apareix un monstre aleatori amb els seus punts de vida (HP).
- El jugador tira un dau (aleatori entre 1 i 6).  
- Cada tirada resta HP al monstre i mostra un ASCII art del dau.  
- Quan el monstre arriba a 0 HP, el jugador puja un nivell (màxim nivell 5).  

|Monstre|HP|
|-------|--|
|Wandering Skeleton 💀|3|
|Forest Goblin 👹|5|
|Green Slime 🟢|10|
|Ember Wolf 🐺|11|
|Iron Golem 🤖|15|
|Giant Spider 🕷️|18|
|Lost Necromancer 🧝‍♂️|20|
|Ancient Dragon 🐉|50|

### Joc de proves Chapter 2 📓

**Cas 1. Generar monstre amb el seu HP segons el random**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 2 en switch|monsterNameHpOption, monstersArray, hpMonstersArray|Enter case 2|Enter case 2|
|2. Número aleatori generat per random per a monsterNameHpOption|monsterNameHpOption = 2, monstersArray [monsterNameHpOption] = "Green Slime 🟢", hpMonstersArray [monsterNameHpOption] = 10|Monstre= "Green Slime 🟢" i HP= 10|Monstre= "Green Slime 🟢" i HP= 10|
|2. Número aleatori generat per random per a monsterNameHpOption|monsterNameHpOption = 6, monstersArray [monsterNameHpOption] = "Lost Necromancer 🧝‍♂️", hpMonstersArray [monsterNameHpOption] = 20|Monstre= "Lost Necromancer 🧝‍♂️" i HP= 20|Monstre= "Lost Necromancer 🧝‍♂️" i HP= 20|

**Cas 2. Generar número del dau amb random**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 2 en switch|diceNum|Enter case 2|Enter case 2|
|2. Premer una tecla quan demani "Press any key"|diceNum|Generar random en diceNum de 0 a 5|Generar random en diceNum de 0 a 5|
|3. Valor del diceNum|diceNum = 4|diceNum = 4 -> ASCII de dau amb 5 punts|diceNum = 4 -> ASCII de dau amb 5 punts|
|4. Imprimir missatge|diceNum = 4|Msg: "You rolled a {diceNum+1}" i ASCII dau 5 punts|Msg: "You rolled a 5" i ASCII dau 5 punts|

**Cas 3. Restar HP a monstre fins 0**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Apareix el monstre i demana "Press any key"|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = 5, diceNum|Enter case 2|Enter case 2|
|2. Premer una tecla, fer el random i generar valor al diceNum|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = 5, diceNum = 3|Generar random en diceNum de 0 a 5 i assignar valor|Generar random en diceNum de 0 a 5 i assignar valor|
|3. Restar HP segons diceNum (while mentre monsterMaxHp <= 0)|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = 5, diceNum = 3|monsterMaxHp -= diceNum + 1 --> monsterMaxHp = 1|monsterMaxHp -= diceNum + 1 --> monsterMaxHp = 1|
|2. Premer una tecla, fer el random i generar valor al diceNum|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = 1, diceNum = 1|Generar random en diceNum de 0 a 5 i assignar valor|Generar random en diceNum de 0 a 5 i assignar valor|
|3. Restar HP segons diceNum (while mentre monsterMaxHp <= 0)|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = 1, diceNum = 1|monsterMaxHp -= diceNum + 1 --> monsterMaxHp = -1|monsterMaxHp -= diceNum + 1 --> monsterMaxHp = -1|
|4. Mostrar missatge final|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = -1, diceNum = 1|Msg: "You rolled a {diceNum+1}. The {monstersArray[1]} has 0 HP. Monster defeated!"|Msg: "You rolled a 2. The Forest Goblin 👹 has 0 HP. Monster defeated!"|

---


## Chapter 3. Loot the mine (Mineria) ⛏️
Mostra una matriu 5x5 buida al principi. El jugador té 5 intents per minar. Ha d'introduir coordenades X i Y. La matriu té posicions amb monedes (generades aleatòriament a l'inici). Si encerta, guanya entre 5 i 50 bits.  
Mostra la matriu actualitzada després de cada intent amb símbols:  
➖ = No excavat  
🪙 = Moneda trobada  
❌ = Excavat sense èxit  

### Joc de proves Chapter 3 📓
**Cas 1. Cas normal només toca moneda un cop**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|Usuari no ha fet inputs|coordX, coordY, wizardCoins, winCoins, attempts = 1|||
|Usuari fa 1r input|coordX = 0, coordY = 0, wizardCoins = 0, winCoins = 0, attempts = 1|Msg -> "❌ Nothing found..."|Msg -> "❌ Nothing found..."|
|Usuari fa 2n input|coordX = 1, coordY = 1, wizardCoins = 0, winCoins = 0, attempts = 2|Msg -> "❌ Nothing found..."|Msg -> "❌ Nothing found..."|
|Usuari fa 3r input|coordX = 2, coordY = 2, wizardCoins = 0, winCoins = 0, attempts = 3|Msg -> "❌ Nothing found..."|Msg -> "❌ Nothing found..."|
|Usuari fa 4t input|coordX = 3, coordY = 3, wizardCoins = 0, winCoins = 0, attempts = 4|Msg -> "❌ Nothing found..."|Msg -> "❌ Nothing found..."|
|Usuari fa 5è input|coordX = 4, coordY = 4, wizardCoins = 0, winCoins = 40, attempts = 5|Msg -> “🪙 You found a coin!”|Msg -> “🪙 You found a coin!”|
|Usuari ja ha minat 5 cops|coordX = 4, coordY = 4, wizardCoins = 40, winCoins = 40, attempts = 5|Msg -> “===== Mining Finished! Total bits obtained: {wizardCoins} 🔥 =====”|Msg -> “===== Mining Finished! Total bits obtained: 40 🔥 =====”|

**Cas 2. Cas error caràcter no vàlid o fora de rang (no gasten intents)**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|Usuari no ha fet inputs|coordX, coordY, wizardBits, winCoins, attempts = 1|||
|Usuari fa 1r input|coordX = 0, coordY = 0, wizardBits = 0, winCoins = 0, attempts = 1|Msg -> "❌ Nothing found..."|Msg -> "❌ Nothing found..."|
|Usuari fa 2n input|coordX = "Hola", coordY = 1, wizardBits = 0, winCoins = 0, attempts = 2|Msg -> "❌ Invalid input! Must be numbers between 0 and 4."|Msg -> "❌ Invalid input! Must be numbers between 0 and 4."|
|Usuari fa 3r input|coordX = 1, coordY = 1, wizardBits = 0, winCoins = 0, attempts = 2|Msg -> "❌ Nothing found..."|Msg -> "❌ Nothing found..."|
|Usuari fa 4t input|coordX = 2, coordY = 2, wizardBits = 0, winCoins = 0, attempts = 3|Msg -> "❌ Nothing found..."|Msg -> "❌ Nothing found..."|
|Usuari fa 5è input|coordX = 90, coordY = 35, wizardBits = 0, winCoins = 0, attempts = 4|Msg -> "❌ Invalid coordinates! Must be between 0 and 4."|Msg -> "❌ Invalid coordinates! Must be between 0 and 4."|
|Usuari fa 6è input|coordX = 3, coordY = 3, wizardBits = 0, winCoins = 0, attempts = 4|Msg -> "❌ Nothing found..."|Msg -> "❌ Nothing found..."|
|Usuari fa 7è input|coordX = 4, coordY = 4, wizardBits = 0, winCoins = 40, attempts = 5|Msg -> “🪙 You found a coin!”|Msg -> “🪙 You found a coin!”|
|Usuari ja ha minat 5 cops|coordX = 4, coordY = 4, wizardBits = 40, winCoins = 40, attempts = 5|Msg -> “===== Mining Finished! Total bits obtained: {wizardBits} 🔥 =====”|Msg -> “===== Mining Finished! Total bits obtained: 40 🔥 =====”|

---


## Chapter 4. Show inventory 🎒
Aquest capítol mostra tots els objectes comprats en la tenda del capítol 5.  
Si està buit, indica que no hi ha objectes, en cas contrari es mostraran tots els items que tinguis.

### Joc de proves Chapter 4 📓
**Cas 1. El usuari/mag no té cap objecte en el inventari, és a dir, no ha comprat res.**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 4 en el switch (MENÚ principal)| wizardInventory|Enter case 4|Enter case 4|
|2. Mostrar inventory| wizardInventory = new string[0]|Msg -> "Your inventory is empty." |Msg -> "Your inventory is empty."|

**Cas 2. El usuari/mag té objectes en el inventari, per exemple 3 objectes**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 4 en el switch (MENÚ principal)| wizardInventory|Enter case 4|Enter case 4|
|2. Mostrar inventory| wizardInventory = [ "Healing Potion ⚗️", "Metal Shield 🛡️", "Crossbow 🏹" ]|Msg -> "Your inventory of items contains: - Healing Potion ⚗️ - Metal Shield 🛡️ - Crossbow 🏹" |Msg -> "Your inventory of items contains: - Healing Potion ⚗️ - Metal Shield 🛡️ - Crossbow 🏹"|
---


## Chapter 5. Buy items 🛒
Mostra els objectes disponibles amb els seus preus. El jugador selecciona un número del 1 al 5 per comprar o el número 0 per sortir de la tenda de items.  
El mag ha de tenir prou bits per poder comprar, en cas de tenir suficients es compra l'objecte i s'afegeix a l'inventari però, en cas contrari no pots comprar en la tenda i surts d'aquesta. IMPORTANT: Els bits es descompten, recorda minar per tenir suficients!

|Objecte|Preu (bits)|
|-------|-----------|
|Iron Dagger 🗡️|30|
|Healing Potion ⚗️|10|
|Ancient Key 🗝️|50|
|Crossbow 🏹|40|
|Metal Shield 🛡️|20|

### Joc de proves Chapter 5 📓
**Cas 1. El usuari/mag entra a la tenda i fa un input de valor no numéric**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 5 en el switch (MENÚ principal)|selectedItem|Enter case 5|Enter case 5|
|2. Dins de la tenda l'usuari posa un input tipus string|selectedItem = "Hola"|Msg -> "❌ Invalid Input"|Msg -> "❌ Invalid Input"|
|3. Surts de la tenda|selectedItem = "Hola"|Return to main menu|Return to main menu|

**Cas 2. El usuari/mag entra a la tenda i fa un input númeric fora del rang**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 5 en el switch (MENÚ principal)|validOptionShop= false, selectedItem|Enter case 5|Enter case 5|
|2. Dins de la tenda l'usuari posa un input fora de rang|validOptionShop= false, selectedItem = 90|Msg -> "❌ Invalid option. Choose an option between 0 and 5."|Msg -> "❌ Invalid option. Choose an option between 0 and 5."|
|3. Torna a demanar un altre input fins que sigui valid (bucle while fins que validOptionShop = true)|validOptionShop = false, selectedItem = 90|Msg -> "Choose an item to buy (1-5), or 0 to exit:"|Msg -> "Choose an item to buy (1-5), or 0 to exit:"|

**Cas 3. El usuari/mag entra a la tenda i escull la opció 0 (sortir tenda)**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 5 en el switch (MENÚ principal)|validOptionShop= false, selectedItem|Enter case 5|Enter case 5|
|2. Dins de la tenda l'usuari posa un input numéric vàlid|validOptionShop= true, selectedItem = 0|Msg -> "Leaving the shop... Thank you for your visit."|Msg -> "Leaving the shop... Thank you for your visit."|
|3. Surts de la tenda|validOptionShop= true, selectedItem = 0|Return to main menu|Return to main menu|

**Cas 4. El usuari/mag entra a la tenda i compra un objecte però  no té els bits suficients**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 5 en el switch (MENÚ principal)|validOptionShop= false, selectedItem|Enter case 5|Enter case 5|
|2. Dins de la tenda l'usuari posa un input numéric vàlid|validOptionShop= true, selectedItem = 2, shopItemsArray[selectedItem -1] = "Healing Potion ⚗️", shopPricesArray[selectedItem - 1] = 10, wizardBites = 0|Msg -> "❌ You don't have enough bits!"|Msg -> "❌ You don't have enough bits!"|
|3. Surts de la tenda|validOptionShop= true, selectedItem = 2, shopItemsArray[selectedItem -1] = "Healing Potion ⚗️", shopPricesArray[selectedItem - 1] = 10, wizardBites = 0|Return to main menu|Return to main menu|

**Cas 5. El usuari/mag entra a la tenda i compra un objecte**
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 5 en el switch (MENÚ principal)|validOptionShop= false, selectedItem|Enter case 5|Enter case 5|
|2. Dins de la tenda l'usuari posa un input numéric vàlid|validOptionShop= true, selectedItem = 2, shopItemsArray[selectedItem -1] = "Healing Potion ⚗️", shopPricesArray[selectedItem - 1] = 10, wizardBites = 30|Msg -> "✔️ You bought: {shopItemsArray[selectedItem - 1]} for {shopPricesArray[selectedItem - 1]} bits."|Msg -> "✔️ You bought: Healing Potion ⚗️ for 10  bits."|
|3. Surts de la tenda|validOptionShop= true, selectedItem = 2, shopItemsArray[selectedItem -1] = "Healing Potion ⚗️", shopPricesArray[selectedItem - 1] = 10, wizardBites = 30|Return to main menu and updated wizardInventory|Return to main menu and updated wizardInventory|

---