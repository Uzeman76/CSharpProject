# Les règles de l'Arène

Les règles précises du game designer. Elles répondent aux questions que la demande de départ laissait floues.

## Les combattants

| | PV max | Attaque | Défense | Particularité |
|---|---|---|---|---|
| **Le héros** | 100 | 18 | 5 | Commence avec 2 potions |
| **Gobelin** | 80 | 14 | 3 | |
| **Orc** (projet) | 100 | 14 | 4 | |
| **Dragon** (projet) | 120 | 16 | 5 | C'est un boss |

## Un tour de jeu

1. **Le héros agit** : il attaque, boit une potion ou tente de fuir.
2. **Le monstre riposte**, s'il a encore des PV et si le héros n'a pas fui.

Le combat s'arrête quand l'un des deux n'a plus de PV, ou quand le héros a fui.

## Les règles

- **Dégâts** = attaque de celui qui frappe − défense de celui qui reçoit.
- **Coup critique** : à chaque attaque du héros, on tire un nombre entre 1 et 100. S'il vaut 20 ou moins (20 % de chances), les dégâts sont doublés. Le monstre ne fait pas de critique.
- **Potion** : rend 30 PV, sans jamais dépasser le maximum. Impossible s'il n'en reste plus.
- **Fuite** : possible seulement si le héros a moins du tiers de ses PV max, et jamais contre un boss.
- **Rage** : un monstre qui a moins de la moitié de ses PV max gagne +5 en attaque.
- **Les PV ne sont jamais négatifs** : un combattant qui passe sous 0 a 0 PV.

## Des cas de test

| Situation | Résultat attendu |
|---|---|
| Le héros frappe le gobelin, le jet vaut 21 | 15 dégâts |
| Le héros frappe le gobelin, le jet vaut 20 | 30 dégâts (critique) |
| Le héros a 85 PV et boit une potion | 100 PV, pas 115 |
| Le héros a 33 PV sur 100 et veut fuir | Impossible : 33 n'est pas inférieur à 33 (100 / 3) |
| Le gobelin a 40 PV sur 80 | Pas de rage : 40 n'est pas inférieur à 40 |
| Le gobelin a 39 PV sur 80 et frappe | 14 + 5 − 5 = 14 dégâts |
| Le gobelin a 10 PV et reçoit 15 dégâts | Il a 0 PV, pas −5, et il ne riposte pas |
