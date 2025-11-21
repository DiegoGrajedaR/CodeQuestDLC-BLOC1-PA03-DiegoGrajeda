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

Cas "Error" --> nameWizard = ""  
|#Instrucció|#Iteració|Variables|---|---|---|---|---|
|-----------|---------|---------|---|---|---|---|---|
|-----------|---------|nameWizard|level|dayMeditionHours|dayPower|totalPower|Condition|
|1|-------|""|----|----------|--------|----------|---------|
|2|-------|""|----|----------|--------|----------|Output: "Error: Name cannot be empty"|


Cas "Normal" --> nameWizard = "byrOn"  
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

Cas 1. Generar monstre amb el seu HP segons el random
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 2 en switch|monsterNameHpOption, monstersArray, hpMonstersArray|Enter case 2|Enter case 2|
|2. Número aleatori generat per random per a monsterNameHpOption|monsterNameHpOption = 2, monstersArray [monsterNameHpOption] = "Green Slime 🟢", hpMonstersArray [monsterNameHpOption] = 10|Monstre= "Green Slime 🟢" i HP= 10|Monstre= "Green Slime 🟢" i HP= 10|
|2. Número aleatori generat per random per a monsterNameHpOption|monsterNameHpOption = 6, monstersArray [monsterNameHpOption] = "Lost Necromancer 🧝‍♂️", hpMonstersArray [monsterNameHpOption] = 20|Monstre= "Lost Necromancer 🧝‍♂️" i HP= 20|Monstre= "Lost Necromancer 🧝‍♂️" i HP= 20|

Cas 2. Generar número del dau amb random
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Escollir opció 2 en switch|diceNum|Enter case 2|Enter case 2|
|2. Premer una tecla quan demani "Press any key"|diceNum|Generar random en diceNum de 0 a 5|Generar random en diceNum de 0 a 5|
|3. Valor del diceNum|diceNum = 4|diceNum = 4 -> ASCII de dau amb 5 punts|diceNum = 4 -> ASCII de dau amb 5 punts|
|4. Imprimir missatge|diceNum = 4|Msg: "You rolled a {diceNum+1}" i ASCII dau 5 punts|Msg: "You rolled a 5" i ASCII dau 5 punts|

Cas 3. Restar HP a monstre fins 0
|Instrucció|Variables|Resultat esperat|Output|
|----------|---------|----------------|------|
|1. Apareix el monstre i demana "Press any key"|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = 5, diceNum|Enter case 2|Enter case 2|
|2. Premer una tecla, fer el random i generar valor al diceNum|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = 5, diceNum = 3|Generar random en diceNum de 0 a 5 i assignar valor|Generar random en diceNum de 0 a 5 i assignar valor|
|3. Restar HP segons diceNum (while mentre monsterMaxHp <= 0)|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = 5, diceNum = 3|monsterMaxHp -= diceNum + 1 --> monsterMaxHp = 1|monsterMaxHp -= diceNum + 1 --> monsterMaxHp = 1|
|2. Premer una tecla, fer el random i generar valor al diceNum|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = 1, diceNum = 1|Generar random en diceNum de 0 a 5 i assignar valor|Generar random en diceNum de 0 a 5 i assignar valor|
|3. Restar HP segons diceNum (while mentre monsterMaxHp <= 0)|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = 1, diceNum = 1|monsterMaxHp -= diceNum + 1 --> monsterMaxHp = -1|monsterMaxHp -= diceNum + 1 --> monsterMaxHp = -1|
|4. Mostrar missatge final|monstersArray [1] = "Forest Goblin 👹", hpMonstersArray [1] = 5, monsterMaxHp = -1, diceNum = 1|Msg: "You rolled a {diceNum+1}. The {monstersArray[1]} has 0 HP. Monster defeated!"|Msg: "You rolled a 2. The Forest Goblin 👹 has 0 HP. Monster defeated!"|

---
