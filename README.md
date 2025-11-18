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
