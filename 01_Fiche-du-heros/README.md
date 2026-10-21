# 01 · La fiche du héros

> ⏱ 20 min · Seul · IA niveau 0 · Jour 1 matin

## Ce que tu vas apprendre
- Lancer un programme C# avec `dotnet run`.
- Déclarer des **variables** : du texte (`string`) et des nombres entiers (`int`).
- Afficher du texte et des valeurs avec `Console.WriteLine` et `$"..."`.

## Ta mission
1. Lance le programme tel quel : `dotnet run`. Tu dois voir « Bienvenue dans l'Arène ! ».
2. Ouvre `Program.cs` et suis les `TODO` : crée ton héros, puis affiche sa fiche.

## Ce qu'on doit voir à l'écran
```
Bienvenue dans l'Arène !
=== FICHE DU HÉROS ===
Nom     : Aria
Classe  : Guerrière
PV      : 100
Attaque : 18
Défense : 5
```
Le nom et la classe sont à toi. Les nombres viennent des [règles](../REGLES.md).

## Indices
<details><summary>Indice 1</summary>

Une variable se déclare avec son type, son nom et sa valeur : `int pv = 100;`. Le texte se met entre guillemets : `string nom = "Aria";`.
</details>
<details><summary>Indice 2</summary>

Pour afficher une variable dans une phrase, mets un `$` devant les guillemets et la variable entre accolades : `Console.WriteLine($"PV : {pv}");`.
</details>
<details><summary>Indice 3</summary>

Chaque instruction se termine par un `;`. C# fait la différence entre majuscules et minuscules : `Console`, pas `console`.
</details>

## Défis
- Ajoute une **barre de vie** sous la fiche : `new string('█', pv / 10)` répète le caractère `█` autant de fois que demandé. Que vaut `pv / 10` ?
- Encadre la fiche avec des caractères `+`, `-` et `|` pour qu'elle ressemble à une carte de jeu.
