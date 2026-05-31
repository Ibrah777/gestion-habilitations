# Gestion des Habilitations — C# WinForms

Application Windows Forms développée en C# dans le cadre du **BTS SIO SLAM** (CNED).  
Basée sur le squelette fourni par le CNED, architecture MVC + couche DAL + BddManager.

---

## Fonctionnalités

- Afficher la liste des développeurs (nom, prénom, tél, mail, profil)
- Ajouter un développeur (mot de passe initialisé par défaut = nom)
- Modifier un développeur
- Supprimer un développeur
- Modifier le mot de passe d'un développeur

---

## Architecture (MVC)

```
habilitations2024/
├── model/
│   ├── Developpeur.cs          # Modèle développeur
│   └── Profil.cs               # Modèle profil
├── dal/
│   ├── Access.cs               # Classe mère DAL
│   ├── DeveloppeurAccess.cs    # Requêtes SQL développeurs
│   └── ProfilAccess.cs         # Requêtes SQL profils
├── bddmanager/
│   └── BddManager.cs           # Singleton connexion MySQL
├── controller/
│   └── FrmHabilitationsController.cs
├── view/
│   ├── FrmHabilitations.cs     # Vue principale
│   └── FrmHabilitations.Designer.cs
├── App.config                  # Chaîne de connexion MySQL
└── habilitations.sql           # Script création BDD
```

---

## Installation

**Prérequis** : Visual Studio 2019+, MySQL (WAMP), MySQL Connector NET 9.1

1. Exécuter `habilitations.sql` dans MySQL
2. Ouvrir `habilitations2024.sln` dans Visual Studio
3. Vérifier le chemin de `MySql.Data.dll` dans les références
4. Adapter la chaîne de connexion dans `App.config` si besoin
5. Lancer (F5)

---

## Compétences mobilisées (BTS SIO)

- **Mettre en place et vérifier les niveaux d'habilitation** associés à un service
- **Architecture MVC** + couche DAL + pattern Singleton
- **Base de données MySQL** — requêtes préparées, JOIN
- **WinForms** — DataGridView, ComboBox, événements

---

## Auteur

**Ibrahima Dione** — BTS SIO SLAM (CNED, 2025-)  
[LinkedIn](https://www.linkedin.com/in/el-hadj-ibrahima-dione777/)
