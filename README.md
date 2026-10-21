# L'Arène · Dossier de départ (jours 1 et 2)

Pendant deux jours, tu construis un vrai petit jeu : un **combat au tour par tour** en console. Chaque dossier est une **étape**. Chaque étape ajoute une notion au jeu.

## Démarrer

1. Décompresse ce dossier où tu veux (par exemple dans `Documents`).
2. Ouvre le kit dans ton éditeur :
   - **Rider** : **Open**, puis choisis le fichier `Arene.sln`. Toutes les étapes apparaissent à gauche.
   - **Visual Studio** : **Ouvrir un projet ou une solution**, puis `Arene.sln`.
   - **VS Code** : **Fichier > Ouvrir le dossier**, puis le dossier `Arene`.
3. Ouvre le terminal intégré : **View > Tool Windows > Terminal** dans Rider (`Alt+F12`), **Affichage > Terminal** dans Visual Studio, **Terminal > Nouveau terminal** dans VS Code.
4. Va dans l'étape et lance-la :

```
cd 01_Fiche-du-heros
dotnet run
```

Pour passer à l'étape suivante : `cd ..` puis `cd 02_Premier-coup`.

Dans Rider ou Visual Studio, tu peux aussi choisir l'étape dans la liste en haut et cliquer sur ▶. Ne lance pas « Build Solution » : les programmes du donjon des bugs sont cassés exprès, la compilation de tout le kit échouera.

## Les dossiers

| Dossier | Quand | Ce que tu ajoutes au jeu |
|---|---|---|
| `00_Ordinateur-humain` | J1 matin | Le dessin secret de l'atelier d'ouverture |
| `01_Fiche-du-heros` | J1 matin | Les variables : la fiche de ton héros |
| `02_Premier-coup` | J1 matin | Les calculs : un coup d'épée |
| `03_Coup-critique` | J1 matin | Les conditions : le coup critique |
| `K_Donjon-des-bugs` | J1 après-midi | Sept programmes cassés à réparer |
| `04_Choix-du-joueur` | J1 après-midi | Le menu : attaquer, se soigner, fuir |
| `05_Regles-du-combat` | J1 après-midi | Les booléens : ET, OU, NON |
| `06_Tour-complet` | J1 après-midi | Un tour de jeu complet |
| `07_Combat-complet` | J2 matin | La boucle while : le combat entier |
| `08_Saisie-incassable` | J2 matin | Une saisie que rien ne fait planter |
| `09_Barres-de-vie` | J2 matin | La boucle for et les statistiques |
| `R_Boucles-a-reparer` | J2 matin | Quatre boucles cassées |
| `10_Projet-Arene` | J2 après-midi | Le jeu complet, par paliers |
| `11_Revue-code-IA` | J2 après-midi | Le code d'une IA à vérifier |

Les règles du jeu sont dans [REGLES.md](REGLES.md).

## Chaque étape repart de la solution de la précédente

Tu peux continuer dans ton propre code ou repartir du dossier de l'étape : les deux marchent. Si tu as manqué une séance, ouvre l'étape où en est la classe et lis son README : tu peux reprendre le fil de là.

## Les repères

- **⏱ 25 min** : le temps prévu. Si tu bloques plus de 10 minutes, ouvre un indice.
- **IA niveau 0** : sans IA, pour construire tes réflexes. **Niveau 1** : l'IA explique, mais n'écrit pas ton code. **Niveau 2** : l'IA peut proposer du code, que tu dois relire, tester et savoir refaire.
- **Défi** : pour aller plus loin quand tu as fini.
- La règle unique : **tu dois pouvoir expliquer tout ce que tu rends.**

## Si ça coince

- **Des avertissements jaunes** (`warning CS0219`, variable jamais utilisée) : c'est normal tant que tu n'as pas fini l'étape.
- **Le programme ne s'arrête plus** : `Ctrl+C` dans le terminal.
- **Les accents ou les █ s'affichent mal** sous Windows : ajoute cette ligne tout en haut de `Program.cs` :
  `Console.OutputEncoding = System.Text.Encoding.UTF8;`
- **`dotnet` est inconnu** : l'installation de la fiche C# n'est pas terminée. En attendant, colle ton code sur **dotnetfiddle.net**.
