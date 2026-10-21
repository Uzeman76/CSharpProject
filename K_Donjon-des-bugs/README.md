# K · Le donjon des bugs

> ⏱ 35 min · En binôme · IA niveau 0 · Jour 1 après-midi

Sept programmes cassés, un par dossier, du plus simple au plus sournois. Pour chacun :

1. Lance-le : `cd K1` puis `dotnet run`.
2. **Lis le message d'erreur** : le fichier, la ligne et la colonne, le code (`CS1002`) et l'explication.
3. Écris dans un commentaire ce que dit l'erreur, avec tes mots.
4. Corrige, relance, vérifie.

| Programme | Type de problème |
|---|---|
| K1 à K5 | Le programme **ne compile pas** : le compilateur te dit où regarder |
| K6 | Le programme tourne, mais **le résultat est faux** : personne ne te prévient |
| K7 | Le programme compile, mais **plante pendant l'exécution** avec certaines saisies |

Méthode : lis **la première erreur seulement**. Les suivantes en découlent souvent. Si le message est obscur, cherche son code (par exemple `CS0029`) sur learn.microsoft.com.

## Défi
Pour K7 : fais en sorte que le programme ne plante plus jamais. Cherche ce que fait `int.TryParse` dans la documentation.
