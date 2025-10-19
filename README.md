# ExtinctHeure

## Description

**Projet universitaire**

Application créée en C# avec l'application Visual Studio permettant de gérer une caserne de pompier, en se basant sur une base de donnée SQLite.

<!-- image(s) -->

## Technologies utilisées

**Langage :** C#

**Base de donnée :** SQLite

**Application :** Visual Studio
> [!Warning]  
> L'application n'est disponible que sous windows.

## Installation

Cloner le repo :
```bash
git clone https://github.com/FireFeather5/Application-de-gestion
```
Ou télécharger tous les fichiers à la main.

Installer Visual Studio.

Ouvrir le fichier `ExtinctHeure.sln` dans l'aaplication (ce qui ouvrira tout le projet).

<!-- a revoir
    Vérifier que SQLite est installé

    Projet > Gérer les paquets Nuget > System.Data.SQLite.Core > installer
-->

Lancer l'exécution depuis l'application.

## Fonctionnalités

### Volet 1 : Tableau de bord

Fenêtre d'accueil de l'application, ou sont affichées les missions en cours. Avec possibilité de cloturer chaque mission, ainsi que de créer un PDF résumant la mission.

### Volet 2 : Création de nouvelles missions

Fenêtre permettant de créer de nouvelles missions, et qui assigne automatiquement des engins et des pompiers en fonction du sinistre et de la caserne choisis.

### Volet 3 : Visualisation des engins

Fenêtre permettant d'afficher tout les engins un par un caserne par caserne, et d'afficher si l'engin est en mission ou en panne.

### Volet 4 : Gestion du personel

Fenêtre permattant de gérer les différents pompiers en affichant leurs informations, et en pouvant les modifier. ce volet permet aussi la création de nouveaux pompiers.

### Volet 5 : Statistiques

Fenêtre affichant différentes statistiques sur les casernes, les pompiers, et les sinistres.
